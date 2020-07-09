using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;


namespace insaSystem
{
    public partial class SearchDeptForm : Form
    {
        OracleConnection pgOraConn;
        OracleCommand pgOraCmd;
        OracleDataReader rd;
        SqlDataAdapter adapter = null;
        SqlConnection conn = null;
        String dbIp = "222.237.134.74";
        String dbName = "ORA7";
        String dbId = "EDU";
        String dbPw = "edu1234";
        Insa01BaseInfo frm1;

        #region 나가기, 최대화, 리스토어, 최소화 Btn Control
        //-----------나가기----------
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------최소화----------
        private void minimizarbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        public SearchDeptForm(Insa01BaseInfo frm2)
        {
            InitializeComponent();
            frm1 = frm2;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            dataGridView1.RowHeadersVisible = false;
            pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
            pgOraConn.Open();
        }

        private void deptSearch_Click(object sender, EventArgs e)
        {
            var sql = "select dept_code, dept_name from thrm_dept_psy where dept_edate is null and dept_name like '" + idept.Text + "%'";
            //MessageBox.Show(sql);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pgOraConn;
            cmd.CommandText = sql;
            OracleDataReader rd = cmd.ExecuteReader();

            int cnt = 0;
            while (rd.Read())
            {
                //MessageBox.Show(rd["bas_empno"].ToString());
                dataGridView1.Rows.Add(rd["dept_code"].ToString(), rd["dept_name"].ToString());
                cnt++;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.Columns.Add("dept_code", "부서코드");
            dataGridView1.Columns.Add("dept_name", "부서명");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tmp1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var tmp2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm1.jinguy(tmp1, tmp2);
            Close();
        }


    }
}
