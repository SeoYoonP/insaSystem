using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace insaSystem
{
    public partial class InsaMain : Form
    {
        InsaLogin loginForm;
        Form assist;
        InsaManagement mng;

        #region raindrops 초석, insa버튼 색깔 제어
        //raindrops 초석
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private extern static IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
        int[] rainSpeeds = { 1, 2, 2, 3, 2, 2, 1, 1 };

        //insa버튼 색깔 제어
        int on01 = 0; int on02 = 0; int on03 = 0; int on04 = 0; int on05 = 0;
        #endregion

        public InsaMain(string info)
        {
            #region raindrops 초석, 보조사이드바 숨기기
            InitializeComponent();
            //raindrops 초석
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            timer1.Start();
            //보조 사이드바 숨기기
            assistVertical.Visible = false;
            #endregion
        }

        #region 나가기, 최대화, 리스토어, 최소화 Btn Control
        //-----------나가기----------
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-----------최대화----------
        private void maximizarbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restorebtn.Visible = true;
            maximizarbtn.Visible = false;
        }
        //-----------리스토어----------
        private void restorebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restorebtn.Visible = false;
            maximizarbtn.Visible = true;
        }
        //-----------최소화----------
        private void minimizarbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Window 드래그 Control (마우스 핸들링)
        //-----------필수 코드--------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            screenMouseDown();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            screenMouseDown();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            screenMouseDown();
        }

        private void screenMouseDown()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Raindrop Control
        private void timer1_Tick(object sender, EventArgs e)
        {
            //do animation
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        //animation for rain1;
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + rainSpeeds[i]);
                        if (pictureBox2.Location.Y > panel7.Size.Height + pictureBox2.Size.Height)
                        {
                            pictureBox2.Location = new Point(pictureBox2.Location.X, 0 - pictureBox2.Size.Height);
                        }
                        break;
                    case 1:
                        //animation for rain2;
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + rainSpeeds[i]);
                        if (pictureBox3.Location.Y > panel7.Size.Height + pictureBox3.Size.Height)
                        {
                            pictureBox3.Location = new Point(pictureBox3.Location.X, 0 - pictureBox3.Size.Height);
                        }
                        break;
                    case 2:
                        //animation for rain3;
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + rainSpeeds[i]);
                        if (pictureBox4.Location.Y > panel7.Size.Height + pictureBox4.Size.Height)
                        {
                            pictureBox4.Location = new Point(pictureBox4.Location.X, 0 - pictureBox4.Size.Height);
                        }
                        break;
                    case 3:
                        //animation for rain4;
                        pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + rainSpeeds[i]);
                        if (pictureBox5.Location.Y > panel7.Size.Height + pictureBox5.Size.Height)
                        {
                            pictureBox5.Location = new Point(pictureBox5.Location.X, 0 - pictureBox5.Size.Height);
                        }
                        break;
                    case 4:
                        //animation for rain5;
                        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + rainSpeeds[i]);
                        if (pictureBox6.Location.Y > panel7.Size.Height + pictureBox6.Size.Height)
                        {
                            pictureBox6.Location = new Point(pictureBox6.Location.X, 0 - pictureBox6.Size.Height);
                        }
                        break;
                    case 5:
                        //animation for rain6;
                        pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + rainSpeeds[i]);
                        if (pictureBox7.Location.Y > panel7.Size.Height + pictureBox7.Size.Height)
                        {
                            pictureBox7.Location = new Point(pictureBox7.Location.X, 0 - pictureBox7.Size.Height);
                        }
                        break;
                    case 6:
                        //animation for rain7;
                        pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + rainSpeeds[i]);
                        if (pictureBox8.Location.Y > panel7.Size.Height + pictureBox8.Size.Height)
                        {
                            pictureBox8.Location = new Point(pictureBox8.Location.X, 0 - pictureBox8.Size.Height);
                        }
                        break;
                    case 7:
                        //animation for rain8;
                        pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + rainSpeeds[i]);
                        if (pictureBox9.Location.Y > panel7.Size.Height + pictureBox9.Size.Height)
                        {
                            pictureBox9.Location = new Point(pictureBox9.Location.X, 0 - pictureBox9.Size.Height);
                        }
                        break;
                }
            }
        }
        #endregion
        #region insa 버튼 color Control

        //-------------MouseMove 및 MouseLeave시 컬러변화------------

        //인사기초 정보
        private void insa_baseBtn_MouseMove(object sender, MouseEventArgs e)
        {
            insa_baseBtn.ForeColor = Color.Black;
            insa_baseBtn.BackColor = Color.WhiteSmoke;

            insa_recordBtn.ForeColor = Color.White;
            insa_recordBtn.BackColor = Color.CornflowerBlue;

            insa_changeBtn.ForeColor = Color.White;
            insa_changeBtn.BackColor = Color.CornflowerBlue;

            insa_certificateBtn.ForeColor = Color.White;
            insa_certificateBtn.BackColor = Color.CornflowerBlue;

            insa_graphBtn.ForeColor = Color.White;
            insa_graphBtn.BackColor = Color.CornflowerBlue;
        }
        private void insa_baseBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        //인사기록 관리
        private void insa_recordBtn_MouseMove(object sender, MouseEventArgs e)
        {
            insa_recordBtn.ForeColor = Color.Black;
            insa_recordBtn.BackColor = Color.WhiteSmoke;

            insa_baseBtn.ForeColor = Color.White;
            insa_baseBtn.BackColor = Color.CornflowerBlue;

            insa_changeBtn.ForeColor = Color.White;
            insa_changeBtn.BackColor = Color.CornflowerBlue;

            insa_certificateBtn.ForeColor = Color.White;
            insa_certificateBtn.BackColor = Color.CornflowerBlue;

            insa_graphBtn.ForeColor = Color.White;
            insa_graphBtn.BackColor = Color.CornflowerBlue;
        }
        private void insa_recordBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        //인사변동 관리
        private void insa_changeBtn_MouseMove(object sender, MouseEventArgs e)
        {
            insa_changeBtn.ForeColor = Color.Black;
            insa_changeBtn.BackColor = Color.WhiteSmoke;

            insa_baseBtn.ForeColor = Color.White;
            insa_baseBtn.BackColor = Color.CornflowerBlue;

            insa_recordBtn.ForeColor = Color.White;
            insa_recordBtn.BackColor = Color.CornflowerBlue;

            insa_certificateBtn.ForeColor = Color.White;
            insa_certificateBtn.BackColor = Color.CornflowerBlue;

            insa_graphBtn.ForeColor = Color.White;
            insa_graphBtn.BackColor = Color.CornflowerBlue;
        }
        private void insa_changeBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        //제증명서 발급
        private void insa_certificateBtn_MouseMove(object sender, MouseEventArgs e)
        {
            insa_certificateBtn.ForeColor = Color.Black;
            insa_certificateBtn.BackColor = Color.WhiteSmoke;

            insa_baseBtn.ForeColor = Color.White;
            insa_baseBtn.BackColor = Color.CornflowerBlue;

            insa_recordBtn.ForeColor = Color.White;
            insa_recordBtn.BackColor = Color.CornflowerBlue;

            insa_changeBtn.ForeColor = Color.White;
            insa_changeBtn.BackColor = Color.CornflowerBlue;

            insa_graphBtn.ForeColor = Color.White;
            insa_graphBtn.BackColor = Color.CornflowerBlue;

        }
        private void insa_certificateBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        //현황 및 통계
        private void insa_graphBtn_MouseMove(object sender, MouseEventArgs e)
        {
            insa_graphBtn.ForeColor = Color.Black;
            insa_graphBtn.BackColor = Color.WhiteSmoke;

            insa_baseBtn.ForeColor = Color.White;
            insa_baseBtn.BackColor = Color.CornflowerBlue;

            insa_recordBtn.ForeColor = Color.White;
            insa_recordBtn.BackColor = Color.CornflowerBlue;

            insa_changeBtn.ForeColor = Color.White;
            insa_changeBtn.BackColor = Color.CornflowerBlue;

            insa_certificateBtn.ForeColor = Color.White;
            insa_certificateBtn.BackColor = Color.CornflowerBlue;

        }
        private void insa_graphBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void White_ConflowerBlue()
        {
            insa_baseBtn.ForeColor = Color.White;
            insa_baseBtn.BackColor = Color.CornflowerBlue;
            insa_recordBtn.ForeColor = Color.White;
            insa_recordBtn.BackColor = Color.CornflowerBlue;
            insa_changeBtn.ForeColor = Color.White;
            insa_changeBtn.BackColor = Color.CornflowerBlue;
            insa_certificateBtn.ForeColor = Color.White;
            insa_certificateBtn.BackColor = Color.CornflowerBlue;
            insa_graphBtn.ForeColor = Color.White;
            insa_graphBtn.BackColor = Color.CornflowerBlue;
        }

        private void panelContenedor_MouseMove(object sender, MouseEventArgs e)
        {
            if (assistVertical.Visible == false)
            {
                White_ConflowerBlue();
            }
        }
        #endregion
        #region insa버튼 기능 Control (미완성)
        //인사기초정보(insa_base)
        //=====================================================================
        private void insa_baseBtn_Click(object sender, EventArgs e)
        {
            if (on01 == 0)
            {
                on01 = 1; on02 = 0; on03 = 0; on04 = 0; on05 = 0;
               
                if (assist != null)
                {
                    assist.Close();
                }

                if (this.assistVertical.Controls.Count > 0)
                {
                    this.assistVertical.Controls.RemoveAt(0);
                }
                //보조 Bar 소환
                assistVertical.Visible = true;

                //메뉴 호출
                Call_assistMenu(new MainMenubar01());
            }
            else
            {
                assist.Close();
                assistVertical.Visible = false;
                on01 = 0;
            }
        }
        //=====================================================================

        //인사기록관리(insa_record)
        //=====================================================================
        private void insa_recordBtn_Click(object sender, EventArgs e)
        {
            if (on02 == 0)
            {
                on01 = 0; on02 = 1; on03 = 0; on04 = 0; on05 = 0;
               
                if (assist != null)
                {
                    assist.Close();
                }
                
                if (this.assistVertical.Controls.Count > 0)
                {
                    this.assistVertical.Controls.RemoveAt(0);
       
                }
                assistVertical.Visible = false;
                //보조 Bar 소환
                assistVertical.Visible = true;

                //메뉴 호출
                Call_assistMenu(new MainMenubar02());
            }
            else
            {
                assist.Close();
                assistVertical.Visible = false;
                on02 = 0;
            }
        }
        //=====================================================================

        //인사변동관리(insa_change)
        //=====================================================================
        private void insa_changeBtn_Click(object sender, EventArgs e)
        {
            if (on03 == 0)
            {
                on01 = 0; on02 = 0; on03 = 1; on04 = 0; on05 = 0;

                if (assist != null)
                {
                    assist.Close();
                }
              
                if (this.assistVertical.Controls.Count > 0)
                {
                    this.assistVertical.Controls.RemoveAt(0);

                }
                assistVertical.Visible = false;
             
                //보조 Bar 소환
                assistVertical.Visible = true;

                //메뉴 호출
                Call_assistMenu(new MainMenubar03());
            }
            else
            {
                assist.Close();
                assistVertical.Visible = false;
                on03 = 0;
            }
        }
        //=====================================================================

        //제증명서발급(insa_certificate)
        //=====================================================================
        private void insa_certificateBtn_Click(object sender, EventArgs e)
        {
            if (on04 == 0)
            {
                on01 = 0; on02 = 0; on03 = 0; on04 = 1; on05 = 0;

                if (assist != null)
                {
                    assist.Close();
                }

                if (this.assistVertical.Controls.Count > 0)
                {
                    this.assistVertical.Controls.RemoveAt(0);

                    //assist = null; // assist를 null로 만들어준다
                }
                assistVertical.Visible = false;
              
                //보조 Bar 소환
                assistVertical.Visible = true;

                //메뉴 호출
                Call_assistMenu(new MainMenubar04());
              
            }
            else
            {
                assist.Close();
                assistVertical.Visible = false;
                on04 = 0;
            }
        }
        //=====================================================================

        //현황및통계(insa_graph)
        //=====================================================================
        private void insa_graphBtn_Click(object sender, EventArgs e)
        {
            if (on05 == 0)
            {
                on01 = 0; on02 = 0; on03 = 0; on04 = 0; on05 = 1;

                if (assist != null)
                {
                    assist.Close();
                }

                if (this.assistVertical.Controls.Count > 0)
                {
                    this.assistVertical.Controls.RemoveAt(0);

                    //assist = null; // assist를 null로 만들어준다
                }
                assistVertical.Visible = false;
               
                //보조 Bar 소환
                assistVertical.Visible = true;

                //메뉴 호출
                Call_assistMenu(new MainMenubar05());
            }
            else
            {
                assist.Close();
                assistVertical.Visible = false;
                on05 = 0;
            }
        }
        //=====================================================================
        #endregion
        #region sideMenuBar 호출하기, 닫아주기 함수
        //호출하기
        private void Call_assistMenu(object FormCall)
        {
            if (this.assistVertical.Controls.Count > 0)
                this.assistVertical.Controls.RemoveAt(0);
            assist = FormCall as Form;
            assist.TopLevel = false;
            assist.Dock = DockStyle.Fill;
            this.assistVertical.Controls.Add(assist);
            this.assistVertical.Tag = assist;
            assist.Show();
        }

        //닫아주기
        private void Close_assistMenu(object FormClose)
        {
            Form assist_close = FormClose as Form;
            assist_close.Close();
        }


        #endregion
        #region 실시간 시간, 날짜 출력 함수
        private void timechange_Tick(object sender, EventArgs e)
        {
            lblTimeToday.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDateToday.Text = DateTime.Now.ToLongDateString();
        }
        #endregion
        #region 메뉴바가 켜져있을 때 중앙 패널을 눌렀을시 메뉴바 닫고 버튼 컬러 초기화
        private void panelContenedor_Click(object sender, EventArgs e)
        {
            if (assist != null)
            {
                assist.Close();
                assistVertical.Visible = false;

                insa_baseBtn.BackColor = Color.CornflowerBlue;
                insa_baseBtn.ForeColor = Color.White;

                insa_recordBtn.BackColor = Color.CornflowerBlue;
                insa_recordBtn.ForeColor = Color.White;

                insa_changeBtn.BackColor = Color.CornflowerBlue;
                insa_changeBtn.ForeColor = Color.White;

                insa_certificateBtn.BackColor = Color.CornflowerBlue;
                insa_certificateBtn.ForeColor = Color.White;

                insa_graphBtn.BackColor = Color.CornflowerBlue;
                insa_graphBtn.ForeColor = Color.White;
            }
        }

        #endregion
         
        private void InsaMain_Load(object sender, EventArgs e)
        {
            loginForm = new InsaLogin();//로그인폼 생성
            switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    loginForm.Close();
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }
        }
    }
}
