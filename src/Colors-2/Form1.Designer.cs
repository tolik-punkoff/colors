namespace Colors_2
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
            this.grdColors = new System.Windows.Forms.DataGridView();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainColors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystemColors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRGB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColorDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFontReset = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdColors)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdColors
            // 
            this.grdColors.AllowUserToAddRows = false;
            this.grdColors.AllowUserToDeleteRows = false;
            this.grdColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdColors.Location = new System.Drawing.Point(0, 24);
            this.grdColors.Name = "grdColors";
            this.grdColors.ReadOnly = true;
            this.grdColors.Size = new System.Drawing.Size(558, 250);
            this.grdColors.TabIndex = 0;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMain});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(558, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainMain
            // 
            this.mnuMainMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainColors,
            this.mnuSystemColors,
            this.mnuRGB,
            this.mnuColorDialog,
            this.toolStripSeparator1,
            this.mnuFont,
            this.mnuFontReset});
            this.mnuMainMain.Name = "mnuMainMain";
            this.mnuMainMain.Size = new System.Drawing.Size(41, 20);
            this.mnuMainMain.Text = "Main";
            // 
            // mnuMainColors
            // 
            this.mnuMainColors.Name = "mnuMainColors";
            this.mnuMainColors.Size = new System.Drawing.Size(152, 22);
            this.mnuMainColors.Text = "Main colors";
            this.mnuMainColors.Click += new System.EventHandler(this.mnuMainColors_Click);
            // 
            // mnuSystemColors
            // 
            this.mnuSystemColors.Name = "mnuSystemColors";
            this.mnuSystemColors.Size = new System.Drawing.Size(152, 22);
            this.mnuSystemColors.Text = "System colors";
            this.mnuSystemColors.Click += new System.EventHandler(this.mnuSystemColors_Click);
            // 
            // mnuRGB
            // 
            this.mnuRGB.Name = "mnuRGB";
            this.mnuRGB.Size = new System.Drawing.Size(152, 22);
            this.mnuRGB.Text = "RGB";
            this.mnuRGB.Click += new System.EventHandler(this.mnuRGB_Click);
            // 
            // mnuColorDialog
            // 
            this.mnuColorDialog.Name = "mnuColorDialog";
            this.mnuColorDialog.Size = new System.Drawing.Size(152, 22);
            this.mnuColorDialog.Text = "Color dialog";
            this.mnuColorDialog.Click += new System.EventHandler(this.mnuColorDialog_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(152, 22);
            this.mnuFont.Text = "Font";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuFontReset
            // 
            this.mnuFontReset.Name = "mnuFontReset";
            this.mnuFontReset.Size = new System.Drawing.Size(152, 22);
            this.mnuFontReset.Text = "Font reset";
            this.mnuFontReset.Click += new System.EventHandler(this.mnuFontReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 274);
            this.Controls.Add(this.grdColors);
            this.Controls.Add(this.mnuMain);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colors";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdColors)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdColors;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainColors;
        private System.Windows.Forms.ToolStripMenuItem mnuSystemColors;
        private System.Windows.Forms.ToolStripMenuItem mnuRGB;
        private System.Windows.Forms.ToolStripMenuItem mnuColorDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuFontReset;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}

