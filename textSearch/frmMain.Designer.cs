namespace textSearch
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnFind = new System.Windows.Forms.Button();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.txttext = new System.Windows.Forms.TextBox();
            this.btnMatchCase = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.pnlDesc = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlOpenCloseSettings = new System.Windows.Forms.Panel();
            this.lblChangeSettingsState = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.chkFormat = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPathsTool = new System.Windows.Forms.Panel();
            this.btnInvertPath = new System.Windows.Forms.Button();
            this.btnPathPlus = new System.Windows.Forms.Button();
            this.btnPathMinus = new System.Windows.Forms.Button();
            this.chkPath = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormatsTool = new System.Windows.Forms.Panel();
            this.btnInvertFormat = new System.Windows.Forms.Button();
            this.btnFormatPlus = new System.Windows.Forms.Button();
            this.btnFormatMinus = new System.Windows.Forms.Button();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblChangeLogsState = new System.Windows.Forms.Label();
            this.pnlTool.SuspendLayout();
            this.pnlDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlOpenCloseSettings.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlPathsTool.SuspendLayout();
            this.pnlFormatsTool.SuspendLayout();
            this.pnlLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFind.Location = new System.Drawing.Point(326, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(141, 20);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.txttext);
            this.pnlTool.Controls.Add(this.btnMatchCase);
            this.pnlTool.Controls.Add(this.btnFind);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(467, 20);
            this.pnlTool.TabIndex = 0;
            // 
            // txttext
            // 
            this.txttext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttext.Location = new System.Drawing.Point(0, 0);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(251, 20);
            this.txttext.TabIndex = 0;
            // 
            // btnMatchCase
            // 
            this.btnMatchCase.BackColor = System.Drawing.Color.Red;
            this.btnMatchCase.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMatchCase.FlatAppearance.BorderSize = 0;
            this.btnMatchCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMatchCase.Location = new System.Drawing.Point(251, 0);
            this.btnMatchCase.Name = "btnMatchCase";
            this.btnMatchCase.Size = new System.Drawing.Size(75, 20);
            this.btnMatchCase.TabIndex = 1;
            this.btnMatchCase.Text = "Match Case";
            this.btnMatchCase.UseVisualStyleBackColor = false;
            this.btnMatchCase.Click += new System.EventHandler(this.btnMatchCase_Click);
            // 
            // lstItems
            // 
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(0, 20);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(467, 169);
            this.lstItems.TabIndex = 1;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.DoubleClick += new System.EventHandler(this.lstItems_DoubleClick);
            this.lstItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstItems_KeyDown);
            // 
            // pnlDesc
            // 
            this.pnlDesc.Controls.Add(this.txtDesc);
            this.pnlDesc.Controls.Add(this.btnOpenFolder);
            this.pnlDesc.Controls.Add(this.picIcon);
            this.pnlDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesc.Location = new System.Drawing.Point(0, 189);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(467, 144);
            this.pnlDesc.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(144, 0);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(323, 121);
            this.txtDesc.TabIndex = 1;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenFolder.Location = new System.Drawing.Point(144, 121);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(323, 23);
            this.btnOpenFolder.TabIndex = 0;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIcon.Location = new System.Drawing.Point(0, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(144, 144);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 437);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(800, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "0 items founded.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOpenCloseSettings
            // 
            this.pnlOpenCloseSettings.Controls.Add(this.lblChangeSettingsState);
            this.pnlOpenCloseSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpenCloseSettings.Location = new System.Drawing.Point(467, 0);
            this.pnlOpenCloseSettings.Name = "pnlOpenCloseSettings";
            this.pnlOpenCloseSettings.Size = new System.Drawing.Size(10, 333);
            this.pnlOpenCloseSettings.TabIndex = 5;
            // 
            // lblChangeSettingsState
            // 
            this.lblChangeSettingsState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangeSettingsState.Location = new System.Drawing.Point(0, 0);
            this.lblChangeSettingsState.Name = "lblChangeSettingsState";
            this.lblChangeSettingsState.Size = new System.Drawing.Size(10, 333);
            this.lblChangeSettingsState.TabIndex = 0;
            this.lblChangeSettingsState.Text = "<";
            this.lblChangeSettingsState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChangeSettingsState.Click += new System.EventHandler(this.lblChangeSettingsState_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.chkFormat);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.pnlPathsTool);
            this.pnlSettings.Controls.Add(this.chkPath);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.pnlFormatsTool);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSettings.Location = new System.Drawing.Point(477, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(323, 333);
            this.pnlSettings.TabIndex = 2;
            this.pnlSettings.Visible = false;
            // 
            // chkFormat
            // 
            this.chkFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFormat.FormattingEnabled = true;
            this.chkFormat.Location = new System.Drawing.Point(0, 233);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(319, 73);
            this.chkFormat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Formats";
            // 
            // pnlPathsTool
            // 
            this.pnlPathsTool.Controls.Add(this.btnInvertPath);
            this.pnlPathsTool.Controls.Add(this.btnPathPlus);
            this.pnlPathsTool.Controls.Add(this.btnPathMinus);
            this.pnlPathsTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPathsTool.Location = new System.Drawing.Point(0, 197);
            this.pnlPathsTool.Name = "pnlPathsTool";
            this.pnlPathsTool.Size = new System.Drawing.Size(319, 23);
            this.pnlPathsTool.TabIndex = 7;
            // 
            // btnInvertPath
            // 
            this.btnInvertPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvertPath.Location = new System.Drawing.Point(46, 0);
            this.btnInvertPath.Name = "btnInvertPath";
            this.btnInvertPath.Size = new System.Drawing.Size(273, 23);
            this.btnInvertPath.TabIndex = 2;
            this.btnInvertPath.Text = "Invert selection";
            this.btnInvertPath.UseVisualStyleBackColor = true;
            this.btnInvertPath.Click += new System.EventHandler(this.btnInvertPath_Click);
            // 
            // btnPathPlus
            // 
            this.btnPathPlus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPathPlus.Location = new System.Drawing.Point(23, 0);
            this.btnPathPlus.Name = "btnPathPlus";
            this.btnPathPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPathPlus.TabIndex = 3;
            this.btnPathPlus.Text = "+";
            this.btnPathPlus.UseVisualStyleBackColor = true;
            this.btnPathPlus.Click += new System.EventHandler(this.btnPathPlus_Click);
            // 
            // btnPathMinus
            // 
            this.btnPathMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPathMinus.Location = new System.Drawing.Point(0, 0);
            this.btnPathMinus.Name = "btnPathMinus";
            this.btnPathMinus.Size = new System.Drawing.Size(23, 23);
            this.btnPathMinus.TabIndex = 4;
            this.btnPathMinus.Text = "-";
            this.btnPathMinus.UseVisualStyleBackColor = true;
            this.btnPathMinus.Click += new System.EventHandler(this.btnPathMinus_Click);
            // 
            // chkPath
            // 
            this.chkPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkPath.FormattingEnabled = true;
            this.chkPath.Location = new System.Drawing.Point(0, 13);
            this.chkPath.Name = "chkPath";
            this.chkPath.Size = new System.Drawing.Size(319, 184);
            this.chkPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paths";
            // 
            // pnlFormatsTool
            // 
            this.pnlFormatsTool.Controls.Add(this.btnInvertFormat);
            this.pnlFormatsTool.Controls.Add(this.btnFormatPlus);
            this.pnlFormatsTool.Controls.Add(this.btnFormatMinus);
            this.pnlFormatsTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormatsTool.Location = new System.Drawing.Point(0, 306);
            this.pnlFormatsTool.Name = "pnlFormatsTool";
            this.pnlFormatsTool.Size = new System.Drawing.Size(319, 23);
            this.pnlFormatsTool.TabIndex = 6;
            // 
            // btnInvertFormat
            // 
            this.btnInvertFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvertFormat.Location = new System.Drawing.Point(46, 0);
            this.btnInvertFormat.Name = "btnInvertFormat";
            this.btnInvertFormat.Size = new System.Drawing.Size(273, 23);
            this.btnInvertFormat.TabIndex = 3;
            this.btnInvertFormat.Text = "Invert selection";
            this.btnInvertFormat.UseVisualStyleBackColor = true;
            this.btnInvertFormat.Click += new System.EventHandler(this.btnInvertFormat_Click);
            // 
            // btnFormatPlus
            // 
            this.btnFormatPlus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFormatPlus.Location = new System.Drawing.Point(23, 0);
            this.btnFormatPlus.Name = "btnFormatPlus";
            this.btnFormatPlus.Size = new System.Drawing.Size(23, 23);
            this.btnFormatPlus.TabIndex = 5;
            this.btnFormatPlus.Text = "+";
            this.btnFormatPlus.UseVisualStyleBackColor = true;
            this.btnFormatPlus.Click += new System.EventHandler(this.btnFormatPlus_Click);
            // 
            // btnFormatMinus
            // 
            this.btnFormatMinus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFormatMinus.Location = new System.Drawing.Point(0, 0);
            this.btnFormatMinus.Name = "btnFormatMinus";
            this.btnFormatMinus.Size = new System.Drawing.Size(23, 23);
            this.btnFormatMinus.TabIndex = 6;
            this.btnFormatMinus.Text = "-";
            this.btnFormatMinus.UseVisualStyleBackColor = true;
            this.btnFormatMinus.Click += new System.EventHandler(this.btnFormatMinus_Click);
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.Color.Black;
            this.pnlLog.Controls.Add(this.lstLog);
            this.pnlLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLog.Location = new System.Drawing.Point(0, 343);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(800, 94);
            this.pnlLog.TabIndex = 2;
            this.pnlLog.Visible = false;
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.Black;
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(0, 0);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(800, 94);
            this.lstLog.TabIndex = 2;
            this.lstLog.DoubleClick += new System.EventHandler(this.lstLog_DoubleClick);
            // 
            // lblChangeLogsState
            // 
            this.lblChangeLogsState.BackColor = System.Drawing.Color.Black;
            this.lblChangeLogsState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChangeLogsState.ForeColor = System.Drawing.Color.White;
            this.lblChangeLogsState.Location = new System.Drawing.Point(0, 333);
            this.lblChangeLogsState.Name = "lblChangeLogsState";
            this.lblChangeLogsState.Size = new System.Drawing.Size(800, 10);
            this.lblChangeLogsState.TabIndex = 6;
            this.lblChangeLogsState.Text = "^";
            this.lblChangeLogsState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChangeLogsState.Click += new System.EventHandler(this.lblChangeLogsState_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.pnlDesc);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.pnlOpenCloseSettings);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.lblChangeLogsState);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "TEXT finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.pnlDesc.ResumeLayout(false);
            this.pnlDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlOpenCloseSettings.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlPathsTool.ResumeLayout(false);
            this.pnlFormatsTool.ResumeLayout(false);
            this.pnlLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.TextBox txttext;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Panel pnlDesc;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnMatchCase;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlOpenCloseSettings;
        private System.Windows.Forms.Label lblChangeSettingsState;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.CheckedListBox chkPath;
        private System.Windows.Forms.CheckedListBox chkFormat;
        private System.Windows.Forms.Button btnInvertPath;
        private System.Windows.Forms.Button btnInvertFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFormatsTool;
        private System.Windows.Forms.Panel pnlPathsTool;
        private System.Windows.Forms.Button btnPathPlus;
        private System.Windows.Forms.Button btnFormatPlus;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Label lblChangeLogsState;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnPathMinus;
        private System.Windows.Forms.Button btnFormatMinus;
    }
}

