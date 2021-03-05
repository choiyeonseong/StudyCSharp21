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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);
            }
        }

        /// <summary>
        /// 콤보박스, 체크박스 값 변경으로 글자체 변경하는 메서드
        /// </summary>
        private void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0) return; // 콤보박스에 아무것도 선택 안했으면(-1) 메서드 탈출

            FontStyle style = FontStyle.Regular;    
            if (ChkBold.Checked) style |= FontStyle.Bold;   // 0000 0001
            if (ChkItalic.Checked) style |= FontStyle.Italic;   // 0000 0010
            // 0000 0001 | 0000 0010 = 0000 0011 -> bold & italic

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }
    }
}
