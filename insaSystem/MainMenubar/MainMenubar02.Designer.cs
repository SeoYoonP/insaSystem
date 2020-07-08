namespace insaSystem
{
    partial class MainMenubar02
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InsaInquiry = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.InsaInput = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.label1);
            this.panel17.Location = new System.Drawing.Point(34, 249);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(149, 41);
            this.panel17.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "인사기록 관리";
            // 
            // InsaInquiry
            // 
            this.InsaInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsaInquiry.FlatAppearance.BorderSize = 0;
            this.InsaInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsaInquiry.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.InsaInquiry.ForeColor = System.Drawing.Color.White;
            this.InsaInquiry.Location = new System.Drawing.Point(1, 372);
            this.InsaInquiry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsaInquiry.Name = "InsaInquiry";
            this.InsaInquiry.Size = new System.Drawing.Size(219, 70);
            this.InsaInquiry.TabIndex = 63;
            this.InsaInquiry.Text = "인사기록 조회(통합)";
            this.InsaInquiry.UseVisualStyleBackColor = true;
            this.InsaInquiry.Click += new System.EventHandler(this.InsaInquiry_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(33, 427);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 1);
            this.panel5.TabIndex = 66;
            // 
            // InsaInput
            // 
            this.InsaInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsaInput.FlatAppearance.BorderSize = 0;
            this.InsaInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsaInput.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.InsaInput.ForeColor = System.Drawing.Color.White;
            this.InsaInput.Location = new System.Drawing.Point(1, 296);
            this.InsaInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsaInput.Name = "InsaInput";
            this.InsaInput.Size = new System.Drawing.Size(219, 70);
            this.InsaInput.TabIndex = 59;
            this.InsaInput.Text = "인사정보 입력";
            this.InsaInput.UseVisualStyleBackColor = true;
            this.InsaInput.Click += new System.EventHandler(this.InsaInput_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Location = new System.Drawing.Point(33, 351);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 1);
            this.panel6.TabIndex = 62;
            // 
            // MainMenubar02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(221, 800);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.InsaInquiry);
            this.Controls.Add(this.InsaInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenubar02";
            this.Text = "Form1";
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsaInquiry;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button InsaInput;
        private System.Windows.Forms.Panel panel6;
    }
}