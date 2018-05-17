using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using 图片压缩包合并.Properties;

namespace 图片压缩包合并
{
    public partial class MainForm : Form
    {
        private string imgPath;
        private string zipPath;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_img_title.Text = "客官，拖个图片上来";
            lb_zip_title.Text = "客官，拖个压缩包上来";

            this.MouseDown += (s, args) =>
             {
                 ReleaseCapture();
                 SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
             };
            suuperDrag(this.Controls);
        }

        private void pl_zip_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            pl_zip.BorderStyle = BorderStyle.FixedSingle;
            lb_zip_title.Text = "客官，可以放手了";
        }

        private void pl_zip_DragLeave(object sender, EventArgs e)
        {
            pl_zip.BorderStyle = BorderStyle.None;
            lb_zip_title.Text = "客官，拖个压缩包上来";
        }

        private void pl_img_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            pl_img.BorderStyle = BorderStyle.FixedSingle;
            lb_img_title.Text = "客官，可以放手了";
        }

        private void pl_img_DragLeave(object sender, EventArgs e)
        {
            pl_img.BorderStyle = BorderStyle.None;
            lb_img_title.Text = "客官，拖个图片上来";
        }

        private void pl_img_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            imgPath = paths[0];
            var fileInfo = new FileInfo(imgPath);
            if (paths.Length>1 || string.IsNullOrEmpty(fileInfo.Extension)|| (".jpg.png.gif").IndexOf(fileInfo.Extension.ToLower(), StringComparison.Ordinal)<0)
            {
                MessageBox.Show("请拖入一个图片文件(.jpg|.png|.gif)");
                pl_img.BorderStyle = BorderStyle.None;
                return;
            }
            
            lb_img_title.Text = fileInfo.Name;
            pb_img.ImageLocation = imgPath;
        }

        private void pl_zip_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            zipPath = paths[0];
            var fileInfo = new FileInfo(zipPath);
            if (paths.Length > 1 || string.IsNullOrEmpty(fileInfo.Extension) || (".zip.7z.rar").IndexOf(fileInfo.Extension.ToLower(), StringComparison.Ordinal) < 0)
            {
                MessageBox.Show("请拖入一个压缩文件(.zip|.7z|.rar)");
                pl_zip.BorderStyle = BorderStyle.None;
                return;
            }
            zipPath = paths[0];
            lb_zip_title.Text = fileInfo.Name;
            if (fileInfo.Extension.Equals(".zip",StringComparison.CurrentCultureIgnoreCase))
            {
                pb_zip.Image = Resources.zip;
            }
            else if (fileInfo.Extension.Equals(".7z", StringComparison.CurrentCultureIgnoreCase))
            {
                pb_zip.Image = Resources._7z;
            }
            else if (fileInfo.Extension.Equals(".rar", StringComparison.CurrentCultureIgnoreCase))
            {
                pb_zip.Image = Resources.rar;
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imgPath) || string.IsNullOrEmpty(zipPath))
            {
                MessageBox.Show("请先选择图片与压缩包");
                return;
            }
            if (!File.Exists(imgPath) || !File.Exists(zipPath))
            {
                MessageBox.Show("文件未找到，请重新选择");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "静态图|*.jpg|动态图|*.gif";
            var dialogResult = sfd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var cmd = string.Format("copy {0}/b+{1}/b {2}", imgPath, zipPath, sfd.FileName);
                CMDRun(cmd);
            }
        }

        private static void CMDRun(string cmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(cmd);
        }


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

        private void suuperDrag(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    continue;
                }

                control.MouseDown += (sender, args) =>
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                };

                suuperDrag(control.Controls);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
