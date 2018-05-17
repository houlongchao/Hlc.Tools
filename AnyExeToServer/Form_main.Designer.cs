namespace AnyExeToServer
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.txt_exePath = new System.Windows.Forms.TextBox();
            this.btn_selectExe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_serviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_services = new System.Windows.Forms.ComboBox();
            this.txt_exeParms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_exePath
            // 
            this.txt_exePath.Location = new System.Drawing.Point(109, 32);
            this.txt_exePath.Name = "txt_exePath";
            this.txt_exePath.Size = new System.Drawing.Size(208, 21);
            this.txt_exePath.TabIndex = 0;
            // 
            // btn_selectExe
            // 
            this.btn_selectExe.Location = new System.Drawing.Point(335, 30);
            this.btn_selectExe.Name = "btn_selectExe";
            this.btn_selectExe.Size = new System.Drawing.Size(107, 23);
            this.btn_selectExe.TabIndex = 1;
            this.btn_selectExe.Text = "Select";
            this.btn_selectExe.UseVisualStyleBackColor = true;
            this.btn_selectExe.Click += new System.EventHandler(this.btn_selectExe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "EXE Path:";
            // 
            // txt_serviceName
            // 
            this.txt_serviceName.Location = new System.Drawing.Point(109, 95);
            this.txt_serviceName.Name = "txt_serviceName";
            this.txt_serviceName.Size = new System.Drawing.Size(208, 21);
            this.txt_serviceName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service Name:";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(335, 93);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(107, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create Service";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_exeParms);
            this.groupBox1.Controls.Add(this.txt_exePath);
            this.groupBox1.Controls.Add(this.btn_selectExe);
            this.groupBox1.Controls.Add(this.txt_serviceName);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.btn_stop);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_services);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service Operation";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(335, 18);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(107, 23);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove Service";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(224, 51);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(122, 51);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Service:";
            // 
            // cmb_services
            // 
            this.cmb_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_services.FormattingEnabled = true;
            this.cmb_services.Location = new System.Drawing.Point(109, 20);
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(208, 20);
            this.cmb_services.TabIndex = 0;
            this.cmb_services.SelectedIndexChanged += new System.EventHandler(this.cmb_services_SelectedIndexChanged);
            // 
            // txt_exeParms
            // 
            this.txt_exeParms.Location = new System.Drawing.Point(109, 64);
            this.txt_exeParms.Name = "txt_exeParms";
            this.txt_exeParms.Size = new System.Drawing.Size(333, 21);
            this.txt_exeParms.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "EXE Parms:";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnyExeToService | By: Hou Longchao";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_exePath;
        private System.Windows.Forms.Button btn_selectExe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_serviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_services;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_exeParms;
    }
}

