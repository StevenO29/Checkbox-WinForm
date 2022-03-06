using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2WinForm2
{
    public partial class Week2WinForm2 : Form
    {
        public Week2WinForm2()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            LblResult.Text = TxtBoxInput.Text;
        }

        private void CheckBoxBold_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxBold.Checked == true)
                LblResult.Font = new Font(TxtBoxInput.Font, LblResult.Font.Style | FontStyle.Bold);
            else
                LblResult.Font = new Font(TxtBoxInput.Font, FontStyle.Regular);
        }

        private void CheckBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxItalic.Checked == true)
                LblResult.Font = new Font(TxtBoxInput.Font, LblResult.Font.Style| FontStyle.Italic);
            else
                LblResult.Font = new Font(TxtBoxInput.Font, FontStyle.Regular);
        }

        private void CheckBoxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxUnderline.Checked == true)
                LblResult.Font = new Font(TxtBoxInput.Font, LblResult.Font.Style | FontStyle.Underline);
            else
                LblResult.Font = new Font(TxtBoxInput.Font, FontStyle.Regular);
        }

        private void RadioBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            LblResult.ForeColor = Color.Red;
        }

        private void RadioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            LblResult.ForeColor = Color.Blue;
        }
    }
}
