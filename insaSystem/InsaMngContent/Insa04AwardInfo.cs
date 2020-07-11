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
    public partial class Insa04AwardInfo : Form, IForm
    {
        DBOracle_Helper oHelper;
        public InsaManagement InsaManagement { get; set; }
        string BtnCheck = "";


        public Insa04AwardInfo()
        {
            InitializeComponent();
        }

        public void DataGridView_Double_clicked()
        {

        }

        private void TextboxClear()
        {
            award_organ.Text = "";
            award_pos.Text = "";
            award_dept.Text = "";
            award_inout.Text = "";
            award_no.Text = "";
            award_type.Text = "";
            award_content.Text = "";
            award_kind.Text = "";
            award_date.Format = DateTimePickerFormat.Custom;
        }

        public void Btn_insert_clicked()
        {
            if (bas_empno_award.Text == "")
            {
                MessageBox.Show("입력할 사원정보를 선택하세요");
            }
            else
            {
                TextboxClear();
                MessageBox.Show("상벌사항 입력을 시작합니다.");
                InsaManagement.btncheck.Text = "A_I";
                InsaManagement.Mode = "BlockIUD";
            }
        }

        private void CallingEmployeeAwdInfo()
        {
            if (bas_empno_award.Text == "")
            {
                MessageBox.Show("조회할 사원정보를 선택하세요");
                return;
            }
            InsaManagement.Mode = "BlockIUD";
            string awd_sql = "";//sql문 작성해야함
            DataTable AwdInfo = oHelper.GetData(awd_sql);
            foreach (DataRow Row in AwdInfo.Rows)
            {
                if (Row == null)
                {
                    MessageBox.Show("등록되어있지 않는 상벌정보입니다.");
                    return;
                }
                //불러들일 정보
            }
        }

        public void Btn_update_clicked()
        {
            CallingEmployeeAwdInfo();
            BtnCheck = "A_U";
        }

        public void Btn_delete_clicked()
        {
            CallingEmployeeAwdInfo();
            BtnCheck = "A_D";
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
            if (BtnCheck == "A_I")
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

            if (BtnCheck == "A_U")
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

            if (BtnCheck == "A_D")
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
