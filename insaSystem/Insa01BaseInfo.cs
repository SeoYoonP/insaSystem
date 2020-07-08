using DB_Helper;
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
    public partial class Insa01BaseInfo : Form, IForm
    {
        DBOracle_Helper oHelper;
        public InsaManagement MainForm { get; set; }
        string bas_mar = "";

        public Insa01BaseInfo()
        {
            InitializeComponent();
        }

        private void Insa01BaseInfo_Load(object sender, EventArgs e)
        {
            oHelper = new DBOracle_Helper();
        }

        public void Btn_insert_clicked()
        {
            TextboxClear();
            bas_empno.Focus();
            MessageBox.Show("인사기본사항 입력을 시작합니다.");

            //this.BackColor = Color.LightGray;
            //this.textBox1.Text = MainForm.textBox1.Text;
        }
        public void Btn_update_clicked()
        {
            if (bas_empno.Text == "")
            {
                MessageBox.Show("사원번호를 입력하세요");
                bas_empno.Focus();
                InsabaseEnableFalse();
                return;
            }
            InsabaseEnableTrue();

            string sabun_sql = "select bas_empno,bas_resno,bas_name,bas_cname,bas_ename,bas_fix,bas_zip,bas_addr,bas_residence,bas_hdpno,bas_telno,bas_email,bas_mil_sta,bas_mil_mil,bas_mil_rnk,bas_mar,bas_acc_bank1,bas_acc_name1,bas_acc_no1,bas_acc_bank2,bas_acc_name2,bas_acc_no2,bas_cont,bas_intern,bas_intern_no,bas_emp_sdate,bas_emp_edate,bas_entdate,bas_resdate,bas_levdate,bas_reidate,bas_wsta,(bas_sts ||':'|| cd_codnms) as bas_sts,(bas_pos ||':'|| pos_codnms) as bas_pos ,(bas_dut ||':'|| dut_codnms) as bas_dut, (bas_dept ||':'||dept_name) as bas_dept,bas_rmk,bas_pos_dt,bas_dut_dt,bas_dept_dt,bas_intern_dt from thrm_bas_psy,(select cd_code, cd_codnms from tieas_cd_psy where cd_grpcd = 'STS'),(select cd_code as pos_code, cd_codnms as pos_codnms from tieas_cd_psy where cd_grpcd = 'POS'),(select cd_code as dut_code, cd_codnms as dut_codnms from tieas_cd_psy where cd_grpcd = 'DUT'), thrm_dept_psy where bas_sts =cd_code and bas_pos =pos_code and bas_dut = dut_code(+) and bas_empno='" + bas_empno.Text + "'";

            DataTable SabunInfo = oHelper.GetData(sabun_sql);
            foreach (DataRow Row in SabunInfo.Rows)
            {
                if (Row == null)
                {
                    MessageBox.Show("등록되어있지 않는 사원번호입니다.");
                    return;
                }
                String date_emp_sdate;
                String date_emp_sdate_print;

                String date_emp_edate;
                String date_emp_edate_print;

                String date_entdate;
                String date_entdate_print;

                String date_resdate;
                String date_resdate_print;

                String date_levdate;
                String date_levdate_print;

                String date_reidate;
                String date_reidate_print;

                String date_pos_dt;
                String date_pos_dt_print;

                String date_dut_dt;
                String date_dut_dt_print;

                String date_dept_dt;
                String date_dept_dt_print;

                String date_intern_dt;
                String date_intern_dt_print;
                String aa;

                string putin = Row["bas_dept"].ToString();
                string[] dept = putin.Split(':');

                if (Row["bas_emp_sdate"] as string != null)
                {
                    date_emp_sdate = Row["bas_emp_sdate"] as string;
                    date_emp_sdate_print = date_emp_sdate.Substring(0, 4) + "-" + date_emp_sdate.Substring(4, 2) + "-" + date_emp_sdate.Substring(6, 2);
                    bas_emp_sdate.Text = date_emp_sdate_print;
                }
                else
                {
                    bas_emp_sdate.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_emp_edate"] as string != null)
                {
                    date_emp_edate = Row["bas_emp_edate"] as string;
                    date_emp_edate_print = date_emp_edate.Substring(0, 4) + "-" + date_emp_edate.Substring(4, 2) + "-" + date_emp_edate.Substring(6, 2);
                    bas_emp_edate.Text = date_emp_edate_print;
                }
                else
                {
                    bas_emp_edate.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_entdate"] as string != null)
                {
                    date_entdate = Row["bas_entdate"] as string;
                    date_entdate_print = date_entdate.Substring(0, 4) + "-" + date_entdate.Substring(4, 2) + "-" + date_entdate.Substring(6, 2);
                    bas_entdate.Text = date_entdate_print;
                }
                else
                {
                    bas_entdate.Format = DateTimePickerFormat.Custom;
                }

                if (!string.IsNullOrEmpty(Row["bas_resdate"] as string))
                {
                    date_resdate = Row["bas_resdate"] as string;
                    date_resdate_print = date_resdate.Substring(0, 4) + "-" + date_resdate.Substring(4, 2) + "-" + date_resdate.Substring(6, 2);
                    bas_resdate.Text = date_resdate_print;
                }
                else
                {
                    bas_resdate.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_levdate"] as string != null)
                {
                    date_levdate = Row["bas_levdate"] as string;
                    date_levdate_print = date_levdate.Substring(0, 4) + "-" + date_levdate.Substring(4, 2) + "-" + date_levdate.Substring(6, 2);
                    bas_levdate.Text = date_levdate_print;
                }
                else
                {
                    bas_levdate.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_reidate"] as string != null)
                {
                    date_reidate = Row["bas_reidate"] as string;
                    date_reidate_print = date_reidate.Substring(0, 4) + "-" + date_reidate.Substring(4, 2) + "-" + date_reidate.Substring(6, 2);
                    bas_reidate.Text = date_reidate_print;
                }
                else
                {
                    bas_reidate.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_pos_dt"] as string != null)
                {
                    date_pos_dt = Row["bas_pos_dt"] as string;
                    date_pos_dt_print = date_pos_dt.Substring(0, 4) + "-" + date_pos_dt.Substring(4, 2) + "-" + date_pos_dt.Substring(6, 2);
                    bas_pos_dt.Text = date_pos_dt_print;
                }
                else
                {
                    bas_pos_dt.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_dut_dt"] as string != null)
                {
                    date_dut_dt = Row["bas_dut_dt"] as string;
                    date_dut_dt_print = date_dut_dt.Substring(0, 4) + "-" + date_dut_dt.Substring(4, 2) + "-" + date_dut_dt.Substring(6, 2);
                    bas_dut_dt.Text = date_dut_dt_print;
                }
                else
                {
                    bas_dut_dt.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_dept_dt"] as string != null)
                {
                    date_dept_dt = Row["bas_dept_dt"] as string;
                    date_dept_dt_print = date_dept_dt.Substring(0, 4) + "-" + date_dept_dt.Substring(4, 2) + "-" + date_dept_dt.Substring(6, 2);
                    bas_dept_dt.Text = date_dept_dt_print;
                }
                else
                {
                    bas_dept_dt.Format = DateTimePickerFormat.Custom;
                }

                if (Row["bas_intern_dt"] as string != null)
                {
                    date_intern_dt = Row["bas_intern_dt"] as string;
                    date_intern_dt_print = date_intern_dt.Substring(0, 4) + "-" + date_intern_dt.Substring(4, 2) + "-" + date_intern_dt.Substring(6, 2);
                    bas_intern_dt.Text = date_intern_dt_print;
                }
                else
                {
                    bas_intern_dt.Format = DateTimePickerFormat.Custom;
                }
                //if (bas_emp_sdate == "" || bas_emp_edate == "")
                //{

                //}
                //datetimepicker를 출력해주기위해 해야할 작업
                //1. 문자열 변수 생성
                //2. db로부터 불러온 값을 저장한 aa를 
                bas_empno.Text = Row["bas_empno"] as string;
                bas_resno.Text = Row["bas_resno"] as string;
                bas_name.Text = Row["bas_name"] as string;
                bas_cname.Text = Row["bas_cname"] as string;
                bas_ename.Text = Row["bas_ename"] as string;
                bas_fix.Text = Row["bas_fix"] as string;
                bas_zip.Text = Row["bas_zip"] as string;
                bas_addr.Text = Row["bas_addr"] as string;
                bas_residence.Text = Row["bas_residence"] as string;
                bas_hdpno.Text = Row["bas_hdpno"] as string;
                bas_telno.Text = Row["bas_telno"] as string;
                bas_email.Text = Row["bas_email"] as string;
                bas_mil_sta.Text = Row["bas_mil_sta"] as string;
                bas_mil_mil.Text = Row["bas_mil_mil"] as string;
                bas_mil_rnk.Text = Row["bas_mil_rnk"] as string;
                bas_mar = Row["bas_mar"] as string;
                bas_acc_bank1.Text = Row["bas_acc_bank1"] as string;
                bas_acc_name1.Text = Row["bas_acc_name1"] as string;
                bas_acc_no1.Text = Row["bas_acc_no1"] as string;
                bas_acc_bank2.Text = Row["bas_acc_bank2"] as string;
                bas_acc_name2.Text = Row["bas_acc_name2"] as string;
                bas_acc_no2.Text = Row["bas_acc_no2"] as string;
                bas_cont.Text = Row["bas_cont"] as string;
                bas_intern.Text = Row["bas_intern"] as string;
                bas_intern_no.Text = Row["bas_intern_no"] as string;
                bas_wsta.Text = Row["bas_wsta"] as string;
                bas_sts.Text = Row["bas_sts"] as string;
                bas_pos.Text = Row["bas_pos"] as string;
                bas_dut.Text = Row["bas_dut"] as string;
                bas_dept_code.Text = dept[0].ToString();
                bas_dept.Text = dept[1].ToString();
                bas_rmk.Text = Row["bas_rmk"] as string;

                aa = Row["bas_mar"] as string;

                if (aa == "기혼")
                {
                    bas_mar2.Checked = true;
                }
                else
                {
                    bas_mar1.Checked = true;
                }
            }
        }
        public void Btn_delete_clicked()
        {
            //button1.Text = "Form2(삭제버튼)";
            //this.textBox1.Text = MainForm.textBox1.Text;
        }

        public void Btn_check_clicked()
        {
            //button1.Text = "Form2(삭제버튼)";
            //this.textBox1.Text = MainForm.textBox1.Text;
        }

        public void Btn_cancel_clicked()
        {
            //button1.Text = "Form2(삭제버튼)";
            //this.textBox1.Text = MainForm.textBox1.Text;
        }

        private void TextboxClear()
        {
            bas_empno.Text = "";
            bas_resno.Text = "";
            bas_name.Text = "";
            bas_cname.Text = "";
            bas_ename.Text = "";
            bas_fix.Text = "";
            bas_zip.Text = "";
            bas_addr.Text = "";
            bas_residence.Text = "";
            bas_hdpno.Text = "";
            bas_telno.Text = "";
            bas_email.Text = "";
            bas_mil_sta.Text = "";
            bas_mil_mil.Text = "";
            bas_mil_rnk.Text = "";
            bas_acc_bank1.Text = "";
            bas_acc_name1.Text = "";
            bas_acc_no1.Text = "";
            bas_acc_bank2.Text = "";
            bas_acc_name2.Text = "";
            bas_acc_no2.Text = "";
            bas_cont.Text = "";
            bas_intern.Text = "";
            bas_intern_no.Text = "";
            bas_emp_sdate.Text = "";
            bas_emp_edate.Text = "";
            bas_entdate.Format = DateTimePickerFormat.Custom;
            bas_resdate.Format = DateTimePickerFormat.Custom;
            bas_levdate.Format = DateTimePickerFormat.Custom;
            bas_reidate.Format = DateTimePickerFormat.Custom;
            bas_wsta.Text = "";
            bas_sts.Text = "";
            bas_pos.Text = "";
            bas_dut.Text = "";
            bas_dept.Text = "";
            bas_dept_code.Text = "";
            bas_rmk.Text = "";
            bas_pos_dt.Format = DateTimePickerFormat.Custom;
            bas_dut_dt.Format = DateTimePickerFormat.Custom;
            bas_dept_dt.Format = DateTimePickerFormat.Custom;
            bas_intern_dt.Format = DateTimePickerFormat.Custom;
        }
        private void InsabaseEnableFalse()
        {
            bas_cname.Enabled = false;
            bas_hdpno.Enabled = false;
            bas_telno.Enabled = false;
            bas_name.Enabled = false;
            bas_ename.Enabled = false;
            bas_fix.Enabled = false;
            bas_email.Enabled = false;
            bas_mar1.Enabled = false;
            bas_mar2.Enabled = false;
            bas_resno.Enabled = false;
            bas_zip.Enabled = false;
            bas_addr.Enabled = false;
            bas_residence.Enabled = false;
            bas_dept.Enabled = false;
            bas_pos.Enabled = false;
            bas_dut.Enabled = false;
            bas_intern.Enabled = false;
            bas_intern_no.Enabled = false;
            bas_cont.Enabled = false;
            bas_sts.Enabled = false;
            bas_wsta.Enabled = false;
            bas_mil_sta.Enabled = false;
            bas_mil_rnk.Enabled = false;
            bas_mil_mil.Enabled = false;
            bas_acc_bank1.Enabled = false;
            bas_acc_name1.Enabled = false;
            bas_acc_no1.Enabled = false;
            bas_acc_bank2.Enabled = false;
            bas_acc_name2.Enabled = false;
            bas_acc_no2.Enabled = false;
            bas_rmk.Enabled = false;
            bas_pos_dt.Enabled = false;
            bas_dut_dt.Enabled = false;
            bas_dept_dt.Enabled = false;
            bas_dept_code.Enabled = false;
            bas_emp_sdate.Enabled = false;
            bas_emp_edate.Enabled = false;
            bas_intern_dt.Enabled = false;
            bas_entdate.Enabled = false;
            bas_levdate.Enabled = false;
            bas_reidate.Enabled = false;
            bas_resdate.Enabled = false;
            bas_zip_cdbt.Enabled = false;
            bas_zip_cdbt.BackColor = Color.LightGray;
            bas_dept_cdbt.Enabled = false;
            bas_dept_cdbt.BackColor = Color.LightGray;
        }
        private void InsabaseEnableTrue()
        {
            bas_cname.Enabled = true;
            bas_hdpno.Enabled = true;
            bas_telno.Enabled = true;
            bas_name.Enabled = true;
            bas_ename.Enabled = true;
            bas_email.Enabled = true;
            bas_fix.Enabled = true;
            bas_mar1.Enabled = true;
            bas_mar2.Enabled = true;
            bas_resno.Enabled = true;
            bas_zip.Enabled = true;
            bas_addr.Enabled = true;
            bas_residence.Enabled = true;
            bas_dept.Enabled = true;
            bas_pos.Enabled = true;
            bas_dut.Enabled = true;
            bas_intern.Enabled = true;
            bas_intern.Enabled = true;
            bas_cont.Enabled = true;
            bas_sts.Enabled = true;
            bas_wsta.Enabled = true;
            bas_mil_sta.Enabled = true;
            bas_mil_rnk.Enabled = true;
            bas_mil_mil.Enabled = true;
            bas_acc_bank1.Enabled = true;
            bas_acc_name1.Enabled = true;
            bas_acc_no1.Enabled = true;
            bas_acc_bank2.Enabled = true;
            bas_acc_name2.Enabled = true;
            bas_acc_no2.Enabled = true;
            bas_rmk.Enabled = true;
            bas_pos_dt.Enabled = true;
            bas_dut_dt.Enabled = true;
            bas_dept_dt.Enabled = true;
            bas_emp_sdate.Enabled = true;
            bas_emp_edate.Enabled = true;
            bas_intern_dt.Enabled = true;
            bas_entdate.Enabled = true;
            bas_levdate.Enabled = true;
            bas_reidate.Enabled = true;
            bas_resdate.Enabled = true;
            bas_zip_cdbt.Enabled = true;
            bas_dept_cdbt.Enabled = true;
        }

    }
}
