﻿using DB_Helper;
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
    public partial class Insa02FamInfo : Form, IForm
    {
        DBOracle_Helper oHelper;
        public InsaManagement InsaManagement { get; set; }
        string BtnCheck = "";
        public Insa02FamInfo()
        {
            InitializeComponent();
        }

        public void DataGridView_Double_clicked()
        {

        }

        public void Btn_insert_clicked()
        {
            if (bas_empno_fam.Text == "")
            {
                MessageBox.Show("입력할 사원정보를 선택하세요");
                return;
            }
            else
            {
                fam_rel.Focus();
                MessageBox.Show("가족정보 입력을 시작합니다.");

                fam_rel.Text = "";
                fam_name.Text = "";
                fam_bth.Text = "";
                fam_ltg.Text = "";
                fam_rel.Enabled = true;
                fam_name.Enabled = true;

                InsaManagement.btncheck.Text = "F_I";
                InsaManagement.Mode = "BlockIUD";
            }
        }

        private void CallingEmployeeFamInfo()
        {
            if (bas_empno_fam.Text == "")
            {
                MessageBox.Show("조회할 사원정보를 선택하세요");
                //enablefalse 들어가야함

                return;
            }
            InsaManagement.Mode = "BlockIUD";
            string fam_sql = "select fam_empno, fam_codnms as fam_rel, fam_name, fam_bth, fam_ltg" +
                           " from  thrm_bas_psy,       " +
                           "       thrm_fam_psy," +
                           "       (select cd_grpcd, cd_code, cd_codnms as fam_codnms " +
                           "       from  tieas_cd_psy where cd_grpcd = 'REL') " +
                           " where bas_empno = fam_empno(+) and fam_rel = cd_code" +
                           " and bas_empno = '" + bas_empno_fam.Text + "'";

            DataTable FamInfo = oHelper.GetData(fam_sql);
            foreach (DataRow Row in FamInfo.Rows)
            {
                if (Row == null)
                {
                    MessageBox.Show("등록되어있지 않는 가족정보입니다.");
                    return;
                }

                bas_empno_fam.Text = Row["fam_empno"] as string;
                fam_rel_code.Text = Row["fam_rel"] as string;
                fam_name.Text = Row["fam_name"] as string;
                fam_bth.Text = Row["fam_bth"] as string;
                fam_ltg.Text = Row["fam_ltg"] as string;
            }
        }

        public void Btn_update_clicked()
        {
            CallingEmployeeFamInfo();
            BtnCheck = "F_U";
        }

        public void Btn_delete_clicked()
        {
            CallingEmployeeFamInfo();
            BtnCheck = "F_D";
        }

        public void Btn_check_clicked()
        {
            if (BtnCheck == "F_I")
            {
                int num = 0;
                if (MessageBox.Show("입력된 가족사항을 저장하시겠습니까?", "가족사항", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //informationChecking();
                    if (num == 1)
                    {
                        return;
                    }

                    string SqlInsert = $"insert into THRM_FAM_PSY(fam_empno, fam_rel, fam_name, fam_bth, fam_ltg) values('" + bas_empno_fam.Text + "','" + fam_rel_code.Text + "','" + fam_name.Text + "', '" + fam_bth.Text + "','" + fam_ltg.Text + "')";

                    oHelper.SetData(SqlInsert);
                    InsaManagement.Mode = "BlockCC";
                }
                else
                {
                    fam_bth.Focus();
                    //_falseTrue_Checking();
                    //checkCancelClose();
                    InsaManagement.Mode = "BlockIUD";
                }

                if (BtnCheck == "F_U")
                {
                    if (MessageBox.Show("수정하시겠습니까?", "수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string SqlUpdate = $"update THRM_FAM_PSY set fam_bth='" + fam_bth.Text + "',fam_ltg='" + fam_ltg.Text + "' where fam_empno ='" + bas_empno_fam.Text + "' and fam_name= '" + fam_name.Text + "'";
                        //MessageBox.Show(sql1);

                        oHelper.SetData(SqlUpdate);

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
                if (BtnCheck == "F_D")
                {
                    if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string SqlDelete = $"delete from THRM_BAS_PSY where fam_empno='" + bas_empno_fam.Text + "'";

                        oHelper.SetData(SqlDelete);

                        TextboxClear();
                        //InsabaseEnableFalse();
                        MessageBox.Show("삭제되었습니다.");
                        InsaManagement.Mode = "BlockCC";
                    }
                    else
                    {
                        MessageBox.Show("삭제가 취소되었습니다.");
                        fam_bth.Focus();
                        InsaManagement.Mode = "BlockIUD";
                    }

                }
            }
        }
        public void Btn_cancel_clicked()
        {
            if (InsaManagement.btncheck.Text == "F_I")
            {
                if (MessageBox.Show("취소하시면 입력하신 정보가 모두 저장되지 않습니다. 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextboxClear();
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

            if (InsaManagement.btncheck.Text == "F_U")
            {
                if (MessageBox.Show("수정을 취소합니다.", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextboxClear();
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

            if (InsaManagement.btncheck.Text == "F_D")
            {
                if (MessageBox.Show("데이터 삭제가 취소되었습니다 . 취소하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TextboxClear();
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
            fam_rel.Text = "";
            fam_rel_code.Text = "";
            fam_name.Text = "";
            fam_bth.Text = "";
            fam_ltg.Text = "";
        }
    }
}
