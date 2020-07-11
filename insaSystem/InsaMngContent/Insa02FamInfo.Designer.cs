namespace insaSystem
{
    partial class Insa02FamInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel58 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel59 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fam_rel_code = new System.Windows.Forms.TextBox();
            this.fam_rel = new System.Windows.Forms.ComboBox();
            this.fam_ltg = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel60 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fam_bth = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.bas_pos_fam = new Bunifu.Framework.BunifuCustomTextbox();
            this.bas_name_fam = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel56 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel57 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label93 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.bas_dept_fam = new Bunifu.Framework.BunifuCustomTextbox();
            this.bas_empno_fam = new Bunifu.Framework.BunifuCustomTextbox();
            this.fam_name = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.famDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.famDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel58
            // 
            this.bunifuCustomLabel58.AutoSize = true;
            this.bunifuCustomLabel58.Location = new System.Drawing.Point(215, 40);
            this.bunifuCustomLabel58.Name = "bunifuCustomLabel58";
            this.bunifuCustomLabel58.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel58.TabIndex = 53;
            this.bunifuCustomLabel58.Text = "성명(한글)";
            // 
            // bunifuCustomLabel59
            // 
            this.bunifuCustomLabel59.AutoSize = true;
            this.bunifuCustomLabel59.Location = new System.Drawing.Point(49, 40);
            this.bunifuCustomLabel59.Name = "bunifuCustomLabel59";
            this.bunifuCustomLabel59.Size = new System.Drawing.Size(69, 20);
            this.bunifuCustomLabel59.TabIndex = 32;
            this.bunifuCustomLabel59.Text = "사원번호";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(797, 392);
            this.dataGridView1.TabIndex = 108;
            // 
            // fam_rel_code
            // 
            this.fam_rel_code.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.fam_rel_code.Location = new System.Drawing.Point(114, 31);
            this.fam_rel_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fam_rel_code.MaxLength = 82;
            this.fam_rel_code.Name = "fam_rel_code";
            this.fam_rel_code.Size = new System.Drawing.Size(30, 27);
            this.fam_rel_code.TabIndex = 102;
            // 
            // fam_rel
            // 
            this.fam_rel.FormattingEnabled = true;
            this.fam_rel.Items.AddRange(new object[] {
            "부",
            "모",
            "형제",
            "자매"});
            this.fam_rel.Location = new System.Drawing.Point(114, 31);
            this.fam_rel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fam_rel.Name = "fam_rel";
            this.fam_rel.Size = new System.Drawing.Size(70, 28);
            this.fam_rel.TabIndex = 107;
            // 
            // fam_ltg
            // 
            this.fam_ltg.FormattingEnabled = true;
            this.fam_ltg.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.fam_ltg.Location = new System.Drawing.Point(650, 31);
            this.fam_ltg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fam_ltg.Name = "fam_ltg";
            this.fam_ltg.Size = new System.Drawing.Size(91, 28);
            this.fam_ltg.TabIndex = 69;
            // 
            // bunifuCustomLabel60
            // 
            this.bunifuCustomLabel60.AutoSize = true;
            this.bunifuCustomLabel60.Location = new System.Drawing.Point(215, 36);
            this.bunifuCustomLabel60.Name = "bunifuCustomLabel60";
            this.bunifuCustomLabel60.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel60.TabIndex = 68;
            this.bunifuCustomLabel60.Text = "성명(한글)";
            // 
            // fam_bth
            // 
            this.fam_bth.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.fam_bth.Location = new System.Drawing.Point(480, 31);
            this.fam_bth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fam_bth.MaxLength = 82;
            this.fam_bth.Name = "fam_bth";
            this.fam_bth.Size = new System.Drawing.Size(79, 27);
            this.fam_bth.TabIndex = 63;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(585, 36);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(69, 20);
            this.label91.TabIndex = 52;
            this.label91.Text = "동거여부";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(415, 36);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(69, 20);
            this.label92.TabIndex = 51;
            this.label92.Text = "생년월일";
            // 
            // bas_pos_fam
            // 
            this.bas_pos_fam.BorderColor = System.Drawing.Color.SeaGreen;
            this.bas_pos_fam.Enabled = false;
            this.bas_pos_fam.Location = new System.Drawing.Point(480, 35);
            this.bas_pos_fam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bas_pos_fam.Name = "bas_pos_fam";
            this.bas_pos_fam.Size = new System.Drawing.Size(79, 27);
            this.bas_pos_fam.TabIndex = 57;
            // 
            // bas_name_fam
            // 
            this.bas_name_fam.BorderColor = System.Drawing.Color.SeaGreen;
            this.bas_name_fam.Enabled = false;
            this.bas_name_fam.Location = new System.Drawing.Point(289, 35);
            this.bas_name_fam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bas_name_fam.Name = "bas_name_fam";
            this.bas_name_fam.Size = new System.Drawing.Size(89, 27);
            this.bas_name_fam.TabIndex = 56;
            // 
            // bunifuCustomLabel56
            // 
            this.bunifuCustomLabel56.AutoSize = true;
            this.bunifuCustomLabel56.Location = new System.Drawing.Point(576, 40);
            this.bunifuCustomLabel56.Name = "bunifuCustomLabel56";
            this.bunifuCustomLabel56.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel56.TabIndex = 55;
            this.bunifuCustomLabel56.Text = "부서(현재)";
            // 
            // bunifuCustomLabel57
            // 
            this.bunifuCustomLabel57.AutoSize = true;
            this.bunifuCustomLabel57.Location = new System.Drawing.Point(406, 40);
            this.bunifuCustomLabel57.Name = "bunifuCustomLabel57";
            this.bunifuCustomLabel57.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel57.TabIndex = 54;
            this.bunifuCustomLabel57.Text = "직급(현재)";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(77, 36);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(39, 20);
            this.label93.TabIndex = 50;
            this.label93.Text = "관계";
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.White;
            this.groupBox17.Controls.Add(this.bas_dept_fam);
            this.groupBox17.Controls.Add(this.bas_pos_fam);
            this.groupBox17.Controls.Add(this.bas_name_fam);
            this.groupBox17.Controls.Add(this.bunifuCustomLabel56);
            this.groupBox17.Controls.Add(this.bunifuCustomLabel57);
            this.groupBox17.Controls.Add(this.bunifuCustomLabel58);
            this.groupBox17.Controls.Add(this.bas_empno_fam);
            this.groupBox17.Controls.Add(this.bunifuCustomLabel59);
            this.groupBox17.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox17.Location = new System.Drawing.Point(5, 1);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox17.Size = new System.Drawing.Size(810, 85);
            this.groupBox17.TabIndex = 75;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "사원정보";
            // 
            // bas_dept_fam
            // 
            this.bas_dept_fam.BorderColor = System.Drawing.Color.SeaGreen;
            this.bas_dept_fam.Enabled = false;
            this.bas_dept_fam.Location = new System.Drawing.Point(650, 35);
            this.bas_dept_fam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bas_dept_fam.Name = "bas_dept_fam";
            this.bas_dept_fam.Size = new System.Drawing.Size(91, 27);
            this.bas_dept_fam.TabIndex = 58;
            // 
            // bas_empno_fam
            // 
            this.bas_empno_fam.BorderColor = System.Drawing.Color.SeaGreen;
            this.bas_empno_fam.Enabled = false;
            this.bas_empno_fam.Location = new System.Drawing.Point(114, 35);
            this.bas_empno_fam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bas_empno_fam.Name = "bas_empno_fam";
            this.bas_empno_fam.Size = new System.Drawing.Size(70, 27);
            this.bas_empno_fam.TabIndex = 42;
            // 
            // fam_name
            // 
            this.fam_name.Location = new System.Drawing.Point(289, 31);
            this.fam_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fam_name.MaxLength = 5;
            this.fam_name.Name = "fam_name";
            this.fam_name.Size = new System.Drawing.Size(89, 27);
            this.fam_name.TabIndex = 47;
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.Transparent;
            this.groupBox18.Controls.Add(this.dataGridView1);
            this.groupBox18.Controls.Add(this.fam_rel_code);
            this.groupBox18.Controls.Add(this.fam_rel);
            this.groupBox18.Controls.Add(this.fam_ltg);
            this.groupBox18.Controls.Add(this.bunifuCustomLabel60);
            this.groupBox18.Controls.Add(this.fam_bth);
            this.groupBox18.Controls.Add(this.label91);
            this.groupBox18.Controls.Add(this.label92);
            this.groupBox18.Controls.Add(this.label93);
            this.groupBox18.Controls.Add(this.fam_name);
            this.groupBox18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox18.Location = new System.Drawing.Point(5, 92);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox18.Size = new System.Drawing.Size(810, 500);
            this.groupBox18.TabIndex = 76;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "가족정보";
            // 
            // famDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.famDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.famDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.famDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.famDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.famDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.famDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.famDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.famDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.famDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.famDataGridView.DoubleBuffered = true;
            this.famDataGridView.EnableHeadersVisualStyles = false;
            this.famDataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(63)))), ((int)(((byte)(113)))));
            this.famDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.famDataGridView.Location = new System.Drawing.Point(5, 587);
            this.famDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.famDataGridView.Name = "famDataGridView";
            this.famDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.famDataGridView.RowHeadersWidth = 51;
            this.famDataGridView.RowTemplate.Height = 23;
            this.famDataGridView.Size = new System.Drawing.Size(810, 256);
            this.famDataGridView.TabIndex = 74;
            // 
            // Insa02FamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 856);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.famDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insa02FamInfo";
            this.Text = " 가족사항 ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.famDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel58;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel59;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox fam_rel_code;
        private System.Windows.Forms.ComboBox fam_rel;
        private System.Windows.Forms.ComboBox fam_ltg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel60;
        private System.Windows.Forms.TextBox fam_bth;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel56;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel57;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox fam_name;
        private System.Windows.Forms.GroupBox groupBox18;
        private Bunifu.Framework.UI.BunifuCustomDataGrid famDataGridView;
        public Bunifu.Framework.BunifuCustomTextbox bas_pos_fam;
        public Bunifu.Framework.BunifuCustomTextbox bas_name_fam;
        public Bunifu.Framework.BunifuCustomTextbox bas_dept_fam;
        public Bunifu.Framework.BunifuCustomTextbox bas_empno_fam;
    }
}