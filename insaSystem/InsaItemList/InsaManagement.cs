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

    public partial class InsaManagement : Form
    {
        static public string Mode { get; set; }
        //public Insa01BaseInfo Insa01BaseInfo { get; set; }
        //public Insa02FamInfo Insa02FamInfo { get; set; }
        //public Insa03EduInfo Insa03EduInfo { get; set; }
        //public Insa04AwardInfo Insa04AwardInfo { get; set; }
        //public Insa05CarInfo Insa05CarInfo { get; set; }
        //public Insa06LicInfo Insa06LicInfo { get; set; }
        //public Insa07ForlInfo Insa07ForlInfo { get; set; }
        
        DBOracle_Helper oHelper;

        int tabPageNum;

        public InsaManagement(int tp)
        {
            InitializeComponent();
            tabPageNum = tp;
        }

        public void frm_load(Form form)
        {
            form.TopLevel = false;
            tabControl1.TabPages.Add(form.Text);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(form);
            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            form.Show();
        }

        private void InsaMangement_Load(object sender, EventArgs e)
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
            #region InsaManageMentContent Load
            frm_load(new Insa01BaseInfo());
            frm_load(new Insa02FamInfo());
            frm_load(new Insa03EduInfo());
            frm_load(new Insa04AwardInfo());
            frm_load(new Insa05CarInfo());
            frm_load(new Insa06LicInfo());
            frm_load(new Insa07ForlInfo());
            #endregion
        }

        public string getData;
        //수정 및 connection 필요함
        #region 사번테이블 EVENT CellMouseDoubleClick -- 통합
        //인사기본 데이터 테이블 정보 더블클릭시 데이터 가져가기
        private void sabunDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Insa01BaseInfo Insa01BaseInfo = new Insa01BaseInfo();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.sabunDataGridView.Rows[e.RowIndex];
                getData = row.Cells["bas_empno"].Value.ToString();
                IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
                form.InsaManagement = this;
                form.DataGridView_Double_clicked();
            }

            ////가족사항
            //if (tabControl1.SelectedTab.TabIndex == 1)
            //{
            //    DataGridViewRow row = this.sabunDataGridView.Rows[e.RowIndex];

            //    bas_empno_fam.Text = row.Cells["bas_empno"].Value.ToString();
            //    bas_name_fam.Text = row.Cells["bas_name"].Value.ToString();
            //    bas_pos_fam.Text = row.Cells["cd_codnms"].Value.ToString(); ;
            //    bas_dept_fam.Text = row.Cells["dept_name"].Value.ToString();

            //    famDataGridView.Rows.Clear();
            //    string searchsql = " select fam_codnms as fam_rel, fam_name, fam_bth, fam_ltg" +
            //                       " from  thrm_bas_psy,       " +
            //                       "       thrm_fam_psy," +
            //                       "       (select cd_grpcd, cd_code, cd_codnms as fam_codnms " +
            //                       "       from  tieas_cd_psy where cd_grpcd = 'REL') " +
            //                       " where bas_empno = fam_empno(+) and fam_rel = cd_code" +
            //                       " and bas_empno = '" + bas_empno_fam.Text + "'";
            //    try
            //    {
            //        OracleCommand cmd = new OracleCommand();
            //        cmd.Connection = pgOraConn;
            //        cmd.CommandText = searchsql;
            //        OracleDataReader rd2 = cmd.ExecuteReader();

            //        int cnt = 0;
            //        while (rd2.Read())
            //        {
            //            famDataGridView.Rows.Add(rd2["fam_rel"].ToString(), rd2["fam_name"].ToString(), rd2["fam_bth"].ToString(), rd2["fam_ltg"].ToString());
            //            cnt++;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}

            ////학력사항
            //else if (tabControl1.SelectedTab.TabIndex == 2)
            //{
            //    DataGridViewRow row = this.sabunDataGridView.Rows[e.RowIndex];

            //    bas_empno_edu.Text = row.Cells["bas_empno"].Value.ToString();
            //    bas_name_edu.Text = row.Cells["bas_name"].Value.ToString();
            //    bas_pos_edu.Text = row.Cells["cd_codnms"].Value.ToString(); ;
            //    bas_dept_edu.Text = row.Cells["dept_name"].Value.ToString();

            //    DateTimePicker dtp = new DateTimePicker();//해결필요함 

            //    eduDataGridView.Rows.Clear();
            //    string searchsql = " select edu_empno, edu_loe, edu_endate, edu_gradate, edu_schnm, edu_dept, edu_degree, edu_grade, edu_gra, edu_last" +
            //                       " from  thrm_bas_psy," +
            //                       "       thrm_edu_psy" +
            //                       " where bas_empno = edu_empno(+) " +
            //                       " and bas_empno = '" + bas_empno_edu.Text + "'";
            //    MessageBox.Show("123123");
            //    try
            //    {
            //        OracleCommand cmd = new OracleCommand();
            //        cmd.Connection = pgOraConn;
            //        cmd.CommandText = searchsql;
            //        OracleDataReader rd3 = cmd.ExecuteReader();

            //        int cnt = 0;
            //        while (rd3.Read())
            //        {
            //            eduDataGridView.Rows.Add(rd3["edu_loe"].ToString(), rd3["edu_endate"].ToString(), rd3["edu_gradate"].ToString(), rd3["edu_schrm"].ToString(), rd3["edu_dept"].ToString(), rd3["edu_degree"].ToString(), rd3["edu_grade"].ToString(), rd3["edu_gra"].ToString());
            //            cnt++;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}

            ////상벌이력
            //else if (tabControl1.SelectedTab.TabIndex == 3)
            //{

            //}

            ////경력사항
            //else if (tabControl1.SelectedTab.TabIndex == 4)
            //{

            //}

            ////자격면허
            //else if (tabControl1.SelectedTab.TabIndex == 5)
            //{

            //}

            ////외국어
            //else if (tabControl1.SelectedTab.TabIndex == 6)
            //{

            //}
        }
        #endregion
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
                foreach (DataRow item in sabunSearch.Rows)
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
            form.InsaManagement = this;
            form.Btn_insert_clicked();
            BtnCotrol();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.InsaManagement = this;
            form.Btn_update_clicked();
            BtnCotrol();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.InsaManagement = this;
            form.Btn_delete_clicked();
            BtnCotrol();
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.InsaManagement = this;
            form.Btn_check_clicked();
            MessageBox.Show(Mode);
            BtnCotrol();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            IForm form = (IForm)tabControl1.SelectedTab.Controls[0];
            form.InsaManagement = this;
            form.Btn_cancel_clicked();
            BtnCotrol();
        }

        private void BtnIUDBlock()
        {
            insertbtn.Enabled = false;
            updatebtn.Enabled = false;
            deletebtn.Enabled = false;
            checkbtn.Enabled = true;
            cancelbtn.Enabled = true;
        }
        private void BtnIUDGray()
        {
            insertbtn.BackColor = Color.LightGray;
            updatebtn.BackColor = Color.LightGray;
            deletebtn.BackColor = Color.LightGray;
            checkbtn.BackColor = Color.White;
            cancelbtn.BackColor = Color.White;
        }

        private void BtnCCBlock()
        {
            insertbtn.Enabled = true;
            updatebtn.Enabled = true;
            deletebtn.Enabled = true;
            checkbtn.Enabled = false;
            cancelbtn.Enabled = false;
        }
        private void BtnCCGray()
        {
            insertbtn.BackColor = Color.White;
            updatebtn.BackColor = Color.White;
            deletebtn.BackColor = Color.White;
            checkbtn.BackColor = Color.LightGray;
            cancelbtn.BackColor = Color.LightGray;
        }

        private void BtnCotrol()
        {
            if (Mode == "BlockIUD")
            {
                BtnIUDGray();
                BtnIUDBlock();
                Mode = "";
            }
            
            if(Mode == "BlockCC")
            {
                BtnCCBlock();
                BtnCCGray();
                Mode = "";
            }
        }

    }
}
 