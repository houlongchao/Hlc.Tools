using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AnyExeToServer
{
    public partial class Form_Main : Form
    {
        private readonly string m_srvany = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "srvany.exe");
        private readonly string m_instsrv = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs", "instsrv.exe");

        private const string SERVICE_PREFIX = "srvany_";

        public Form_Main()
        {
            InitializeComponent();
        }

        #region Event Handler

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Text = $"AnyExeToService {ProductVersion} | By: Hou Longchao";
            RefreshServiceCmb();
            RefreshStartStopBtn();
        }

        private void btn_selectExe_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "exe|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileNames.Length <= 0)
                {
                    return;
                }

                txt_exePath.Text = dialog.FileNames[0];
            }

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var exePath = txt_exePath.Text;

            if (!File.Exists(exePath))
            {
                MessageBox.Show("EXE Path not found!");
                return;
            }

            var serviceName = txt_serviceName.Text.Trim();
            if (string.IsNullOrEmpty(serviceName))
            {
                MessageBox.Show("Please set Server Name.");
                return;
            }
            var newSrvanyExe = Path.Combine(Path.GetDirectoryName(exePath), Path.GetFileName(m_srvany));

            if (!File.Exists(newSrvanyExe))
            {
                File.Copy(m_srvany, newSrvanyExe);
            }

            ProcessRun(m_instsrv, string.Format("{0} {1}", GetServiceFullName(serviceName), newSrvanyExe));

            var serviceParams = Registry.LocalMachine.CreateSubKey(string.Format(@"SYSTEM\CurrentControlSet\Services\{0}\Parameters", GetServiceFullName(serviceName)), RegistryKeyPermissionCheck.ReadWriteSubTree);
            serviceParams.SetValue("Application", exePath);
            serviceParams.SetValue("AppDirectory", Path.GetDirectoryName(exePath));
            serviceParams.SetValue("AppParameters", txt_exeParms.Text);

            if (!IsServiceExisted(GetServiceFullName(serviceName)))
            {
                MessageBox.Show("Create Service Error.");
                return;
            }

            RefreshServiceCmb();
            MessageBox.Show("SUCCESS!");

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (null == cmb_services.SelectedItem)
            {
                MessageBox.Show("Please Select Service.");
                return;
            }

            var serviceName = cmb_services.SelectedItem.ToString().Trim();

            if (MessageBox.Show("Remove Service \""+serviceName+"\"?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            ProcessRun(m_instsrv, string.Format("{0} {1}", GetServiceFullName(serviceName), "remove"));
            if (IsServiceExisted(GetServiceFullName(serviceName)))
            {
                MessageBox.Show("ERROR");
                return;
            }
            RefreshServiceCmb();
            RefreshStartStopBtn();
            MessageBox.Show("SUCCESS");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (null == cmb_services.SelectedItem)
            {
                MessageBox.Show("Please Select Service.");
                return;
            }
            var serviceName = cmb_services.SelectedItem.ToString().Trim();
            if (!StartService(GetServiceFullName(serviceName)))
            {
                MessageBox.Show("Start Service Error.");
                return;
            }
            RefreshStartStopBtn();
            MessageBox.Show("SUCCESS!");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (null == cmb_services.SelectedItem)
            {
                MessageBox.Show("Please Select Service.");
                return;
            }
            var serviceName = cmb_services.SelectedItem.ToString().Trim();
            if (!StopService(GetServiceFullName(serviceName)))
            {
                MessageBox.Show("Start Service Error.");
                return;
            }
            RefreshStartStopBtn();
            MessageBox.Show("SUCCESS!");
        }

        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStartStopBtn();
        }

        #endregion

        #region Private Method

        private bool IsServiceExisted(string serviceName)
        {

            foreach (var service in ServiceController.GetServices())
            {
                if (service.ServiceName.Equals(serviceName, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private bool StartService(string serviceName)
        {
            var service = new ServiceController(serviceName);
            if (service.Status != ServiceControllerStatus.Running && service.Status != ServiceControllerStatus.StartPending)
            {
                service.Start();
                try
                {
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                }
                catch (Exception)
                {

                }
            }

            if (service.Status == ServiceControllerStatus.Running)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool StopService(string serviceName)
        {
            var service = new ServiceController(serviceName);
            if (service.Status != ServiceControllerStatus.Stopped && service.Status != ServiceControllerStatus.StopPending)
            {
                service.Stop();
                try
                {
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
                }
                catch (Exception)
                {

                }
            }

            if (service.Status == ServiceControllerStatus.Stopped)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ProcessRun(string exePath, string args)
        {
            var process = new Process();
            process.StartInfo.FileName = exePath;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
            return process.ExitCode == 0;
        }

        private void RefreshServiceCmb()
        {
            List<string> serviceList = new List<string>();
            foreach (var service in ServiceController.GetServices())
            {
                if (service.ServiceName.StartsWith(SERVICE_PREFIX))
                {
                    serviceList.Add(service.ServiceName.Substring(SERVICE_PREFIX.Length));
                }
            }
            cmb_services.Items.Clear();
            cmb_services.Items.AddRange(serviceList.ToArray());
        }

        private string GetServiceFullName(string serviceName)
        {
            if (serviceName.StartsWith(SERVICE_PREFIX))
            {
                return serviceName;
            }
            return SERVICE_PREFIX + serviceName;
        }

        private void RefreshStartStopBtn()
        {
            btn_start.Enabled = false;
            btn_stop.Enabled = false;

            if (null == cmb_services.SelectedItem)
            {
                return;
            }

            foreach (var service in ServiceController.GetServices())
            {
                if (service.ServiceName.Equals(GetServiceFullName(cmb_services.SelectedItem.ToString().Trim())))
                {
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        btn_stop.Enabled = true;
                    }
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        btn_start.Enabled = true;
                    }
                    return;
                }
            }
        }


        #endregion
    }
}
