namespace ClipboardWatcher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvClipboard = new System.Windows.Forms.DataGridView();
            this.clOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClipboard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvClipboard
            // 
            this.dgvClipboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClipboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOwner,
            this.clType,
            this.clContent});
            this.dgvClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClipboard.Location = new System.Drawing.Point(0, 24);
            this.dgvClipboard.Name = "dgvClipboard";
            this.dgvClipboard.Size = new System.Drawing.Size(800, 426);
            this.dgvClipboard.TabIndex = 1;
            // 
            // clOwner
            // 
            this.clOwner.HeaderText = "Owner PID";
            this.clOwner.Name = "clOwner";
            this.clOwner.ReadOnly = true;
            // 
            // clType
            // 
            this.clType.HeaderText = "Clipboard Type";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            // 
            // clContent
            // 
            this.clContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clContent.HeaderText = "Content";
            this.clContent.Name = "clContent";
            this.clContent.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClipboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "ClipboardWatcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClipboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvClipboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clContent;
    }
}

