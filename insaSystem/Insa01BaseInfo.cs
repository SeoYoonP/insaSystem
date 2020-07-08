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
            //button1.Text = "Form2(조회버튼)";
            //this.textBox1.Text = MainForm.textBox1.Text;
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
