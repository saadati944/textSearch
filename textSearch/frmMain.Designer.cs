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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.pnlDesc = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnMatchCase = new System.Windows.Forms.Button();
            this.pnlTool.SuspendLayout();
            this.pnlDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFind.Location = new System.Drawing.Point(659, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(141, 20);
            this.btnFind.TabIndex = 0;
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
            this.pnlTool.Size = new System.Drawing.Size(800, 20);
            this.pnlTool.TabIndex = 1;
            // 
            // txttext
            // 
            this.txttext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttext.Location = new System.Drawing.Point(0, 0);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(584, 20);
            this.txttext.TabIndex = 1;
            // 
            // lstItems
            // 
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(0, 20);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(800, 286);
            this.lstItems.TabIndex = 2;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // pnlDesc
            // 
            this.pnlDesc.Controls.Add(this.txtDesc);
            this.pnlDesc.Controls.Add(this.picIcon);
            this.pnlDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesc.Location = new System.Drawing.Point(0, 306);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(800, 144);
            this.pnlDesc.TabIndex = 3;
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIcon.Location = new System.Drawing.Point(0, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(153, 144);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(153, 0);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(647, 144);
            this.txtDesc.TabIndex = 1;
            // 
            // btnMatchCase
            // 
            this.btnMatchCase.BackColor = System.Drawing.Color.Red;
            this.btnMatchCase.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMatchCase.FlatAppearance.BorderSize = 0;
            this.btnMatchCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMatchCase.Location = new System.Drawing.Point(584, 0);
            this.btnMatchCase.Name = "btnMatchCase";
            this.btnMatchCase.Size = new System.Drawing.Size(75, 20);
            this.btnMatchCase.TabIndex = 2;
            this.btnMatchCase.Text = "Match Case";
            this.btnMatchCase.UseVisualStyleBackColor = false;
            this.btnMatchCase.Click += new System.EventHandler(this.btnMatchCase_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.pnlDesc);
            this.Controls.Add(this.pnlTool);
            this.Name = "frmMain";
            this.Text = "TEXT finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.pnlDesc.ResumeLayout(false);
            this.pnlDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
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
    }
}

