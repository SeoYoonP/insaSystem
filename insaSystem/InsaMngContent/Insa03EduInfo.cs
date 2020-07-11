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
    public partial class Insa03EduInfo : Form, IForm
    {
        DBOracle_Helper oHelper;
        public InsaManagement InsaManagement { get; set; }
        string BtnCheck = "";

        public Insa03EduInfo()
        {
            InitializeComponent();
        }

        public void DataGridView_Double_clicked()
        {

        }

        public void Btn_insert_clicked()
        {
            if (bas_empno_edu.Text == "")
            {
                MessageBox.Show("입력할 사원정보를 선택하세요");
            }
            else
            {
                TextboxClear();
                MessageBox.Show("학력사항 입력을 시작합니다.");
                InsaManagement.btncheck.Text = "E_I";
                InsaManagement.Mode = "BlockIUD";
            }
        }

        private void CallingEmployeeEduInfo()
        {
            if(bas_empno_edu.Text == "")
            {
                MessageBox.Show("조회할 사원정보를 선택하세요");
                return;
            }
            InsaManagement.Mode = "BlockIUD";
            string edu_sql = "";//sql문 작성해야함
            DataTable EduInfo = oHelper.GetData(edu_sql);
            foreach(DataRow Row in EduInfo.Rows)
            {
                if(Row == null)
                {
                    MessageBox.Show("등록되어있지 않는 가족정보입니다.");
                    return;
                }
                //불러들일 정보
            }
        }

        public void Btn_update_clicked()
        {
            CallingEmployeeEduInfo();
            BtnCheck = "E_U";
        }

        public void Btn_delete_clicked()
        {
            CallingEmployeeEduInfo();
            BtnCheck = "E_U";
        }

        public void Btn_check_clicked()
        {
            
        }

        public void Btn_cancel_clicked()
        {
            if (BtnCheck == "E_I")
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

            if (BtnCheck == "E_U")
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

            if (BtnCheck == "E_D")
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

        private void TextboxClear()
        {
            edu_loe.Text = "";
            edu_schnm.Text = "";
            edu_dept.Text = "";
            edu_grade.Text = "";
            edu_degree.Text = "";
            edu_last.Text = "";
            edu_gra.Text = "";
            edu_entdate.Format = DateTimePickerFormat.Custom;
            edu_gradate.Format = DateTimePickerFormat.Custom;
        }
    }
}
