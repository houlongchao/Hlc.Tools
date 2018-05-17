namespace 图片压缩包合并
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gb_img = new System.Windows.Forms.GroupBox();
            this.pl_img = new System.Windows.Forms.Panel();
            this.lb_img_title = new System.Windows.Forms.Label();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.lb_img = new System.Windows.Forms.Label();
            this.gb_zip = new System.Windows.Forms.GroupBox();
            this.pl_zip = new System.Windows.Forms.Panel();
            this.lb_zip_title = new System.Windows.Forms.Label();
            this.pb_zip = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_img.SuspendLayout();
            this.pl_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.gb_zip.SuspendLayout();
            this.pl_zip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_zip)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_img
            // 
            this.gb_img.Controls.Add(this.pl_img);
            this.gb_img.Location = new System.Drawing.Point(1, 3);
            this.gb_img.Name = "gb_img";
            this.gb_img.Size = new System.Drawing.Size(202, 311);
            this.gb_img.TabIndex = 0;
            this.gb_img.TabStop = false;
            this.gb_img.Text = "图片";
            // 
            // pl_img
            // 
            this.pl_img.AllowDrop = true;
            this.pl_img.Controls.Add(this.lb_img_title);
            this.pl_img.Controls.Add(this.pb_img);
            this.pl_img.Controls.Add(this.lb_img);
            this.pl_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_img.Location = new System.Drawing.Point(3, 17);
            this.pl_img.Name = "pl_img";
            this.pl_img.Size = new System.Drawing.Size(196, 291);
            this.pl_img.TabIndex = 0;
            this.pl_img.DragDrop += new System.Windows.Forms.DragEventHandler(this.pl_img_DragDrop);
            this.pl_img.DragEnter += new System.Windows.Forms.DragEventHandler(this.pl_img_DragEnter);
            this.pl_img.DragLeave += new System.EventHandler(this.pl_img_DragLeave);
            // 
            // lb_img_title
            // 
            this.lb_img_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_img_title.AutoSize = true;
            this.lb_img_title.Location = new System.Drawing.Point(8, 14);
            this.lb_img_title.Name = "lb_img_title";
            this.lb_img_title.Size = new System.Drawing.Size(65, 12);
            this.lb_img_title.TabIndex = 3;
            this.lb_img_title.Text = "请拖入图片";
            // 
            // pb_img
            // 
            this.pb_img.Location = new System.Drawing.Point(23, 49);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(148, 210);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img.TabIndex = 2;
            this.pb_img.TabStop = false;
            // 
            // lb_img
            // 
            this.lb_img.AutoSize = true;
            this.lb_img.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_img.Location = new System.Drawing.Point(43, 127);
            this.lb_img.Name = "lb_img";
            this.lb_img.Size = new System.Drawing.Size(115, 21);
            this.lb_img.TabIndex = 1;
            this.lb_img.Text = "请拖入图片";
            // 
            // gb_zip
            // 
            this.gb_zip.Controls.Add(this.pl_zip);
            this.gb_zip.Location = new System.Drawing.Point(209, 3);
            this.gb_zip.Name = "gb_zip";
            this.gb_zip.Size = new System.Drawing.Size(217, 311);
            this.gb_zip.TabIndex = 1;
            this.gb_zip.TabStop = false;
            this.gb_zip.Text = "压缩包";
            // 
            // pl_zip
            // 
            this.pl_zip.AllowDrop = true;
            this.pl_zip.Controls.Add(this.lb_zip_title);
            this.pl_zip.Controls.Add(this.pb_zip);
            this.pl_zip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_zip.Location = new System.Drawing.Point(3, 17);
            this.pl_zip.Name = "pl_zip";
            this.pl_zip.Size = new System.Drawing.Size(211, 291);
            this.pl_zip.TabIndex = 0;
            this.pl_zip.DragDrop += new System.Windows.Forms.DragEventHandler(this.pl_zip_DragDrop);
            this.pl_zip.DragEnter += new System.Windows.Forms.DragEventHandler(this.pl_zip_DragEnter);
            this.pl_zip.DragLeave += new System.EventHandler(this.pl_zip_DragLeave);
            // 
            // lb_zip_title
            // 
            this.lb_zip_title.AutoSize = true;
            this.lb_zip_title.Location = new System.Drawing.Point(13, 14);
            this.lb_zip_title.Name = "lb_zip_title";
            this.lb_zip_title.Size = new System.Drawing.Size(77, 12);
            this.lb_zip_title.TabIndex = 2;
            this.lb_zip_title.Text = "请拖入压缩包";
            // 
            // pb_zip
            // 
            this.pb_zip.Location = new System.Drawing.Point(50, 90);
            this.pb_zip.Name = "pb_zip";
            this.pb_zip.Size = new System.Drawing.Size(109, 134);
            this.pb_zip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_zip.TabIndex = 2;
            this.pb_zip.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(444, 49);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(53, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "合并";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(432, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 213);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "压缩包:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 73);
            this.label6.TabIndex = 0;
            this.label6.Text = "合并后显示合并前的图片，若想得到压缩包，将文件后缀修改为相应压缩包后缀即可。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 145);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = " zip|7z|rar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "jpg|png|gif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图片:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "说明";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(443, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zip into Pic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(30, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 10);
            this.label8.TabIndex = 0;
            this.label8.Text = "By:Hou Longchao";
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(501, 49);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(53, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb_zip);
            this.Controls.Add(this.gb_img);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.Text = "压缩包隐藏进图片 | By:侯龙超";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_img.ResumeLayout(false);
            this.pl_img.ResumeLayout(false);
            this.pl_img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.gb_zip.ResumeLayout(false);
            this.pl_zip.ResumeLayout(false);
            this.pl_zip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_zip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_img;
        private System.Windows.Forms.GroupBox gb_zip;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_img;
        private System.Windows.Forms.Panel pl_zip;
        private System.Windows.Forms.Label lb_img;
        private System.Windows.Forms.Label lb_img_title;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Label lb_zip_title;
        private System.Windows.Forms.PictureBox pb_zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_close;
    }
}

