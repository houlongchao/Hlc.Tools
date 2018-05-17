namespace FillDisk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._sizeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._diskCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._runBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._freeSize = new System.Windows.Forms.Label();
            this._refreshBtn = new System.Windows.Forms.Button();
            this._modeCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._fillDataFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this._fillDataFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // _sizeTxt
            // 
            this._sizeTxt.Location = new System.Drawing.Point(53, 70);
            this._sizeTxt.Name = "_sizeTxt";
            this._sizeTxt.Size = new System.Drawing.Size(163, 21);
            this._sizeTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "大小：";
            // 
            // _diskCmb
            // 
            this._diskCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._diskCmb.FormattingEnabled = true;
            this._diskCmb.Location = new System.Drawing.Point(53, 9);
            this._diskCmb.Name = "_diskCmb";
            this._diskCmb.Size = new System.Drawing.Size(63, 20);
            this._diskCmb.TabIndex = 1;
            this._diskCmb.SelectedIndexChanged += new System.EventHandler(this._diskCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "磁盘：";
            // 
            // _runBtn
            // 
            this._runBtn.Location = new System.Drawing.Point(222, 41);
            this._runBtn.Name = "_runBtn";
            this._runBtn.Size = new System.Drawing.Size(61, 50);
            this._runBtn.TabIndex = 4;
            this._runBtn.Text = "开始";
            this._runBtn.UseVisualStyleBackColor = true;
            this._runBtn.Click += new System.EventHandler(this._runBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "空余：";
            // 
            // _freeSize
            // 
            this._freeSize.AutoSize = true;
            this._freeSize.Location = new System.Drawing.Point(167, 14);
            this._freeSize.Name = "_freeSize";
            this._freeSize.Size = new System.Drawing.Size(35, 12);
            this._freeSize.TabIndex = 4;
            this._freeSize.Text = "1024M";
            // 
            // _refreshBtn
            // 
            this._refreshBtn.Location = new System.Drawing.Point(222, 10);
            this._refreshBtn.Name = "_refreshBtn";
            this._refreshBtn.Size = new System.Drawing.Size(61, 21);
            this._refreshBtn.TabIndex = 3;
            this._refreshBtn.Text = "刷新";
            this._refreshBtn.UseVisualStyleBackColor = true;
            this._refreshBtn.Click += new System.EventHandler(this._refreshBtn_Click);
            // 
            // _modeCmb
            // 
            this._modeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._modeCmb.FormattingEnabled = true;
            this._modeCmb.Items.AddRange(new object[] {
            "占用",
            "剩余"});
            this._modeCmb.Location = new System.Drawing.Point(53, 41);
            this._modeCmb.Name = "_modeCmb";
            this._modeCmb.Size = new System.Drawing.Size(163, 20);
            this._modeCmb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "模式：";
            // 
            // _fillDataFiles
            // 
            this._fillDataFiles.AllowUserToAddRows = false;
            this._fillDataFiles.AllowUserToDeleteRows = false;
            this._fillDataFiles.AllowUserToResizeRows = false;
            this._fillDataFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fillDataFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._fillDataFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fillDataFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._fillDataFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileSize,
            this.Delete});
            this._fillDataFiles.Location = new System.Drawing.Point(-1, 97);
            this._fillDataFiles.MultiSelect = false;
            this._fillDataFiles.Name = "_fillDataFiles";
            this._fillDataFiles.ReadOnly = true;
            this._fillDataFiles.RowHeadersVisible = false;
            this._fillDataFiles.RowTemplate.Height = 18;
            this._fillDataFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._fillDataFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._fillDataFiles.Size = new System.Drawing.Size(292, 247);
            this._fillDataFiles.TabIndex = 6;
            this._fillDataFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._fillDataFiles_CellContentClick);
            this._fillDataFiles.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this._fillDataFiles_SortCompare);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.FillWeight = 155F;
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.ToolTipText = "填充文件名";
            // 
            // FileSize
            // 
            this.FileSize.FillWeight = 80F;
            this.FileSize.HeaderText = "大小";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            this.FileSize.ToolTipText = "填充文件大小";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "X";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FillWeight = 20F;
            this.Delete.HeaderText = "X";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "X";
            this.Delete.ToolTipText = "删除填充文件";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 344);
            this.Controls.Add(this._fillDataFiles);
            this.Controls.Add(this._freeSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._refreshBtn);
            this.Controls.Add(this._runBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._modeCmb);
            this.Controls.Add(this._diskCmb);
            this.Controls.Add(this._sizeTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "磁盘填充器 | BY:侯龙超";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this._fillDataFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _sizeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _diskCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _runBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _freeSize;
        private System.Windows.Forms.Button _refreshBtn;
        private System.Windows.Forms.ComboBox _modeCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView _fillDataFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

