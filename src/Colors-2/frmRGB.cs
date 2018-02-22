using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Colors_2
{
    public partial class frmRGB : Form
    {
        public frmRGB()
        {
            InitializeComponent();
        }

        Font oldFont = new Font(FontFamily.GenericSerif, 12);        

        private void frmRGB_Load(object sender, EventArgs e)
        {
            oldFont = lblColor.Font;
        }
        

        private void Fore_Scroll(object sender, EventArgs e)
        {
            txtRF.Text = trackRF.Value.ToString();
            txtGF.Text = trackGF.Value.ToString();
            txtBF.Text = trackBF.Value.ToString();
        }

        private void Back_Scroll(object sender, EventArgs e)
        {
            txtRB.Text = trackRB.Value.ToString();
            txtGB.Text = trackGB.Value.ToString();
            txtBB.Text = trackBB.Value.ToString();
        }

        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void Fore_TextChanged(object sender, EventArgs e)
        {
            if (txtRF.Text == string.Empty) txtRF.Text = "0";
            if (txtGF.Text == string.Empty) txtGF.Text = "0";
            if (txtBF.Text == string.Empty) txtBF.Text = "0";

            int iRF = Convert.ToInt32(txtRF.Text);
            int iGF = Convert.ToInt32(txtGF.Text);
            int iBF = Convert.ToInt32(txtBF.Text);

            if (iRF > 255) iRF = 255;
            if (iGF > 255) iGF = 255;
            if (iBF > 255) iBF = 255;
            
            trackRF.Value = iRF;
            trackGF.Value = iGF;
            trackBF.Value = iBF;

            txtHexF.Text = "#" + Convert.ToString(iRF, 16) + Convert.ToString(iGF, 16)+
                Convert.ToString(iBF, 16);
            txtOctF.Text = Convert.ToString(iRF, 8) + " "+Convert.ToString(iGF, 8) +
                " " + Convert.ToString(iBF, 8);
            txtDecF.Text = Convert.ToString(iRF)+" "+ Convert.ToString(iGF)+
                " "+Convert.ToString(iBF);

            lblColor.ForeColor = Color.FromArgb(iRF, iGF, iBF);
            
        }

        private void Back_TextChanged(object sender, EventArgs e)
        {
            if (txtRB.Text == string.Empty) txtRB.Text = "0";
            if (txtGB.Text == string.Empty) txtGB.Text = "0";
            if (txtBB.Text == string.Empty) txtBB.Text = "0";

            int iRB = Convert.ToInt32(txtRB.Text);
            int iGB = Convert.ToInt32(txtGB.Text);
            int iBB = Convert.ToInt32(txtBB.Text);

            if (iRB > 255) iRB = 255;
            if (iGB > 255) iGB = 255;
            if (iBB > 255) iBB = 255;

            trackRB.Value = iRB;
            trackGB.Value = iGB;
            trackBB.Value = iBB;

            txtHexB.Text = "#" + Convert.ToString(iRB, 16) + Convert.ToString(iGB, 16) +
                Convert.ToString(iBB, 16);
            txtOctB.Text = Convert.ToString(iRB, 8) + " " + Convert.ToString(iGB, 8) +
                " " + Convert.ToString(iBB, 8);
            txtDecB.Text = Convert.ToString(iRB) + " " + Convert.ToString(iGB) +
                " " + Convert.ToString(iBB);

            lblColor.BackColor = Color.FromArgb(iRB, iGB, iBB);

        }

        private void btnResetFont_Click(object sender, EventArgs e)
        {
            lblColor.Font = oldFont;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult Ans = dlgFont.ShowDialog();
            if (Ans == DialogResult.Cancel) return;
            lblColor.Font = dlgFont.Font;
        }
    }
}
