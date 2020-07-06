namespace insaSystem
{
    partial class InsaManagement
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsaManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.insa_search = new System.Windows.Forms.GroupBox();
            this.insaSearch = new System.Windows.Forms.Button();
            this.qry_empno = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.qry_name = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.sabun_deptSearch = new System.Windows.Forms.Button();
            this.qry_dept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.sabunDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label45 = new System.Windows.Forms.Label();
            this.minimizarbtn = new System.Windows.Forms.PictureBox();
            this.btncheck = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.checkbtn = new System.Windows.Forms.Button();
            this.maximizarbtn = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.PictureBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.restorebtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.insertbtnElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.updateElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.deleteElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.checkElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cancelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.insa_search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sabunDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorebtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // insa_search
            // 
            this.insa_search.Controls.Add(this.insaSearch);
            this.insa_search.Controls.Add(this.qry_empno);
            this.insa_search.Controls.Add(this.label44);
            this.insa_search.Controls.Add(this.qry_name);
            this.insa_search.Controls.Add(this.lable2);
            this.insa_search.Controls.Add(this.sabun_deptSearch);
            this.insa_search.Controls.Add(this.qry_dept);
            this.insa_search.Controls.Add(this.label1);
            this.insa_search.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insa_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insa_search.Location = new System.Drawing.Point(5, 6);
            this.insa_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insa_search.Name = "insa_search";
            this.insa_search.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insa_search.Size = new System.Drawing.Size(461, 72);
            this.insa_search.TabIndex = 2;
            this.insa_search.TabStop = false;
            this.insa_search.Text = "사원검색";
            // 
            // insaSearch
            // 
            this.insaSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insaSearch.BackColor = System.Drawing.Color.Transparent;
            this.insaSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insaSearch.FlatAppearance.BorderSize = 0;
            this.insaSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insaSearch.ForeColor = System.Drawing.Color.Black;
            this.insaSearch.Image = ((System.Drawing.Image)(resources.GetObject("insaSearch.Image")));
            this.insaSearch.Location = new System.Drawing.Point(408, 24);
            this.insaSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insaSearch.Name = "insaSearch";
            this.insaSearch.Size = new System.Drawing.Size(45, 40);
            this.insaSearch.TabIndex = 1003;
            this.insaSearch.TabStop = false;
            this.insaSearch.UseVisualStyleBackColor = false;
            this.insaSearch.Click += new System.EventHandler(this.insaSearch_Click);
            // 
            // qry_empno
            // 
            this.qry_empno.Location = new System.Drawing.Point(61, 28);
            this.qry_empno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qry_empno.Name = "qry_empno";
            this.qry_empno.Size = new System.Drawing.Size(65, 29);
            this.qry_empno.TabIndex = 3;
            this.qry_empno.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(18, 32);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 23);
            this.label44.TabIndex = 7;
            this.label44.Text = "사번";
            // 
            // qry_name
            // 
            this.qry_name.Location = new System.Drawing.Point(183, 29);
            this.qry_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qry_name.Name = "qry_name";
            this.qry_name.Size = new System.Drawing.Size(61, 29);
            this.qry_name.TabIndex = 6;
            this.qry_name.TabStop = false;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(141, 34);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(44, 23);
            this.lable2.TabIndex = 5;
            this.lable2.Text = "이름";
            // 
            // sabun_deptSearch
            // 
            this.sabun_deptSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sabun_deptSearch.BackColor = System.Drawing.Color.White;
            this.sabun_deptSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sabun_deptSearch.FlatAppearance.BorderSize = 0;
            this.sabun_deptSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sabun_deptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sabun_deptSearch.ForeColor = System.Drawing.Color.Black;
            this.sabun_deptSearch.Image = ((System.Drawing.Image)(resources.GetObject("sabun_deptSearch.Image")));
            this.sabun_deptSearch.Location = new System.Drawing.Point(373, 30);
            this.sabun_deptSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sabun_deptSearch.Name = "sabun_deptSearch";
            this.sabun_deptSearch.Size = new System.Drawing.Size(27, 26);
            this.sabun_deptSearch.TabIndex = 1002;
            this.sabun_deptSearch.TabStop = false;
            this.sabun_deptSearch.UseVisualStyleBackColor = false;
            // 
            // qry_dept
            // 
            this.qry_dept.Location = new System.Drawing.Point(299, 29);
            this.qry_dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qry_dept.Name = "qry_dept";
            this.qry_dept.Size = new System.Drawing.Size(102, 29);
            this.qry_dept.TabIndex = 8;
            this.qry_dept.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "부서";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.sabunDataGridView);
            this.panel1.Controls.Add(this.insa_search);
            this.panel1.Location = new System.Drawing.Point(1, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 955);
            this.panel1.TabIndex = 34;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(472, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(848, 922);
            this.tabControl1.TabIndex = 21;
            // 
            // sabunDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sabunDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sabunDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sabunDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.sabunDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sabunDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sabunDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sabunDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sabunDataGridView.ColumnHeadersHeight = 30;
            this.sabunDataGridView.DoubleBuffered = true;
            this.sabunDataGridView.EnableHeadersVisualStyles = false;
            this.sabunDataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            this.sabunDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.sabunDataGridView.Location = new System.Drawing.Point(6, 87);
            this.sabunDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sabunDataGridView.Name = "sabunDataGridView";
            this.sabunDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sabunDataGridView.RowHeadersWidth = 51;
            this.sabunDataGridView.RowTemplate.Height = 23;
            this.sabunDataGridView.Size = new System.Drawing.Size(461, 854);
            this.sabunDataGridView.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(9, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 35);
            this.button2.TabIndex = 33;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.Location = new System.Drawing.Point(1165, 48);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(51, 45);
            this.deletebtn.TabIndex = 29;
            this.deletebtn.TabStop = false;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.White;
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updatebtn.ForeColor = System.Drawing.Color.Black;
            this.updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("updatebtn.Image")));
            this.updatebtn.Location = new System.Drawing.Point(1107, 50);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(51, 45);
            this.updatebtn.TabIndex = 28;
            this.updatebtn.TabStop = false;
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1225, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1012;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.minimizarbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1261, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1010;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.maximizarbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1294, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1009;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1261, 8);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1011;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.restorebtn_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.Location = new System.Drawing.Point(35, 12);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(99, 20);
            this.label45.TabIndex = 1001;
            this.label45.Text = "인사기록관리";
            // 
            // minimizarbtn
            // 
            this.minimizarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarbtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizarbtn.Image")));
            this.minimizarbtn.Location = new System.Drawing.Point(1543, 11);
            this.minimizarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizarbtn.Name = "minimizarbtn";
            this.minimizarbtn.Size = new System.Drawing.Size(27, 28);
            this.minimizarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarbtn.TabIndex = 1008;
            this.minimizarbtn.TabStop = false;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(1006, 62);
            this.btncheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(36, 25);
            this.btncheck.TabIndex = 32;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.White;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelbtn.Image")));
            this.cancelbtn.Location = new System.Drawing.Point(1279, 48);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(51, 45);
            this.cancelbtn.TabIndex = 31;
            this.cancelbtn.TabStop = false;
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // checkbtn
            // 
            this.checkbtn.BackColor = System.Drawing.Color.White;
            this.checkbtn.FlatAppearance.BorderSize = 0;
            this.checkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkbtn.Image = ((System.Drawing.Image)(resources.GetObject("checkbtn.Image")));
            this.checkbtn.Location = new System.Drawing.Point(1222, 48);
            this.checkbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(51, 45);
            this.checkbtn.TabIndex = 30;
            this.checkbtn.TabStop = false;
            this.checkbtn.UseVisualStyleBackColor = false;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // maximizarbtn
            // 
            this.maximizarbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarbtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizarbtn.Image")));
            this.maximizarbtn.Location = new System.Drawing.Point(1587, 11);
            this.maximizarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximizarbtn.Name = "maximizarbtn";
            this.maximizarbtn.Size = new System.Drawing.Size(27, 28);
            this.maximizarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizarbtn.TabIndex = 1006;
            this.maximizarbtn.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.Location = new System.Drawing.Point(1629, 11);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(27, 28);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbtn.TabIndex = 1005;
            this.exitbtn.TabStop = false;
            // 
            // insertbtn
            // 
            this.insertbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertbtn.BackColor = System.Drawing.Color.White;
            this.insertbtn.FlatAppearance.BorderSize = 0;
            this.insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insertbtn.ForeColor = System.Drawing.Color.Black;
            this.insertbtn.Image = ((System.Drawing.Image)(resources.GetObject("insertbtn.Image")));
            this.insertbtn.Location = new System.Drawing.Point(1049, 50);
            this.insertbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(51, 45);
            this.insertbtn.TabIndex = 27;
            this.insertbtn.TabStop = false;
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(7, 2);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 38);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 1004;
            this.pictureBox10.TabStop = false;
            // 
            // restorebtn
            // 
            this.restorebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restorebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restorebtn.Image = ((System.Drawing.Image)(resources.GetObject("restorebtn.Image")));
            this.restorebtn.Location = new System.Drawing.Point(1587, 11);
            this.restorebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(27, 28);
            this.restorebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restorebtn.TabIndex = 1007;
            this.restorebtn.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label45);
            this.panel2.Controls.Add(this.minimizarbtn);
            this.panel2.Controls.Add(this.maximizarbtn);
            this.panel2.Controls.Add(this.exitbtn);
            this.panel2.Controls.Add(this.restorebtn);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 44);
            this.panel2.TabIndex = 26;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.sabunDataGridView;
            // 
            // insertbtnElipse
            // 
            this.insertbtnElipse.ElipseRadius = 30;
            this.insertbtnElipse.TargetControl = this.insertbtn;
            // 
            // updateElipse
            // 
            this.updateElipse.ElipseRadius = 25;
            this.updateElipse.TargetControl = this.updatebtn;
            // 
            // deleteElipse
            // 
            this.deleteElipse.ElipseRadius = 25;
            this.deleteElipse.TargetControl = this.deletebtn;
            // 
            // checkElipse
            // 
            this.checkElipse.ElipseRadius = 25;
            this.checkElipse.TargetControl = this.checkbtn;
            // 
            // cancelElipse
            // 
            this.cancelElipse.ElipseRadius = 25;
            this.cancelElipse.TargetControl = this.cancelbtn;
            // 
            // InsaManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1334, 1064);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InsaManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InsaMangement_Load);
            this.insa_search.ResumeLayout(false);
            this.insa_search.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sabunDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restorebtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox insa_search;
        private System.Windows.Forms.Button insaSearch;
        private System.Windows.Forms.Button sabun_deptSearch;
        private System.Windows.Forms.TextBox qry_empno;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox qry_dept;
        private System.Windows.Forms.TextBox qry_name;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.PictureBox minimizarbtn;
        private System.Windows.Forms.TextBox btncheck;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.PictureBox maximizarbtn;
        private System.Windows.Forms.PictureBox exitbtn;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox restorebtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid sabunDataGridView;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse insertbtnElipse;
        private Bunifu.Framework.UI.BunifuElipse updateElipse;
        private Bunifu.Framework.UI.BunifuElipse deleteElipse;
        private Bunifu.Framework.UI.BunifuElipse checkElipse;
        private Bunifu.Framework.UI.BunifuElipse cancelElipse;
        public MetroFramework.Controls.MetroTabControl tabControl1;
    }
}

