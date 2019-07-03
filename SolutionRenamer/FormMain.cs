using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SolutionRenamer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {

            var extensions = txt_fileExtension.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var forceFiles = txt_forceFiles.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (!Directory.Exists(txt_solution.Text))
            {
                MessageBox.Show("解决方案不存在");
                return;
            }

            Log($"开始重命名。");
            EnableForm(false);
            EnableProgress(true);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            RenameSolution(txt_solution.Text, txt_oldNamespace.Text, txt_newNamespace.Text, extensions, forceFiles);
            stopwatch.Stop();
            EnableForm(true);
            EnableProgress(false);
            Log($"重命名完成，用时{stopwatch.ElapsedMilliseconds}毫秒。");
            Log(Environment.NewLine);
        }

        private void EnableForm(bool enable)
        {
            gbx_setting.Enabled = enable;
            gbx_option.Enabled = enable;
        }

        private void EnableProgress(bool enable)
        {
            if (enable)
            {
                progress.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                progress.Style = ProgressBarStyle.Blocks;
            }
        }

        private void Txt_solution_DoubleClick(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.Description = "请选择解决方案";
            var dialogResult = fbd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                txt_solution.Text = fbd.SelectedPath;
            }
        }

        private void RenameSolution(string solutionPath, string oldNamespace, string newNamespace, string[] fileExtensions, string[] forceFiles)
        {
            ReplaceDirectoryContent(solutionPath, oldNamespace, newNamespace, fileExtensions, forceFiles);
            ReplaceDirectoryFileName(new DirectoryInfo(solutionPath), oldNamespace, newNamespace);
        }

        private void ReplaceDirectoryFileName(DirectoryInfo dirInfo, string oldNamespace, string newNamespace)
        {
            var directories = dirInfo.GetDirectories();
            foreach (var directory in directories)
            {
                ReplaceDirectoryFileName(directory, oldNamespace, newNamespace);
            }

            var files = dirInfo.GetFiles();
            foreach (var file in files)
            {
                var newName = file.Name.Replace(oldNamespace, newNamespace);
                var newPath = Path.Combine(file.DirectoryName, newName);
                if (!file.FullName.Equals(newPath))
                {
                    File.Move(file.FullName, newPath);
                    Log($"修改文件名：{file.Name}");
                }
            }

            var newDirName = dirInfo.Name.Replace(oldNamespace, newNamespace);
            var newDir = Path.Combine(dirInfo.Parent.FullName, newDirName);
            if (!dirInfo.FullName.Equals(newDir))
            {
                Directory.Move(dirInfo.FullName, newDir);
                Log($"修改文件夹：{dirInfo.Name}");
            }
        }

        private void ReplaceDirectoryContent(string directory, string oldNamespace, string newNamespace, string[] fileExtensions = null, string[] forceFiles = null)
        {
            var directoryInfo = new DirectoryInfo(directory);
            var files = directoryInfo.GetFiles();
            foreach (var file in files)
            {
                if (forceFiles != null && forceFiles.Contains(file.Name))
                {
                    ReplaceFileContent(file.FullName, oldNamespace, newNamespace);
                }
                else if (fileExtensions == null || fileExtensions.Length <= 0)
                {
                    ReplaceFileContent(file.FullName, oldNamespace, newNamespace);
                }
                else if (fileExtensions.Contains(file.Extension))
                {
                    ReplaceFileContent(file.FullName, oldNamespace, newNamespace);
                }
            }

            var directories = directoryInfo.GetDirectories();
            foreach (var dir in directories)
            {
                ReplaceDirectoryContent(dir.FullName, oldNamespace, newNamespace, fileExtensions, forceFiles);
            }
        }

        private void ReplaceFileContent(string filePath, string oldNamespace, string newNamespace)
        {
            var text = File.ReadAllText(filePath);
            text = text.Replace(oldNamespace, newNamespace);
            File.WriteAllText(filePath, text);
            Log($"修改文件内容：{filePath}");
        }

        private void Log(string message)
        {
            txt_log.AppendText($"{message}{Environment.NewLine}");
        }
    }
}
