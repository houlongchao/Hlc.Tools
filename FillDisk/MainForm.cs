using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FillDisk
{
    public partial class MainForm : Form
    {
        private static readonly string[] SizeSuffixes = {"bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"};
        private const string FILE_PREFIX = "HLC_FILLDISK_";
        private Dictionary<string, DriveInfo> driveDict = new Dictionary<string, DriveInfo>();
        private int selectedIndex = -1;
        private ContextMenuStrip contextMenu;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            suuperDrag();

            reloadDriveInfo();

            _modeCmb.SelectedIndex = 0;
            selectedIndex = selectedIndex < 0 ? driveDict.Count - 1 : selectedIndex;
            _diskCmb.SelectedIndex = selectedIndex;

            reloadData();
        }


        #region 私有方法

        
        /// <summary>
        /// 重新加载磁盘信息
        /// </summary>
        private void reloadDriveInfo()
        {
            _diskCmb.Items.Clear();
            driveDict.Clear();

            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                driveDict.Add(driveInfo.Name, driveInfo);
            }
            _diskCmb.Items.AddRange(driveDict.Keys.ToArray());
        }

        /// <summary>
        /// 重新填充数据
        /// </summary>
        private void reloadData()
        {
            _diskCmb.SelectedIndex = selectedIndex;
            _freeSize.Text = format1024(driveDict[_diskCmb.SelectedItem.ToString()].AvailableFreeSpace);

            _fillDataFiles.Rows.Clear();

            foreach (var fileInfo in new DirectoryInfo(_diskCmb.SelectedItem.ToString()).GetFiles(FILE_PREFIX + "*"))
            {
                _fillDataFiles.Rows.Add(fileInfo.Name, format1024(fileInfo.Length));
            }
        }

        /// <summary>
        /// 格式化bytes到可读性显示字符串
        /// </summary>
        /// <param name="value">bytes大小</param>
        /// <returns>可读性字符串，如：1.0 GB </returns>
        private string format1024(long value)
        {
            if (value < 0)
            {
                return "-" + format1024(-value);
            }
            if (value == 0)
            {
                return "0.0 bytes";
            }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }


        /// <summary>
        /// 解析大小
        /// </summary>
        /// <param name="sizeText">存储大小字符串，如：10M，1 K, 2GB</param>
        /// <returns>解析后的bytes大小</returns>
        private long parseSize(string sizeText)
        {
            var match = Regex.Match(sizeText, @"^(?<size>[\d\.]+)\W*((?<suffix>[GMKgmk])[Bb]?)?");
            var sizeGroup = match.Groups["size"];
            if (!sizeGroup.Success)
            {
                throw new ArgumentException("存储容量必须以数字开始，例如：128M");
            }
            var size = double.Parse(sizeGroup.Value);

            var suffix = match.Groups["suffix"].Success ? match.Groups["suffix"].Value.ToUpper() : "K";

            switch (suffix)
            {
                case "G":
                    size *= 1024 * 1024 * 1024;
                    break;
                case "M":
                    size *= 1024 * 1024;
                    break;
                case "K":
                    size *= 1024;
                    break;
            }

            return (long)Math.Floor(size);
        }

        #endregion

        #region 事件

        private void _runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long size = parseSize(_sizeTxt.Text);
                _sizeTxt.Text = format1024(size);
                var selectedDrive = driveDict[_diskCmb.SelectedItem.ToString()];
                if (selectedDrive.AvailableFreeSpace < size)
                {
                    MessageBox.Show("输入大小大于当前磁盘剩余空间，请修改！");
                    return;
                }

                switch (_modeCmb.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        size = selectedDrive.AvailableFreeSpace - size;
                        break;
                }

                var fileName = Path.Combine(selectedDrive.Name, FILE_PREFIX + Guid.NewGuid().ToString("D"));
                using (var fileStream = new FileStream(fileName, FileMode.CreateNew))
                {
                    fileStream.SetLength(size);
                }

                reloadDriveInfo();
                reloadData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //刷新按钮
        private void _refreshBtn_Click(object sender, EventArgs e)
        {
            reloadDriveInfo();
            reloadData();
        }

        
        ///GradView单元格点击事件
        private void _fillDataFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                var path = Path.Combine(_diskCmb.SelectedItem.ToString(), _fillDataFiles.Rows[e.RowIndex].Cells[0].Value.ToString());
                try
                {
                    File.Delete(path);
                }
                catch (Exception)
                {
                    MessageBox.Show(this.Owner, "删除失败");
                    return;
                }
                
                reloadDriveInfo();
                reloadData();
                if (_fillDataFiles.SortOrder != SortOrder.None)
                {
                    _fillDataFiles.Sort(_fillDataFiles.SortedColumn, _fillDataFiles.SortOrder == SortOrder.Descending ? ListSortDirection.Descending : ListSortDirection.Ascending);
                }
               
                _fillDataFiles.ClearSelection();
                    ;
            }
        }


        private void _diskCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = _diskCmb.SelectedIndex;
            
            reloadData();
        }

        private void _fillDataFiles_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name.Equals("FileSize"))
            {
                e.SortResult = parseSize(e.CellValue1.ToString()).CompareTo(parseSize(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }

        #endregion


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

        }
        
        private void suuperDrag()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.MouseDown += (sender, args) =>
                    {
                        ReleaseCapture();
                        SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                    };
                }

            }
        }
    }
}
