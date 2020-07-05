using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Helper;
using Oracle.ManagedDataAccess.Client;

namespace insaSystem
{

    //시스템명 : 인사관리시스템
    //단위업무명 : 인사기록관리
    //프로그래머 : 박서윤

    //public delegate void EventHandler(string userName); //델리게이트 선언

    public partial class InsaLogin : Form
    {
        //db호출
        DBOracle_Helper oHelper;

        //public event EventHandler loginEventHandler;
        public InsaLogin()
        {
            InitializeComponent();
        }

        private void InsaLogin_Load(object sender, EventArgs e)
        {
            //db호출
            oHelper = new DBOracle_Helper();
        }
        #region Window 드래그 Control (마우스 핸들링)
        //-----------필수 코드--------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region 나가기, 최대화, 리스토어, 최소화 Btn Control
        //-----------나가기----------
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------최소화----------
        //private void minimizarbtn_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        #endregion
        #region Enter입력 이벤트
        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }
        #endregion
        #region ID, PW : Placeholder 초기화
        private void password_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            password.Text = "";
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }
        #endregion
        #region Login 기능
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginHandler loginHandler = new LoginHandler();
            if (ControlCheck())
            {
                if (loginHandler.LoginCheck(username.Text, password.Text))
                {
                    string userName = username.Text;
                    //loginEventHandler(userName);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 정확하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    username.Clear();
                    password.Clear();
                }
            }
        }
        //입력이 없을시
        private bool ControlCheck()
        {
            if (String.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
