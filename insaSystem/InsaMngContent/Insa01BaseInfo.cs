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
        public InsaManagement InsaManagement { get; set; }
        string bas_mar = "";

        public Insa01BaseInfo()
        {
            InitializeComponent();
        }

        private void Insa01BaseInfo_Load(object sender, EventArgs e)
        {
            oHelper = new DBOracle_Helper();
            InsabaseEnableFalse();
        }

        public void Btn_insert_clicked()
        {
            TextboxClear();
            bas_empno.Focus();
            MessageBox.Show("인사기본사항 입력을 시작합니다.");

            //this.BackColor = Color.LightGray;
            //this.textBox1.Text = InsaManagement.textBox1.Text;
        }

        public void Btn_update_clicked()
        {
            CallingEmployeeInfo();
            BtnCheck.Text = "U";
            InsaManagement.btncheck.Text = this.BtnCheck.Text;
            //InsaManagement.Mode = "";

        }

        public void Btn_delete_clicked()
        {
            CallingEmployeeInfo();
            BtnCheck.Text = "D";
            InsabaseEnableFalse();
            InsaManagement.btncheck.Text = this.BtnCheck.Text;
            //InsaManagement.Mode = "";
        }

        public void Btn_check_clicked()
        {
            int num = 0;

            string result = bas_mil_mil.Text;
            string[] mil = result.Split(':');

            result = bas_mil_rnk.Text;
            string[] rnk = result.Split(':');

            result = bas_sts.Text;
            string[] sts = result.Split(':');

            result = bas_pos.Text;
            string[] pos = result.Split(':');

            result = bas_dut.Text;
            string[] dut = result.Split(':');

            result = bas_acc_bank1.Text;
            string[] bank1 = result.Split(':');

            result = bas_acc_bank2.Text;
            string[] bank2 = result.Split(':');

            result = bas_dept.Text;
            string[] dept = result.Split(':');

            if (InsaManagement.btncheck.Text == "U")
            {
                if (MessageBox.Show("수정하시겠습니까?", "수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ValidationChecking();
                    if (num == 1)
                    {
                        return;
                    }
                    if (bas_mar1.Checked == true)
                    {
                        bas_mar = "미혼";
                    }
                    else if (bas_mar2.Checked == true)
                    {
                        bas_mar = "기혼";
                    }
                    string SqlUpdate = $"update THRM_BAS_PSY set bas_empno='" + bas_empno.Text + "', bas_resno='"
                        + bas_resno.Text + "',bas_name='" + bas_name.Text + "',bas_cname='"
                        + bas_cname.Text + "',bas_ename='" + bas_ename.Text + "',bas_pos='"
                        + pos[0] + "',bas_dut='" + dut[0] + "',bas_cont='" +
                        bas_cont.Text + "',bas_intern='" + bas_intern.Text + "',bas_wsta='"
                        + bas_wsta.Text + "', bas_sts = '" + sts[0] + "',bas_zip='" + bas_zip.Text + "',bas_addr='" +
                        bas_addr.Text + "',bas_residence='" + bas_residence.Text + "',bas_email='" + bas_email.Text + "',bas_hdpno='"
                        + bas_hdpno.Text + "',bas_mil_mil='" + mil[0] + "',bas_telno='" + bas_telno.Text + "',bas_mil_sta='"
                        + bas_mil_sta.Text + "',bas_mil_rnk='" + rnk[0] + "',bas_acc_bank1='"
                        + bank1[0] + "',bas_acc_name1='" + bas_acc_name1.Text
                        + "',bas_acc_no1='" + bas_acc_no1.Text + "',bas_acc_bank2='" +
                        bank2[0] + "',bas_acc_name2='" + bas_acc_name2.Text +
                        "',bas_acc_no2='" + bas_acc_no2.Text + "',bas_rmk='" + bas_rmk.Text
                        + "',bas_fix='" + bas_fix.Text + "',bas_mar='" + bas_mar + "',bas_dept='" + bas_dept_code.Text
                        + "',bas_emp_sdate='" + bas_emp_sdate.Value.ToString("yyyyMMdd") + "'" +
                        ",bas_emp_edate='" + bas_emp_edate.Value.ToString("yyyyMMdd") +
                        "',bas_intern_dt='" + bas_intern_dt.Value.ToString("yyyyMMdd")
                        + "',bas_entdate='" + bas_entdate.Value.ToString("yyyyMMdd") +
                        "',bas_levdate='" + bas_levdate.Value.ToString("yyyyMMdd") +
                        "',bas_reidate='" + bas_reidate.Value.ToString("yyyyMMdd") + "'," +
                        "bas_resdate='" + bas_resdate.Value.ToString("yyyyMMdd") + "'" +
                        " where bas_empno='" + bas_empno.Text + "'";

                    oHelper.SetData(SqlUpdate);
                    TextboxClear();
                    InsabaseEnableFalse();
                    MessageBox.Show("수정되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    MessageBox.Show("수정이 취소되었습니다.");
                    InsaManagement.Mode = "BlockIUD";
                    return;

                }
            }

            if (InsaManagement.btncheck.Text == "D")
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string SqlDelete = $"delete from THRM_BAS_PSY where bas_empno='" + bas_empno.Text + "'";

                    oHelper.SetData(SqlDelete);

                    TextboxClear();
                    InsabaseEnableFalse();
                    MessageBox.Show("삭제되었습니다.");
                    InsaManagement.Mode = "BlockCC";

                }
                else
                {
                    MessageBox.Show("삭제가 취소되었습니다.");
                    bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                }
            }
        }

        public void Btn_cancel_clicked()
        {
            if (InsaManagement.btncheck.Text == "I")
            {
                if (MessageBox.Show("취소하시면 입력하신 정보가 모두 저장되지 않습니다. 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextboxClear();
                    InsabaseEnableFalse();
                    MessageBox.Show("취소되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                    return;
                }
                InsaManagement.Mode = "BlockCC";
            }

            if (InsaManagement.btncheck.Text == "U")
            {
                if (MessageBox.Show("수정을 취소합니다.", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextboxClear();
                    InsabaseEnableFalse();
                    MessageBox.Show("취소되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                    return;
                }
                InsaManagement.Mode = "BlockCC";
            }

            if (InsaManagement.btncheck.Text == "D")
            {
                if (MessageBox.Show("데이터 삭제가 취소되었습니다 . 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextboxClear();
                    InsabaseEnableFalse();
                    MessageBox.Show("취소되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                    return;
                }
                InsaManagement.Mode = "BlockCC";
            }
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
        private void CallingEmployeeInfo()
        {
            if (bas_empno.Text == "")
            {
                MessageBox.Show("사원번호를 입력하세요");
                bas_empno.Focus();
                InsabaseEnableFalse();
                return;
            }
            InsabaseEnableTrue();
            InsaManagement.Mode = "BlockIUD";

            string sabun_sql = "select bas_empno,bas_resno,bas_name,bas_cname,bas_ename,bas_fix,bas_zip,bas_addr,bas_residence,bas_hdpno,bas_telno,bas_email,bas_mil_sta,bas_mil_mil,bas_mil_rnk,bas_mar,bas_acc_bank1,bas_acc_name1,bas_acc_no1,bas_acc_bank2,bas_acc_name2,bas_acc_no2,bas_cont,bas_intern,bas_intern_no,bas_emp_sdate,bas_emp_edate,bas_entdate,bas_resdate,bas_levdate,bas_reidate,bas_wsta,(bas_sts ||':'|| cd_codnms) as bas_sts,(bas_pos ||':'|| pos_codnms) as bas_pos ,(bas_dut ||':'|| dut_codnms) as bas_dut, (bas_dept ||':'||dept_name) as bas_dept,bas_rmk,bas_pos_dt,bas_dut_dt,bas_dept_dt,bas_intern_dt from thrm_bas_psy,(select cd_code, cd_codnms from tieas_cd_psy where cd_grpcd = 'STS'),(select cd_code as pos_code, cd_codnms as pos_codnms from tieas_cd_psy where cd_grpcd = 'POS'),(select cd_code as dut_code, cd_codnms as dut_codnms from tieas_cd_psy where cd_grpcd = 'DUT'), thrm_dept_psy where bas_sts =cd_code and bas_pos =pos_code and bas_dut = dut_code(+) and bas_empno='" + bas_empno.Text + "'";

            DataTable SabunInfo = oHelper.GetData(sabun_sql);
            foreach (DataRow Row in SabunInfo.Rows)
            {
                if (Row == null)
                {
                    MessageBox.Show("등록되어있지 않는 사원번호입니다.");
                    return;
                }
                String date_emp_sdate, date_emp_sdate_print;
                String date_emp_edate, date_emp_edate_print;
                String date_entdate, date_entdate_print;
                String date_resdate, date_resdate_print;
                String date_levdate, date_levdate_print;
                String date_reidate, date_reidate_print;
                String date_pos_dt, date_pos_dt_print;
                String date_dut_dt, date_dut_dt_print;
                String date_dept_dt, date_dept_dt_print;
                String date_intern_dt, date_intern_dt_print;
                String aa;

                string putin = Row["bas_dept"].ToString();
                string[] dept = putin.Split(':');

                if (Row["bas_emp_sdate"] as string != null)
                {
                    date_emp_sdate = Row["bas_emp_sdate"] as string;
                    date_emp_sdate_print = date_emp_sdate.Substring(0, 4) + "-" + date_emp_sdate.Substring(4, 2) + "-" + date_emp_sdate.Substring(6, 2);
                    bas_emp_sdate.Text = date_emp_sdate_print;
                    MessageBox.Show(date_emp_sdate_print);
                }
                else
                {
                    bas_emp_sdate.Format = DateTimePickerFormat.Custom;
                    MessageBox.Show(bas_emp_sdate.ToString());
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
                continue;
            }
        }//수정필요

        private void ValidationChecking()
        {
            int num = 0;

            if (bas_empno.Text == "")
            {
                MessageBox.Show("사원번호를 입력하여주십시오.");
                num = 1;
                bas_empno.Focus();
                return;
            }
            else if (bas_resno.Text == "")
            {
                MessageBox.Show("주민등록번호를 입력하여주십시오.");
                num = 1;
                bas_resno.Focus();
                return;
            }
            else if (bas_name.Text == "")
            {
                MessageBox.Show("성명(한글)을 입력하여주십시오.");
                num = 1;
                bas_name.Focus();
                return;
            }
            else if (bas_cname.Text == "")
            {
                MessageBox.Show("성명(한자)을 입력하여주십시오.");
                num = 1;
                bas_cname.Focus();
                return;
            }
            else if (bas_ename.Text == "")
            {
                MessageBox.Show("성명(영어)을 입력하여주십시오.");
                num = 1;
                bas_ename.Focus();
                return;
            }
            else if (bas_hdpno.Text == "")
            {
                MessageBox.Show("연락처(휴대폰)를 입력하여주십시오.");
                num = 1;
                bas_hdpno.Focus();
                return;
            }
            else if (bas_telno.Text == "")
            {
                MessageBox.Show("연락처(집) 입력하여주십시오.");
                num = 1;
                bas_telno.Focus();
                return;
            }
            else if (bas_fix.Text == "")
            {
                MessageBox.Show("성별을 입력하여주십시오.");
                num = 1;
                bas_fix.Focus();
                return;
            }
            else if (bas_zip.Text == "")
            {
                MessageBox.Show("우편번호를 입력하여주십시오.");
                num = 1;
                bas_zip.Focus();
                return;
            }
            else if (bas_email.Text == "")
            {
                MessageBox.Show("이메일을 입력하여주십시오.");
                num = 1;
                bas_email.Focus();
                return;
            }
            else if (bas_addr.Text == "")
            {
                MessageBox.Show("주소를 입력하여주십시오.");
                num = 1;
                bas_addr.Focus();
                return;
            }
            else if (bas_sts.Text == "")
            {
                MessageBox.Show("신분구분을 입력하여주십시오.");
                num = 1;
                bas_sts.Focus();
                return;
            }
            else if (bas_pos.Text == "")
            {
                MessageBox.Show("직급(현재)을 입력하여주십시오.");
                num = 1;
                bas_pos.Focus();
                return;
            }
            else if (bas_dut.Text == "")
            {
                MessageBox.Show("직위(현재)를 입력하여주십시오.");
                num = 1;
                bas_resno.Focus();
                return;
            }
            else if (bas_dept.Text == "")
            {
                MessageBox.Show("부서(현재) 입력하여주십시오.");
                num = 1;
                bas_dept.Focus();
                return;
            }

            else if (bas_acc_bank1.Text == "")
            {
                MessageBox.Show("계좌사항(은행명)을 입력하여주십시오.");
                num = 1;
                bas_acc_bank1.Focus();
                return;
            }
            else if (bas_acc_name1.Text == "")
            {
                MessageBox.Show("계좌사항(예금주)을 입력하여주십시오.");
                num = 1;
                bas_acc_name1.Focus();
                return;
            }
            else if (bas_acc_no1.Text == "")
            {
                MessageBox.Show("틀림");
                MessageBox.Show("계좌사항(계좌번호) 입력하여주십시오.");
                num = 1;
                bas_acc_no1.Focus();
                return;
            }

            if (bas_cont.Text == "계약직")
            {
                DateTime bas_emp_sdate_call = bas_emp_sdate.Value;
                DateTime bas_emp_edate_call = bas_emp_edate.Value;
                int compareES = DateTime.Compare(bas_emp_sdate_call, bas_emp_edate_call);
                if (compareES >= 0)
                {
                    MessageBox.Show("계약종료일이 계약일보다 앞서거나 같습니다.");
                    bas_emp_edate.Focus();
                    num = 1;
                    return;
                }
            }
            num = 0;
        }

        #region 주민번호 13자리 체킹 & 주민번호 뒷자리 첫번째 숫자에 따른 성별 구분 함수 --인사기본사항
        //주민번호 13자리 체킹 & 주민번호 뒷자리 첫번째 숫자에 따른 성별 구분
        private void bas_resno_Leave(object sender, EventArgs e)
        {
            string bas_resno_div;
            string bas_resno_distinct;

            if (bas_resno.Text == "")
            {
                return;
            }
            if (bas_resno.Text.Length != 13)
            {
                MessageBox.Show("13자리가 아닙니다.");
                bas_resno.Focus();
                return;
            }

            bas_resno_div = bas_resno.Text;
            bas_resno_distinct = bas_resno_div.Substring(6, 1);

            if (bas_resno_distinct == "1" || bas_resno_distinct == "3")
            {
                bas_fix.Text = "남";
                bas_mil_sta.Enabled = true;
            }
            else if (bas_resno_distinct == "2" || bas_resno_distinct == "4")
            {
                bas_fix.Text = "여";
            }
            else
            {
                MessageBox.Show("주민번호를 다시 확인하여 주십시오.");
                bas_resno.Focus();
            }
        }
        #endregion
        #region 주소, 부서, 부서(사번) 검색창 -- 사번검색 및 인사기본사항
        private void bas_zip_cdbt_Click(object sender, EventArgs e)
        {
            search_address search_adr = new search_address(this);
            search_adr.ShowDialog();
        }

        public void tes(String tmp, String tmm)
        {
            bas_zip.Text = tmp;
            bas_addr.Text = tmm;
        }

        private void sabun_deptSearch_Click(object sender, EventArgs e)
        {
            SearchDeptForm frm2 = new SearchDeptForm(this);
            frm2.ShowDialog();
        }
        #endregion
        #region 부서, 주소 새창 띄우기 -- 인사기본사항
        public void jinguy(string j, string i)
        {
            //부서 새창
            bas_dept_code.Text = j;
            bas_dept.Text = i;
        }
        public void getAddress(string j, string i)
        {
            //주소 새창
            bas_zip.Text = j;
            bas_addr.Text = i;
        }
        #endregion
        #region 숫자만 입력하도록 제한하는 함수 - 주민번호, 핸드폰번호, 집전화번호, 사원번호 -- 인사기본사항
        //숫자만 입력하도록 제한
        private void bas_resno_keyPress(object sender, KeyPressEventArgs e)
        {
            keyPress_OnlyNumber(sender, e);
        }


        private void bas_hdpno_keyPress(object sender, KeyPressEventArgs e)
        {
            keyPress_OnlyNumber(sender, e);
        }

        private void bas_telno_keyPress(object sender, KeyPressEventArgs e)
        {
            keyPress_OnlyNumber(sender, e);
        }

        private void bas_empno_keyPress(object sender, KeyPressEventArgs e)
        {
            keyPress_OnlyNumber(sender, e);
        }

        private void keyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bas_cont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bas_mil_sta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bas_wsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bas_intern_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bas_dept_cdbt_Click(object sender, EventArgs e)
        {
            SearchDeptForm frm2 = new SearchDeptForm(this);
            frm2.ShowDialog();
        }
        #endregion
        #region 인사기본사항 Textbox 상태 변화 함수 -- 인사기본사항
        //계약직, 정규직 선택에 따른 연관된 Textbox 상태 변화 함수
        private void bas_cont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_cont.Text == "계약직")
            {

                bas_intern.Enabled = false;
                bas_dut.Enabled = false;
                bas_dut.Text = "";
                bas_intern.Text = "";
                bas_intern_no.Text = "";
                bas_emp_edate.Enabled = true;
                bas_emp_sdate.Enabled = true;
                bas_pos_dt.Enabled = true;
                bas_entdate.Enabled = true;
                bas_dut_dt.Enabled = false;
                bas_dept_dt.Enabled = true;
                bas_intern_dt.Enabled = false;
                bas_resdate.Enabled = false;
                bas_levdate.Enabled = false;
                bas_reidate.Enabled = false;
                bas_emp_edate.Format = DateTimePickerFormat.Short;
                bas_emp_sdate.Format = DateTimePickerFormat.Short;

                bas_pos_dt.Format = DateTimePickerFormat.Short;
                bas_dut_dt.Format = DateTimePickerFormat.Custom;
                bas_dept_dt.Format = DateTimePickerFormat.Short;
                bas_intern_dt.Format = DateTimePickerFormat.Custom;
                bas_resdate.Format = DateTimePickerFormat.Custom;
                bas_levdate.Format = DateTimePickerFormat.Custom;
                bas_reidate.Format = DateTimePickerFormat.Custom;

            }
            else if (bas_cont.Text == "정규직")
            {
                bas_emp_edate.Enabled = false;
                bas_emp_sdate.Enabled = false;
                bas_intern.Enabled = true;
                bas_pos_dt.Enabled = true;
                bas_dut_dt.Enabled = true;
                bas_dept_dt.Enabled = true;
                bas_intern_dt.Enabled = true;
                bas_entdate.Enabled = true;

                bas_pos_dt.Format = DateTimePickerFormat.Short;
                bas_dut_dt.Format = DateTimePickerFormat.Short;
                bas_dept_dt.Format = DateTimePickerFormat.Short;
                bas_intern_dt.Format = DateTimePickerFormat.Short;
                bas_entdate.Format = DateTimePickerFormat.Short;
                bas_emp_sdate.Format = DateTimePickerFormat.Custom;
                bas_emp_edate.Format = DateTimePickerFormat.Custom;
            }
        }

        //군대관련 복무일경우와 아닐경우의 textbox enable 변화
        private void bas_mil_sta_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (bas_mil_sta.Text == "복무")
            {
                bas_mil_mil.Enabled = true;
                bas_mil_rnk.Enabled = true;
            }
            else if (bas_mil_sta.Text != "복무")
            {
                bas_mil_mil.Text = "";
                bas_mil_mil.Enabled = false;
                bas_mil_rnk.Text = "";
                bas_mil_rnk.Enabled = false;
            }
        }
        //수습/인턴 선택에따른 개월수 변화 함수
        private void bas_intern_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (bas_intern.Text == "수습")
            {
                bas_intern_no.Text = "3";
            }
            else if (bas_intern.Text == "인턴")
            {
                bas_intern_no.Text = "9";
            }
        }

        // 재직과 무직의 선택에 따른 Textbox enable변화 함수
        private void bas_wsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_wsta.Text == "재직")
            {
                bas_pos_dt.Enabled = true;
                bas_dut_dt.Enabled = true;
                bas_dept_dt.Enabled = true;
                bas_intern_dt.Enabled = true;
                bas_entdate.Enabled = true;
            }
            else if (bas_wsta.Text == "무직")
            {
                bas_levdate.Enabled = true;
                bas_reidate.Enabled = true;
            }
            else if (bas_wsta.Text == "퇴직")
            {
                bas_resdate.Enabled = true;
            }
        }

        //성별이 여성에 따른 textbox enable 변화 함수
        private void bas_fix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_fix.Text == "여")
            {
                bas_mil_sta.Text = "";
                bas_mil_sta.Enabled = false;
                bas_mil_mil.Text = "";
                bas_mil_mil.Enabled = false;
                bas_mil_rnk.Text = "";
                bas_mil_rnk.Enabled = false;
            }
        }
        #endregion
    }
}
