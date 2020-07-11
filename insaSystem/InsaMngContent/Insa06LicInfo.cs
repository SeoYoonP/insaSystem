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
    public partial class Insa06LicInfo : Form, IForm
    {
        DBOracle_Helper oHelper;
        public InsaManagement InsaManagement { get; set; }
        string BtnCheck = "";

        public Insa06LicInfo()
        {
            InitializeComponent();
        }

        public void DataGridView_Double_clicked()
        {

        }

        private void TextboxClear()
        {
            lic_code.Text = "";
            lic_grade.Text = "";
            lic_acqdate.Format = DateTimePickerFormat.Custom;
            lic_organ.Text = "";
        }

        public void Btn_insert_clicked()
        {
            if (bas_empno_lic.Text == "")
            {
                MessageBox.Show("입력할 사원정보를 선택하세요");
            }
            else
            {
                TextboxClear();
                MessageBox.Show("자격면허 입력을 시작합니다.");
                InsaManagement.btncheck.Text = "L_I";
                InsaManagement.Mode = "BlockIUD";
            }
        }

        private void CallingEmployeeLicInfo()
        {
            if (bas_empno_lic.Text == "")
            {
                MessageBox.Show("조회할 사원정보를 선택하세요");
                return;
            }
            InsaManagement.Mode = "BlockIUD";
            string lic_sql = "";//sql문 작성해야함
            DataTable LicInfo = oHelper.GetData(lic_sql);
            foreach (DataRow Row in LicInfo.Rows)
            {
                if (Row == null)
                {
                    MessageBox.Show("등록되어있지 않는 경력정보입니다.");
                    return;
                }
                //불러들일 정보
            }
        }

        public void Btn_update_clicked()
        {
            CallingEmployeeLicInfo();
            BtnCheck = "L_U";
        }

        public void Btn_delete_clicked()
        {
            CallingEmployeeLicInfo();
            BtnCheck = "L_D";
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
            if (BtnCheck == "L_I")
            {
                if (MessageBox.Show("취소하시면 입력하신 정보가 모두 저장되지 않습니다. 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //TextboxClear();
                    //InsabaseEnableFalse();
                    MessageBox.Show("취소되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    //bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                    return;
                }
                InsaManagement.Mode = "BlockCC";
            }

            if (BtnCheck == "L_U")
            {
                if (MessageBox.Show("수정을 취소합니다.", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //TextboxClear();
                    //InsabaseEnableFalse();
                    MessageBox.Show("취소되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    //bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                    return;
                }
                InsaManagement.Mode = "BlockCC";
            }

            if (BtnCheck == "L_D")
            {
                if (MessageBox.Show("데이터 삭제가 취소되었습니다 . 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //TextboxClear();
                    //InsabaseEnableFalse();
                    MessageBox.Show("취소되었습니다.");
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    //bas_empno.Focus();
                    InsaManagement.Mode = "BlockIUD";
                    return;
                }
                InsaManagement.Mode = "BlockCC";
            }
        }
    }
}
