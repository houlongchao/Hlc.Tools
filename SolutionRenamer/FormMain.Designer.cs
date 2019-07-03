namespace SolutionRenamer
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txt_solution = new System.Windows.Forms.TextBox();
            this.lb_solution = new System.Windows.Forms.Label();
            this.txt_oldNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newNamespace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fileExtension = new System.Windows.Forms.TextBox();
            this.gbx_setting = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.gbx_option = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_forceFiles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_setting.SuspendLayout();
            this.gbx_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_solution
            // 
            this.txt_solution.Location = new System.Drawing.Point(115, 26);
            this.txt_solution.Name = "txt_solution";
            this.txt_solution.Size = new System.Drawing.Size(292, 21);
            this.txt_solution.TabIndex = 1;
            this.txt_solution.DoubleClick += new System.EventHandler(this.Txt_solution_DoubleClick);
            // 
            // lb_solution
            // 
            this.lb_solution.AutoSize = true;
            this.lb_solution.Location = new System.Drawing.Point(20, 29);
            this.lb_solution.Name = "lb_solution";
            this.lb_solution.Size = new System.Drawing.Size(89, 12);
            this.lb_solution.TabIndex = 1;
            this.lb_solution.Text = "解决方案路径：";
            // 
            // txt_oldNamespace
            // 
            this.txt_oldNamespace.Location = new System.Drawing.Point(115, 63);
            this.txt_oldNamespace.Name = "txt_oldNamespace";
            this.txt_oldNamespace.Size = new System.Drawing.Size(292, 21);
            this.txt_oldNamespace.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原始命名空间：";
            // 
            // txt_newNamespace
            // 
            this.txt_newNamespace.Location = new System.Drawing.Point(115, 103);
            this.txt_newNamespace.Name = "txt_newNamespace";
            this.txt_newNamespace.Size = new System.Drawing.Size(292, 21);
            this.txt_newNamespace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新命名空间：";
            // 
            // txt_fileExtension
            // 
            this.txt_fileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_fileExtension.Location = new System.Drawing.Point(12, 52);
            this.txt_fileExtension.Multiline = true;
            this.txt_fileExtension.Name = "txt_fileExtension";
            this.txt_fileExtension.Size = new System.Drawing.Size(91, 322);
            this.txt_fileExtension.TabIndex = 0;
            this.txt_fileExtension.TabStop = false;
            this.txt_fileExtension.Text = ".cs\r\n.config\r\n.yml\r\n.md\r\n.xml\r\n.cshtml\r\n.js\r\n.csproj\r\n.sln\r\n.config\r\n.cmd\r\n.bat\r\n" +
    ".gitignore";
            // 
            // gbx_setting
            // 
            this.gbx_setting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbx_setting.Controls.Add(this.label4);
            this.gbx_setting.Controls.Add(this.txt_forceFiles);
            this.gbx_setting.Controls.Add(this.label3);
            this.gbx_setting.Controls.Add(this.txt_fileExtension);
            this.gbx_setting.Location = new System.Drawing.Point(12, 12);
            this.gbx_setting.Name = "gbx_setting";
            this.gbx_setting.Size = new System.Drawing.Size(217, 392);
            this.gbx_setting.TabIndex = 2;
            this.gbx_setting.TabStop = false;
            this.gbx_setting.Text = "设置";
            // 
            // txt_log
            // 
            this.txt_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_log.Location = new System.Drawing.Point(245, 225);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.Size = new System.Drawing.Size(427, 177);
            this.txt_log.TabIndex = 3;
            this.txt_log.TabStop = false;
            // 
            // gbx_option
            // 
            this.gbx_option.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_option.Controls.Add(this.progress);
            this.gbx_option.Controls.Add(this.btn_ok);
            this.gbx_option.Controls.Add(this.lb_solution);
            this.gbx_option.Controls.Add(this.txt_solution);
            this.gbx_option.Controls.Add(this.txt_oldNamespace);
            this.gbx_option.Controls.Add(this.label2);
            this.gbx_option.Controls.Add(this.txt_newNamespace);
            this.gbx_option.Controls.Add(this.label1);
            this.gbx_option.Location = new System.Drawing.Point(245, 12);
            this.gbx_option.Name = "gbx_option";
            this.gbx_option.Size = new System.Drawing.Size(427, 198);
            this.gbx_option.TabIndex = 4;
            this.gbx_option.TabStop = false;
            this.gbx_option.Text = "操作";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(22, 160);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(288, 23);
            this.progress.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(332, 160);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "执行";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "包含文件扩展";
            // 
            // txt_forceFiles
            // 
            this.txt_forceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_forceFiles.Location = new System.Drawing.Point(109, 53);
            this.txt_forceFiles.Multiline = true;
            this.txt_forceFiles.Name = "txt_forceFiles";
            this.txt_forceFiles.Size = new System.Drawing.Size(99, 322);
            this.txt_forceFiles.TabIndex = 0;
            this.txt_forceFiles.TabStop = false;
            this.txt_forceFiles.Text = "Dockerfile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "强制包含文件";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.gbx_option);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.gbx_setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormMain";
            this.Text = "解决方案重命名器 | By: Hou Longchao";
            this.gbx_setting.ResumeLayout(false);
            this.gbx_setting.PerformLayout();
            this.gbx_option.ResumeLayout(false);
            this.gbx_option.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_solution;
        private System.Windows.Forms.Label lb_solution;
        private System.Windows.Forms.TextBox txt_oldNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newNamespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fileExtension;
        private System.Windows.Forms.GroupBox gbx_setting;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.GroupBox gbx_option;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_forceFiles;
    }
}

