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
            this.btnInvertPath = new System.Windows.Forms.Button();
            this.chkPath = new System.Windows.Forms.CheckedListBox();
            this.btnInvertFormat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFormatsTool = new System.Windows.Forms.Panel();
            this.pnlPathsTool = new System.Windows.Forms.Panel();
            this.btnPathPlus = new System.Windows.Forms.Button();
            this.btnFormatPlus = new System.Windows.Forms.Button();
            this.pnlTool.SuspendLayout();
            this.pnlDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlOpenCloseSettings.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlFormatsTool.SuspendLayout();
            this.pnlPathsTool.SuspendLayout();
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
            this.lstItems.Size = new System.Drawing.Size(467, 273);
            this.lstItems.TabIndex = 1;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.DoubleClick += new System.EventHandler(this.lstItems_DoubleClick);
            // 
            // pnlDesc
            // 
            this.pnlDesc.Controls.Add(this.txtDesc);
            this.pnlDesc.Controls.Add(this.btnOpenFolder);
            this.pnlDesc.Controls.Add(this.picIcon);
            this.pnlDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesc.Location = new System.Drawing.Point(0, 293);
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
            this.lblStatus.Size = new System.Drawing.Size(467, 13);
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
            this.pnlOpenCloseSettings.Size = new System.Drawing.Size(10, 450);
            this.pnlOpenCloseSettings.TabIndex = 5;
            // 
            // lblChangeSettingsState
            // 
            this.lblChangeSettingsState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangeSettingsState.Location = new System.Drawing.Point(0, 0);
            this.lblChangeSettingsState.Name = "lblChangeSettingsState";
            this.lblChangeSettingsState.Size = new System.Drawing.Size(10, 450);
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
            this.pnlSettings.Size = new System.Drawing.Size(323, 450);
            this.pnlSettings.TabIndex = 2;
            this.pnlSettings.Visible = false;
            // 
            // chkFormat
            // 
            this.chkFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFormat.FormattingEnabled = true;
            this.chkFormat.Location = new System.Drawing.Point(0, 233);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(319, 190);
            this.chkFormat.TabIndex = 1;
            // 
            // btnInvertPath
            // 
            this.btnInvertPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvertPath.Location = new System.Drawing.Point(23, 0);
            this.btnInvertPath.Name = "btnInvertPath";
            this.btnInvertPath.Size = new System.Drawing.Size(296, 23);
            this.btnInvertPath.TabIndex = 2;
            this.btnInvertPath.Text = "Invert selection";
            this.btnInvertPath.UseVisualStyleBackColor = true;
            this.btnInvertPath.Click += new System.EventHandler(this.btnInvertPath_Click);
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
            // btnInvertFormat
            // 
            this.btnInvertFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvertFormat.Location = new System.Drawing.Point(23, 0);
            this.btnInvertFormat.Name = "btnInvertFormat";
            this.btnInvertFormat.Size = new System.Drawing.Size(296, 23);
            this.btnInvertFormat.TabIndex = 3;
            this.btnInvertFormat.Text = "Invert selection";
            this.btnInvertFormat.UseVisualStyleBackColor = true;
            this.btnInvertFormat.Click += new System.EventHandler(this.btnInvertFormat_Click);
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
            // pnlFormatsTool
            // 
            this.pnlFormatsTool.Controls.Add(this.btnInvertFormat);
            this.pnlFormatsTool.Controls.Add(this.btnFormatPlus);
            this.pnlFormatsTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormatsTool.Location = new System.Drawing.Point(0, 423);
            this.pnlFormatsTool.Name = "pnlFormatsTool";
            this.pnlFormatsTool.Size = new System.Drawing.Size(319, 23);
            this.pnlFormatsTool.TabIndex = 6;
            // 
            // pnlPathsTool
            // 
            this.pnlPathsTool.Controls.Add(this.btnInvertPath);
            this.pnlPathsTool.Controls.Add(this.btnPathPlus);
            this.pnlPathsTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPathsTool.Location = new System.Drawing.Point(0, 197);
            this.pnlPathsTool.Name = "pnlPathsTool";
            this.pnlPathsTool.Size = new System.Drawing.Size(319, 23);
            this.pnlPathsTool.TabIndex = 7;
            // 
            // btnPathPlus
            // 
            this.btnPathPlus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPathPlus.Location = new System.Drawing.Point(0, 0);
            this.btnPathPlus.Name = "btnPathPlus";
            this.btnPathPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPathPlus.TabIndex = 3;
            this.btnPathPlus.Text = "+";
            this.btnPathPlus.UseVisualStyleBackColor = true;
            // 
            // btnFormatPlus
            // 
            this.btnFormatPlus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFormatPlus.Location = new System.Drawing.Point(0, 0);
            this.btnFormatPlus.Name = "btnFormatPlus";
            this.btnFormatPlus.Size = new System.Drawing.Size(23, 23);
            this.btnFormatPlus.TabIndex = 5;
            this.btnFormatPlus.Text = "+";
            this.btnFormatPlus.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.pnlDesc);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlOpenCloseSettings);
            this.Controls.Add(this.pnlSettings);
            this.Name = "frmMain";
            this.Text = "TEXT finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.pnlDesc.ResumeLayout(false);
            this.pnlDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlOpenCloseSettings.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlFormatsTool.ResumeLayout(false);
            this.pnlPathsTool.ResumeLayout(false);
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
    }
}

