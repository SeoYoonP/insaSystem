using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml;
using System.Net;
using System.Text;

namespace insaSystem
{
    public partial class search_address : Form
    {
        int num;
        string fix;
        string mar;
        String dbIp = "222.237.134.74";
        String dbName = "ORA7";
        String dbId = "EDU";
        String dbPw = "edu1234";
        string currentPage = "1";  //현재 페이지
        string countPerPage = "1000"; //1페이지당 출력 갯수
        string confmKey = "blhB6TxTm5tJXZS42FMbAIJIL%2BeE1YGrassPaIlyFoOs3eAnuo2FxrsszouUj0acoFswQIEuiF%2FF8zjjFt656g%3D%3D"; //테스트 Key
        string keyword = string.Empty;
        string apiurl = string.Empty;
        int count = 1;
        Insa01BaseInfo ff;



        public search_address(Insa01BaseInfo fm)
        {
            InitializeComponent();
            ff = fm;
        }

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

        public Insa01BaseInfo fom;


        private void search_Click(object sender, EventArgs e)
        {
            if (addresstxt.Text == "")
            {
                MessageBox.Show("찾으시려는 동/읍/면을 먼저 입력해주세요");
                return;
            }
            List<string> tm = new List<string>();
            int tma;
            DataTable table = new DataTable();
            table.Columns.Add("우편번호", typeof(String));
            table.Columns.Add("도로명주소", typeof(String));
            table.Columns.Add("지번주소", typeof(String));
            Find(addresstxt.Text, 1, 50, tm, out tma);
            int i = 0;
            while (i * 3 < 50)
            {
                i++;
                try
                {
                    table.Rows.Add(tm[i * 3 + 0], tm[i * 3 + 1], tm[i * 3 + 2]);
                }
                catch (Exception e1)
                {

                }
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        //* 공공데이터포털(http://www.data.go.kr) 오픈 API 이용
        // [in] s : 검색어 (도로명주소[도로명/건물명] 또는 지번주소[동/읍/면/리])
        // [in] p : 읽어올 페이지(1부터), l : 한 페이지당 출력할 목록 수(최대 50까지)
        // [out] v[i*3 +0]=우편번호, v[i*3 +1]=도로명주소, v[i*3 +2]=지번주소, v.Count/3=표시할 목록 수
        // [out] n : 검색한 전체 목록(우편번호) 개수
        // 반환값 : 에러메시지, null == OK

        public static string Find(string s, int p, int l, List<string> v, out int n)
        {
            n = 0;
            try
            {
                HttpWebRequest rq = (HttpWebRequest)WebRequest.Create(
                    "http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdSearchAllService/retrieveNewAdressAreaCdSearchAllService/getNewAddressListAreaCdSearchAll"
                    + "?ServiceKey=blhB6TxTm5tJXZS42FMbAIJIL%2BeE1YGrassPaIlyFoOs3eAnuo2FxrsszouUj0acoFswQIEuiF%2FF8zjjFt656g%3D%3D" // 서비스키
                    + "&countPerPage=" + l // 페이지당 출력될 개수를 지정(최대 50)
                    + "&currentPage=" + p // 출력될 페이지 번호
                    + "&srchwrd=" + HttpUtility.UrlPathEncode(s) // 검색어
                    );
                rq.Headers = new WebHeaderCollection();
                rq.Headers.Add("Accept-language", "ko");
                bool bOk = false; // <successYN>Y</successYN> 획득 여부
                s = null; // 에러 메시지
                HttpWebResponse rp = (HttpWebResponse)rq.GetResponse();
                XmlTextReader r = new XmlTextReader(rp.GetResponseStream());
                while (r.Read())
                {
                    if (r.NodeType == XmlNodeType.Element)
                    {
                        if (bOk)
                        {
                            if (r.Name == "zipNo" || // 우편번호
                                r.Name == "lnmAdres" || // 도로명 주소
                                r.Name == "rnAdres") // 지번 주소
                            {
                                v.Add(r.ReadString());
                            }
                            else if (r.Name == "totalCount") // 전체 검색수
                            {
                                int.TryParse(r.ReadString(), out n);
                            }
                        }
                        else
                        {
                            if (r.Name == "successYN")
                            {
                                if (r.ReadString() == "Y") bOk = true; // 검색 성공
                            }
                            else if (r.Name == "errMsg") // 에러 메시지
                            {
                                s = r.ReadString();
                                break;
                            }
                        }
                    }
                }
                r.Close();
                rp.Close();

                if (s == null)
                { // OK!
                    if (v.Count < 3)
                        s = "검색결과가 없습니다.";
                }
            }
            catch (Exception e)
            {
                s = e.Message;
            }
            return s;
        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                return;
            }
            else
            {
                count--;
            }
            List<string> tm = new List<string>();
            int tma;
            DataTable table = new DataTable();
            table.Columns.Add("우편번호", typeof(String));
            table.Columns.Add("도로명주소", typeof(String));
            table.Columns.Add("지번주소", typeof(String));
            Find(addresstxt.Text, count, 50, tm, out tma);
            int i = 0;
            while (i * 3 < 50)
            {
                i++;
                try
                {
                    table.Rows.Add(tm[i * 3 + 0], tm[i * 3 + 1], tm[i * 3 + 2]);
                }
                catch (Exception e2)
                {

                }
            }
            dataGridView1.DataSource = table;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            count++;
            List<string> tm = new List<string>();
            int tma;
            DataTable table = new DataTable();
            table.Columns.Add("우편번호", typeof(String));
            table.Columns.Add("도로명주소", typeof(String));
            table.Columns.Add("지번주소", typeof(String));
            Find(addresstxt.Text, count, 50, tm, out tma);
            int i = 0;
            while (i * 3 < 50)
            {
                i++;
                try
                {
                    table.Rows.Add(tm[i * 3 + 0], tm[i * 3 + 1], tm[i * 3 + 2]);
                }
                catch (Exception e1)
                {

                }
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var adr_data1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var adr_data2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ff.getAddress(adr_data1, adr_data2);
            Close();
        }

        private void search_address_Load(object sender, EventArgs e)
        {

        }
    }

}
