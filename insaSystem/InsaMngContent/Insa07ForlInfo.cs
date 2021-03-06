﻿using DB_Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaSystem
{
    public partial class Insa07ForlInfo : Form, IForm
    {
        DBOracle_Helper oHelper;
        public InsaManagement InsaManagement { get; set; }
        string BtnCheck = "";

        public Insa07ForlInfo()
        {
            InitializeComponent();
        }

        public void DataGridView_Double_clicked()
        {

        }

        private void TextboxClear()
        {
            forl_code.Text = "";
            forl_score.Text = "";
            forl_acqdate.Format = DateTimePickerFormat.Custom;
            forl_organ.Text = "";

        }

        public void Btn_insert_clicked()
        {
            if (bas_empno_forl.Text == "")
            {
                MessageBox.Show("입력할 사원정보를 선택하세요");
            }
            else
            {
                TextboxClear();
                MessageBox.Show("외국어 입력을 시작합니다.");
                InsaManagement.btncheck.Text = "Fo_I";
                InsaManagement.Mode = "BlockIUD";
            }
        }

        private void CallingEmployeeForlInfo()
        {
            if (bas_empno_forl.Text == "")
            {
                MessageBox.Show("조회할 사원정보를 선택하세요");
                return;
            }
            InsaManagement.Mode = "BlockIUD";
            string forl_sql = "";//sql문 작성해야함
            DataTable ForlInfo = oHelper.GetData(forl_sql);
            foreach (DataRow Row in ForlInfo.Rows)
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
            CallingEmployeeForlInfo();
            BtnCheck = "Fo_U";
        }

        public void Btn_delete_clicked()
        {
            CallingEmployeeForlInfo();
            BtnCheck = "Fo_D";
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
            if (BtnCheck == "Fo_I")
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

            if (BtnCheck == "Fo_U")
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

            if (BtnCheck == "Fo_D")
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
