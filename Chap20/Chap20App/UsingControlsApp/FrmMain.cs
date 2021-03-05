using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach ( var font in FontsList)
            {
                CboFonts.Items.Add(font.Name);
            }
        }
        //콤보박스, 체크박스 값으로 글자  변경하는 메소드
        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return; //콤보박스에 아무것도 선택안했으면(-1) 메서드 탈출

            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; //00000001 볼드체 이진수 표현
            if (ChkItalic.Checked) style |= FontStyle.Italic;//00000010 이테리체 이진수 표현
            //00000001 |00000010 볼드체 이면서 이테리체 이다

            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 14, style);
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void Chkbold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }
    }
}
