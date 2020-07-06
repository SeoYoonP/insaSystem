using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Runtime.InteropServices;
using DB_Helper;
using System.Data;
using System.Diagnostics;

namespace insaSystem
{
    //시스템명 : 인사관리시스템
    //단위업무명 : 인사기록관리
    //프로그래머 : 박서윤

    public partial class InsaMangement : Form
    {
        DBOracle_Helper oHelper;

        int tabPageNum;
        
        public InsaMangement(int tp)
        {
            InitializeComponent();
            tabPageNum = tp;
        }

        private void InsaMangement_Load(Form form)
        {
            #region 프로그램 시작 시 확인, 취소버튼 Block
            checkbtn.Enabled = false;
            cancelbtn.Enabled = false;
            checkbtn.BackColor = Color.LightGray;
            cancelbtn.BackColor = Color.LightGray;
            tabControl1.SelectedIndex = tabPageNum;
            #endregion
            #region 프로그램 시작 시 인사시스템 데이터 그리드뷰 기본 생성
            sabunDataGridView.BackgroundColor = Color.White;
            sabunDataGridView.Columns.Add("bas_empno", "사번");
            sabunDataGridView.Columns.Add("bas_name", "성명");
            sabunDataGridView.Columns.Add("cd_codnms", "직급");
            sabunDataGridView.Columns.Add("dept_name", "부서");
            #endregion

            form.TopLevel = false;
            tabControl1.TabPages.Add(form.Text);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            form.Show();

            InsaMangement_Load(new Insa01BaseInfo());
        }
        //시스템 state control
        #region 나가기, 최대화, 리스토어, 최소화 Btn Control
        //-----------나가기----------
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        //사번검색
        #region 사번검색(고정) -- 기본화면
        //인사정보검색
        private void insaSearch_Click(object sender, EventArgs e)
        {   
            try
            {
                oHelper = new DBOracle_Helper();
                sabunDataGridView.Rows.Clear();
                string searchsql =
                    "select bas_empno, bas_name, bas_pos, cd_codnms, bas_dept, dept_name" +
                    " from thrm_bas_psy," +
                    " (select cd_grpcd, cd_code, cd_codnms from tieas_cd_psy where cd_grpcd = 'POS')," +
                    " thrm_dept_psy" +
                    " where bas_pos = cd_code" +
                    " and bas_dept = dept_code" +
                    " and bas_empno like '" + qry_empno.Text + "%'" +
                    " and bas_name like '" + qry_name.Text + "%'" +
                    " and dept_name like '" + qry_dept.Text + "%'" +
                    " order by bas_empno asc";
                DataTable sabunSearch = oHelper.GetData(searchsql);
                int cnt = 0;
                foreach(DataRow item in sabunSearch.Rows)
                {
                    sabunDataGridView.Rows.Add(item["BAS_EMPNO"].ToString(), item["BAS_NAME"].ToString(),
                                            item["cd_codnms"].ToString(), item["dept_name"].ToString());
                    cnt++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void insertbtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.MainForm = this;
            form.Btn_insert_clicked();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.MainForm = this;
            form.Btn_update_clicked();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.MainForm = this;
            form.Btn_delete_clicked();
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.MainForm = this;
            form.Btn_check_clicked();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.MainForm = this;
            form.Btn_cancel_clicked();
        }
    }
}
