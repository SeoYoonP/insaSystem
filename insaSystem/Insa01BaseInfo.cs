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

        public void Btn_update_clicked()
        {
            //button1.Text = "Form2(조회버튼)";
            //this.textBox1.Text = MainForm.textBox1.Text;
        }
        public void Btn_insert_clicked()
        {
            //button1.Text = "Form2(입력버튼)";
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
    }
}
