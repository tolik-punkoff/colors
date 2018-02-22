namespace Colors_2
{
    partial class frmRGB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRGB));
            this.trackRF = new System.Windows.Forms.TrackBar();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblG1 = new System.Windows.Forms.Label();
            this.trackGF = new System.Windows.Forms.TrackBar();
            this.lblB1 = new System.Windows.Forms.Label();
            this.trackBF = new System.Windows.Forms.TrackBar();
            this.txtRF = new System.Windows.Forms.TextBox();
            this.txtGF = new System.Windows.Forms.TextBox();
            this.txtBF = new System.Windows.Forms.TextBox();
            this.groupFore = new System.Windows.Forms.GroupBox();
            this.lblDec1 = new System.Windows.Forms.Label();
            this.txtDecF = new System.Windows.Forms.TextBox();
            this.lblOct1 = new System.Windows.Forms.Label();
            this.txtOctF = new System.Windows.Forms.TextBox();
            this.lblHex1 = new System.Windows.Forms.Label();
            this.txtHexF = new System.Windows.Forms.TextBox();
            this.groupBack = new System.Windows.Forms.GroupBox();
            this.lblDec2 = new System.Windows.Forms.Label();
            this.txtDecB = new System.Windows.Forms.TextBox();
            this.lblOct2 = new System.Windows.Forms.Label();
            this.txtOctB = new System.Windows.Forms.TextBox();
            this.lblHex2 = new System.Windows.Forms.Label();
            this.txtHexB = new System.Windows.Forms.TextBox();
            this.trackBB = new System.Windows.Forms.TrackBar();
            this.txtBB = new System.Windows.Forms.TextBox();
            this.trackRB = new System.Windows.Forms.TrackBar();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.lblR2 = new System.Windows.Forms.Label();
            this.txtRB = new System.Windows.Forms.TextBox();
            this.trackGB = new System.Windows.Forms.TrackBar();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblG2 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnResetFont = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBF)).BeginInit();
            this.groupFore.SuspendLayout();
            this.groupBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGB)).BeginInit();
            this.SuspendLayout();
            // 
            // trackRF
            // 
            this.trackRF.AutoSize = false;
            this.trackRF.Location = new System.Drawing.Point(24, 18);
            this.trackRF.Maximum = 255;
            this.trackRF.Name = "trackRF";
            this.trackRF.Size = new System.Drawing.Size(512, 34);
            this.trackRF.TabIndex = 0;
            this.trackRF.Text = "label1";
            this.trackRF.Scroll += new System.EventHandler(this.Fore_Scroll);
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(4, 28);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(15, 13);
            this.lblR1.TabIndex = 1;
            this.lblR1.Text = "R";
            // 
            // lblG1
            // 
            this.lblG1.AutoSize = true;
            this.lblG1.Location = new System.Drawing.Point(4, 68);
            this.lblG1.Name = "lblG1";
            this.lblG1.Size = new System.Drawing.Size(15, 13);
            this.lblG1.TabIndex = 3;
            this.lblG1.Text = "G";
            // 
            // trackGF
            // 
            this.trackGF.AutoSize = false;
            this.trackGF.Location = new System.Drawing.Point(24, 58);
            this.trackGF.Maximum = 255;
            this.trackGF.Name = "trackGF";
            this.trackGF.Size = new System.Drawing.Size(512, 34);
            this.trackGF.TabIndex = 2;
            this.trackGF.Text = "label1";
            this.trackGF.Scroll += new System.EventHandler(this.Fore_Scroll);
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(4, 108);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(14, 13);
            this.lblB1.TabIndex = 5;
            this.lblB1.Text = "B";
            // 
            // trackBF
            // 
            this.trackBF.AutoSize = false;
            this.trackBF.Location = new System.Drawing.Point(24, 98);
            this.trackBF.Maximum = 255;
            this.trackBF.Name = "trackBF";
            this.trackBF.Size = new System.Drawing.Size(512, 34);
            this.trackBF.TabIndex = 4;
            this.trackBF.Text = "label1";
            this.trackBF.Scroll += new System.EventHandler(this.Fore_Scroll);
            // 
            // txtRF
            // 
            this.txtRF.Location = new System.Drawing.Point(540, 20);
            this.txtRF.MaxLength = 3;
            this.txtRF.Name = "txtRF";
            this.txtRF.Size = new System.Drawing.Size(38, 20);
            this.txtRF.TabIndex = 6;
            this.txtRF.Text = "0";
            this.txtRF.TextChanged += new System.EventHandler(this.Fore_TextChanged);
            this.txtRF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // txtGF
            // 
            this.txtGF.Location = new System.Drawing.Point(539, 61);
            this.txtGF.MaxLength = 3;
            this.txtGF.Name = "txtGF";
            this.txtGF.Size = new System.Drawing.Size(38, 20);
            this.txtGF.TabIndex = 7;
            this.txtGF.Text = "0";
            this.txtGF.TextChanged += new System.EventHandler(this.Fore_TextChanged);
            this.txtGF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // txtBF
            // 
            this.txtBF.Location = new System.Drawing.Point(539, 101);
            this.txtBF.MaxLength = 3;
            this.txtBF.Name = "txtBF";
            this.txtBF.Size = new System.Drawing.Size(38, 20);
            this.txtBF.TabIndex = 8;
            this.txtBF.Text = "0";
            this.txtBF.TextChanged += new System.EventHandler(this.Fore_TextChanged);
            this.txtBF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // groupFore
            // 
            this.groupFore.Controls.Add(this.lblDec1);
            this.groupFore.Controls.Add(this.txtDecF);
            this.groupFore.Controls.Add(this.lblOct1);
            this.groupFore.Controls.Add(this.txtOctF);
            this.groupFore.Controls.Add(this.lblHex1);
            this.groupFore.Controls.Add(this.txtHexF);
            this.groupFore.Controls.Add(this.trackBF);
            this.groupFore.Controls.Add(this.txtBF);
            this.groupFore.Controls.Add(this.trackRF);
            this.groupFore.Controls.Add(this.txtGF);
            this.groupFore.Controls.Add(this.lblR1);
            this.groupFore.Controls.Add(this.txtRF);
            this.groupFore.Controls.Add(this.trackGF);
            this.groupFore.Controls.Add(this.lblB1);
            this.groupFore.Controls.Add(this.lblG1);
            this.groupFore.Location = new System.Drawing.Point(9, 11);
            this.groupFore.Name = "groupFore";
            this.groupFore.Size = new System.Drawing.Size(590, 172);
            this.groupFore.TabIndex = 9;
            this.groupFore.TabStop = false;
            this.groupFore.Text = "Fore color";
            // 
            // lblDec1
            // 
            this.lblDec1.AutoSize = true;
            this.lblDec1.Location = new System.Drawing.Point(354, 141);
            this.lblDec1.Name = "lblDec1";
            this.lblDec1.Size = new System.Drawing.Size(29, 13);
            this.lblDec1.TabIndex = 14;
            this.lblDec1.Text = "DEC";
            // 
            // txtDecF
            // 
            this.txtDecF.Location = new System.Drawing.Point(389, 138);
            this.txtDecF.Name = "txtDecF";
            this.txtDecF.ReadOnly = true;
            this.txtDecF.Size = new System.Drawing.Size(129, 20);
            this.txtDecF.TabIndex = 13;
            // 
            // lblOct1
            // 
            this.lblOct1.AutoSize = true;
            this.lblOct1.Location = new System.Drawing.Point(180, 141);
            this.lblOct1.Name = "lblOct1";
            this.lblOct1.Size = new System.Drawing.Size(29, 13);
            this.lblOct1.TabIndex = 12;
            this.lblOct1.Text = "OCT";
            // 
            // txtOctF
            // 
            this.txtOctF.Location = new System.Drawing.Point(215, 138);
            this.txtOctF.Name = "txtOctF";
            this.txtOctF.ReadOnly = true;
            this.txtOctF.Size = new System.Drawing.Size(129, 20);
            this.txtOctF.TabIndex = 11;
            // 
            // lblHex1
            // 
            this.lblHex1.AutoSize = true;
            this.lblHex1.Location = new System.Drawing.Point(6, 141);
            this.lblHex1.Name = "lblHex1";
            this.lblHex1.Size = new System.Drawing.Size(29, 13);
            this.lblHex1.TabIndex = 10;
            this.lblHex1.Text = "HEX";
            // 
            // txtHexF
            // 
            this.txtHexF.Location = new System.Drawing.Point(41, 138);
            this.txtHexF.Name = "txtHexF";
            this.txtHexF.ReadOnly = true;
            this.txtHexF.Size = new System.Drawing.Size(129, 20);
            this.txtHexF.TabIndex = 9;
            // 
            // groupBack
            // 
            this.groupBack.Controls.Add(this.lblDec2);
            this.groupBack.Controls.Add(this.txtDecB);
            this.groupBack.Controls.Add(this.lblOct2);
            this.groupBack.Controls.Add(this.txtOctB);
            this.groupBack.Controls.Add(this.lblHex2);
            this.groupBack.Controls.Add(this.txtHexB);
            this.groupBack.Controls.Add(this.trackBB);
            this.groupBack.Controls.Add(this.txtBB);
            this.groupBack.Controls.Add(this.trackRB);
            this.groupBack.Controls.Add(this.txtGB);
            this.groupBack.Controls.Add(this.lblR2);
            this.groupBack.Controls.Add(this.txtRB);
            this.groupBack.Controls.Add(this.trackGB);
            this.groupBack.Controls.Add(this.lblB2);
            this.groupBack.Controls.Add(this.lblG2);
            this.groupBack.Location = new System.Drawing.Point(12, 189);
            this.groupBack.Name = "groupBack";
            this.groupBack.Size = new System.Drawing.Size(590, 172);
            this.groupBack.TabIndex = 15;
            this.groupBack.TabStop = false;
            this.groupBack.Text = "Back color";
            // 
            // lblDec2
            // 
            this.lblDec2.AutoSize = true;
            this.lblDec2.Location = new System.Drawing.Point(354, 141);
            this.lblDec2.Name = "lblDec2";
            this.lblDec2.Size = new System.Drawing.Size(29, 13);
            this.lblDec2.TabIndex = 14;
            this.lblDec2.Text = "DEC";
            // 
            // txtDecB
            // 
            this.txtDecB.Location = new System.Drawing.Point(389, 138);
            this.txtDecB.Name = "txtDecB";
            this.txtDecB.ReadOnly = true;
            this.txtDecB.Size = new System.Drawing.Size(129, 20);
            this.txtDecB.TabIndex = 13;
            // 
            // lblOct2
            // 
            this.lblOct2.AutoSize = true;
            this.lblOct2.Location = new System.Drawing.Point(180, 141);
            this.lblOct2.Name = "lblOct2";
            this.lblOct2.Size = new System.Drawing.Size(29, 13);
            this.lblOct2.TabIndex = 12;
            this.lblOct2.Text = "OCT";
            // 
            // txtOctB
            // 
            this.txtOctB.Location = new System.Drawing.Point(215, 138);
            this.txtOctB.Name = "txtOctB";
            this.txtOctB.ReadOnly = true;
            this.txtOctB.Size = new System.Drawing.Size(129, 20);
            this.txtOctB.TabIndex = 11;
            // 
            // lblHex2
            // 
            this.lblHex2.AutoSize = true;
            this.lblHex2.Location = new System.Drawing.Point(6, 141);
            this.lblHex2.Name = "lblHex2";
            this.lblHex2.Size = new System.Drawing.Size(29, 13);
            this.lblHex2.TabIndex = 10;
            this.lblHex2.Text = "HEX";
            // 
            // txtHexB
            // 
            this.txtHexB.Location = new System.Drawing.Point(41, 138);
            this.txtHexB.Name = "txtHexB";
            this.txtHexB.ReadOnly = true;
            this.txtHexB.Size = new System.Drawing.Size(129, 20);
            this.txtHexB.TabIndex = 9;
            // 
            // trackBB
            // 
            this.trackBB.AutoSize = false;
            this.trackBB.Location = new System.Drawing.Point(24, 98);
            this.trackBB.Maximum = 255;
            this.trackBB.Name = "trackBB";
            this.trackBB.Size = new System.Drawing.Size(512, 34);
            this.trackBB.TabIndex = 4;
            this.trackBB.Text = "label1";
            this.trackBB.Scroll += new System.EventHandler(this.Back_Scroll);
            // 
            // txtBB
            // 
            this.txtBB.Location = new System.Drawing.Point(539, 101);
            this.txtBB.MaxLength = 3;
            this.txtBB.Name = "txtBB";
            this.txtBB.Size = new System.Drawing.Size(38, 20);
            this.txtBB.TabIndex = 8;
            this.txtBB.Text = "0";
            this.txtBB.TextChanged += new System.EventHandler(this.Back_TextChanged);
            this.txtBB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // trackRB
            // 
            this.trackRB.AutoSize = false;
            this.trackRB.Location = new System.Drawing.Point(24, 18);
            this.trackRB.Maximum = 255;
            this.trackRB.Name = "trackRB";
            this.trackRB.Size = new System.Drawing.Size(512, 34);
            this.trackRB.TabIndex = 0;
            this.trackRB.Text = "label1";
            this.trackRB.Scroll += new System.EventHandler(this.Back_Scroll);
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(539, 61);
            this.txtGB.MaxLength = 3;
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(38, 20);
            this.txtGB.TabIndex = 7;
            this.txtGB.Text = "0";
            this.txtGB.TextChanged += new System.EventHandler(this.Back_TextChanged);
            this.txtGB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(4, 28);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(15, 13);
            this.lblR2.TabIndex = 1;
            this.lblR2.Text = "R";
            // 
            // txtRB
            // 
            this.txtRB.Location = new System.Drawing.Point(540, 20);
            this.txtRB.MaxLength = 3;
            this.txtRB.Name = "txtRB";
            this.txtRB.Size = new System.Drawing.Size(38, 20);
            this.txtRB.TabIndex = 6;
            this.txtRB.Text = "0";
            this.txtRB.TextChanged += new System.EventHandler(this.Back_TextChanged);
            this.txtRB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // trackGB
            // 
            this.trackGB.AutoSize = false;
            this.trackGB.Location = new System.Drawing.Point(24, 58);
            this.trackGB.Maximum = 255;
            this.trackGB.Name = "trackGB";
            this.trackGB.Size = new System.Drawing.Size(512, 34);
            this.trackGB.TabIndex = 2;
            this.trackGB.Text = "label1";
            this.trackGB.Scroll += new System.EventHandler(this.Back_Scroll);
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Location = new System.Drawing.Point(4, 108);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(14, 13);
            this.lblB2.TabIndex = 5;
            this.lblB2.Text = "B";
            // 
            // lblG2
            // 
            this.lblG2.AutoSize = true;
            this.lblG2.Location = new System.Drawing.Point(4, 68);
            this.lblG2.Name = "lblG2";
            this.lblG2.Size = new System.Drawing.Size(15, 13);
            this.lblG2.TabIndex = 3;
            this.lblG2.Text = "G";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(12, 368);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(590, 90);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Text";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(5, 465);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 17;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnResetFont
            // 
            this.btnResetFont.Location = new System.Drawing.Point(86, 465);
            this.btnResetFont.Name = "btnResetFont";
            this.btnResetFont.Size = new System.Drawing.Size(75, 23);
            this.btnResetFont.TabIndex = 18;
            this.btnResetFont.Text = "Font reset";
            this.btnResetFont.UseVisualStyleBackColor = true;
            this.btnResetFont.Click += new System.EventHandler(this.btnResetFont_Click);
            // 
            // frmRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 496);
            this.Controls.Add(this.btnResetFont);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.groupBack);
            this.Controls.Add(this.groupFore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRGB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB";
            this.Load += new System.EventHandler(this.frmRGB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBF)).EndInit();
            this.groupFore.ResumeLayout(false);
            this.groupFore.PerformLayout();
            this.groupBack.ResumeLayout(false);
            this.groupBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackRF;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblG1;
        private System.Windows.Forms.TrackBar trackGF;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.TrackBar trackBF;
        private System.Windows.Forms.TextBox txtRF;
        private System.Windows.Forms.TextBox txtGF;
        private System.Windows.Forms.TextBox txtBF;
        private System.Windows.Forms.GroupBox groupFore;
        private System.Windows.Forms.Label lblHex1;
        private System.Windows.Forms.TextBox txtHexF;
        private System.Windows.Forms.Label lblOct1;
        private System.Windows.Forms.TextBox txtOctF;
        private System.Windows.Forms.Label lblDec1;
        private System.Windows.Forms.TextBox txtDecF;
        private System.Windows.Forms.GroupBox groupBack;
        private System.Windows.Forms.Label lblDec2;
        private System.Windows.Forms.TextBox txtDecB;
        private System.Windows.Forms.Label lblOct2;
        private System.Windows.Forms.TextBox txtOctB;
        private System.Windows.Forms.Label lblHex2;
        private System.Windows.Forms.TextBox txtHexB;
        private System.Windows.Forms.TrackBar trackBB;
        private System.Windows.Forms.TextBox txtBB;
        private System.Windows.Forms.TrackBar trackRB;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.TextBox txtRB;
        private System.Windows.Forms.TrackBar trackGB;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblG2;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnResetFont;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}