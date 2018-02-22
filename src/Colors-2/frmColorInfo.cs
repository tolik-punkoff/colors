using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Colors_2
{
    public partial class frmColorInfo : Form
    {        
        public Color ColorInfo;
        public frmColorInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmColorInfo_Load(object sender, EventArgs e)
        {
            string Info="";
            Info = Info + "R " + ColorInfo.R + "\r\n" +
                Info + "G " + ColorInfo.G + "\r\n" +
                Info + "B " + ColorInfo.B + "\r\n" +
                Info + "A " + ColorInfo.A + "\r\n" +
                Info + "Hue " + ColorInfo.GetHue().ToString() + "\r\n" +
                Info + "Saturation " + ColorInfo.GetSaturation().ToString() + "\r\n" +
                Info + "Brightness " + ColorInfo.GetBrightness().ToString() + "\r\n" +
                Info + "IsKnownColor " + ColorInfo.IsKnownColor.ToString() + "\r\n" +
                Info + "IsNamedColor " + ColorInfo.IsNamedColor.ToString() + "\r\n" +
                Info + "IsSystemColor " + ColorInfo.IsSystemColor.ToString() + "\r\n" +
                Info + "Name " + ColorInfo.Name;

            txtColor.Text = Info;
            lblColor.BackColor = ColorInfo;
        }
    }
}
