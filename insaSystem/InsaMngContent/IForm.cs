using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insaSystem
{
    public interface IForm
    {
        InsaManagement MainForm { get; set; }
        //void Btn_query_clicked();
        void Btn_insert_clicked();
        void Btn_update_clicked();
        void Btn_delete_clicked();
        void Btn_check_clicked();
        void Btn_cancel_clicked();
    }
}
