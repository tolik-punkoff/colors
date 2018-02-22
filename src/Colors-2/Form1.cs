using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Colors_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private string[] DuplicateNames(string name, int count)
        {
            string[] buf = new string[count];
            for (int i = 0; i < count; i++)
            {
                buf[i] = name;
            }
            return buf;
        }

        private void SetMainColors()
        {
            grdColors.Rows.Clear();
            grdColors.Columns.Clear();

            string[] ColorNames = Enum.GetNames(typeof(KnownColor));

            //колонки
            foreach (string n in ColorNames)
            {
                KnownColor knownColor = 
                    (KnownColor)Enum.Parse(typeof(KnownColor), n);
                
                //добавляем только не системные цвета
                if ((knownColor > KnownColor.Transparent)&&
                    (knownColor <= KnownColor.YellowGreen))
                {
                    grdColors.Columns.Add("col" + n, n);                    
                }
            }
            
            //строки
            foreach (string n in ColorNames)
            {
                KnownColor knownColor =
                    (KnownColor)Enum.Parse(typeof(KnownColor), n);

                //добавляем только не системные цвета
                if ((knownColor > KnownColor.Transparent) &&
                    (knownColor <= KnownColor.YellowGreen))
                {
                    grdColors.Rows.Add(DuplicateNames(n, ColorNames.Length));
                }
            }
            
            //красим

            for (int i = 0; i < grdColors.Rows.Count; i++)
            {
                for (int j = 0; j < grdColors.Columns.Count; j++)
                {
                    grdColors.Rows[i].Cells[j].Style.ForeColor = Color.FromName(
                        grdColors.Rows[i].Cells[j].Value.ToString());

                    grdColors.Rows[i].Cells[j].Style.BackColor = Color.FromName(
                        grdColors.Columns[j].HeaderText);
                }
            }

        }

        private void SetSystemColors()
        {
            grdColors.Rows.Clear();
            grdColors.Columns.Clear();

            string[] ColorNames = Enum.GetNames(typeof(KnownColor));

            //колонки
            foreach (string n in ColorNames)
            {
                KnownColor knownColor =
                    (KnownColor)Enum.Parse(typeof(KnownColor), n);

                //добавляем только системные цвета
                if ((knownColor <= KnownColor.Transparent) ||
                    (knownColor > KnownColor.YellowGreen))
                {
                    grdColors.Columns.Add("col" + n, n);
                }
            }

            //строки
            foreach (string n in ColorNames)
            {
                KnownColor knownColor =
                    (KnownColor)Enum.Parse(typeof(KnownColor), n);

                //добавляем только системные цвета
                if ((knownColor <= KnownColor.Transparent) ||
                    (knownColor > KnownColor.YellowGreen))
                {
                    grdColors.Rows.Add(DuplicateNames(n, ColorNames.Length));
                }
            }

            //красим

            for (int i = 0; i < grdColors.Rows.Count; i++)
            {
                for (int j = 0; j < grdColors.Columns.Count; j++)
                {
                    grdColors.Rows[i].Cells[j].Style.ForeColor = Color.FromName(
                        grdColors.Rows[i].Cells[j].Value.ToString());

                    grdColors.Rows[i].Cells[j].Style.BackColor = Color.FromName(
                        grdColors.Columns[j].HeaderText);
                }
            }

        }


        Font oldFont = new Font(FontFamily.GenericSerif, 12);

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetMainColors();
            oldFont = grdColors.Font;
        }

        private void mnuMainColors_Click(object sender, EventArgs e)
        {
            SetMainColors();
        }

        private void mnuSystemColors_Click(object sender, EventArgs e)
        {
            SetSystemColors();
        }

        private void mnuRGB_Click(object sender, EventArgs e)
        {
            frmRGB fRGB = new frmRGB();
            fRGB.ShowDialog();
        }

        private void mnuColorDialog_Click(object sender, EventArgs e)
        {
            DialogResult Ans = dlgColor.ShowDialog();
            if (Ans == DialogResult.Cancel) return;
            frmColorInfo fColorInfo = new frmColorInfo();
            fColorInfo.ColorInfo = dlgColor.Color;
            fColorInfo.ShowDialog();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            DialogResult Ans = dlgFont.ShowDialog();
            if (Ans == DialogResult.Cancel) return;
            grdColors.Font = dlgFont.Font;
        }

        private void mnuFontReset_Click(object sender, EventArgs e)
        {
            grdColors.Font = oldFont;
        }
        
    }
}
