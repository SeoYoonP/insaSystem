using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaSystem
{
    public partial class MainMenubar02 : Form
    {
        InsaManagement mng;
        public MainMenubar02()
        {
            InitializeComponent();
        }

        #region 인사기록관리 border Color - White
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }
        #endregion
        #region 선택 메뉴로 들어가기 Control
        private void InsaInput_Click(object sender, EventArgs e)
        {
            InsaManagement InsaManSys = new InsaManagement(0);
            InsaManSys.ShowDialog();
            
        }

        private void InsaInquiry_Click(object sender, EventArgs e)
        {
            InsaManagement InsaManSys = new InsaManagement(7);
            InsaManSys.ShowDialog();
        }
        #endregion
    }
}
