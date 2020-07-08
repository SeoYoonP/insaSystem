using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Helper;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using System.Windows.Forms;

namespace insaSystem
{
    class LoginHandler
    {
        DBOracle_Helper oHelper;

        public bool LoginCheck(string id, string password)
        {
            try
            {
                oHelper = new DBOracle_Helper();
                {
                    string sql = "select login_empno, login_password from thrm_login_psy where login_empno = '"+ id + "' and login_password = '" + password + "'";
                    DataTable loginInfo = oHelper.GetData(sql);
                    using (DataTableReader reader = new DataTableReader(loginInfo))
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
