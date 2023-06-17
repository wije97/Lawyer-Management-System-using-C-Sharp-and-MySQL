namespace E1941045_ICT_Project_Lawyer_Management_System
{
    partial class emailingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailingForm));
            this.dtp_emailDate1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_emailDate2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_emailSearch = new System.Windows.Forms.Button();
            this.dgv_emailResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_emailBack = new System.Windows.Forms.Button();
            this.btn_emailSend = new System.Windows.Forms.Button();
            this.btn_emailClear = new System.Windows.Forms.Button();
            this.grbx_emailDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_msgBody = new System.Windows.Forms.TextBox();
            this.pnl_emailForm = new System.Windows.Forms.Panel();
            this.txt_emailPssword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_emailAddrss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_caseNo = new System.Windows.Forms.Label();
            this.cbx_emailChoose = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emailResult)).BeginInit();
            this.grbx_emailDetails.SuspendLayout();
            this.pnl_emailForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_emailDate1
            // 
            this.dtp_emailDate1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_emailDate1.Location = new System.Drawing.Point(63, 165);
            this.dtp_emailDate1.Name = "dtp_emailDate1";
            this.dtp_emailDate1.Size = new System.Drawing.Size(269, 27);
            this.dtp_emailDate1.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Set Date Range:";
            // 
            // dtp_emailDate2
            // 
            this.dtp_emailDate2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_emailDate2.Location = new System.Drawing.Point(409, 165);
            this.dtp_emailDate2.Name = "dtp_emailDate2";
            this.dtp_emailDate2.Size = new System.Drawing.Size(269, 27);
            this.dtp_emailDate2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Send Email";
            // 
            // btn_emailSearch
            // 
            this.btn_emailSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_emailSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emailSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emailSearch.Location = new System.Drawing.Point(736, 158);
            this.btn_emailSearch.Name = "btn_emailSearch";
            this.btn_emailSearch.Size = new System.Drawing.Size(236, 42);
            this.btn_emailSearch.TabIndex = 37;
            this.btn_emailSearch.Text = "Search";
            this.btn_emailSearch.UseVisualStyleBackColor = false;
            this.btn_emailSearch.Click += new System.EventHandler(this.btn_emailSearch_Click);
            // 
            // dgv_emailResult
            // 
            this.dgv_emailResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emailResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_emailResult.Location = new System.Drawing.Point(63, 214);
            this.dgv_emailResult.Name = "dgv_emailResult";
            this.dgv_emailResult.ReadOnly = true;
            this.dgv_emailResult.RowHeadersWidth = 51;
            this.dgv_emailResult.RowTemplate.Height = 24;
            this.dgv_emailResult.Size = new System.Drawing.Size(909, 201);
            this.dgv_emailResult.TabIndex = 38;
            this.dgv_emailResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_emailResult_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Client Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Case No.";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Case Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Court Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Case Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone No.";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lawyer Management System";
            // 
            // btn_emailBack
            // 
            this.btn_emailBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emailBack.Location = new System.Drawing.Point(850, 665);
            this.btn_emailBack.Name = "btn_emailBack";
            this.btn_emailBack.Size = new System.Drawing.Size(116, 34);
            this.btn_emailBack.TabIndex = 39;
            this.btn_emailBack.Text = "Back";
            this.btn_emailBack.UseVisualStyleBackColor = true;
            this.btn_emailBack.Click += new System.EventHandler(this.btn_emailBack_Click);
            // 
            // btn_emailSend
            // 
            this.btn_emailSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_emailSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emailSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emailSend.Location = new System.Drawing.Point(667, 182);
            this.btn_emailSend.Name = "btn_emailSend";
            this.btn_emailSend.Size = new System.Drawing.Size(236, 42);
            this.btn_emailSend.TabIndex = 41;
            this.btn_emailSend.Text = "Send";
            this.btn_emailSend.UseVisualStyleBackColor = false;
            this.btn_emailSend.Click += new System.EventHandler(this.btn_emailSend_Click);
            // 
            // btn_emailClear
            // 
            this.btn_emailClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emailClear.Location = new System.Drawing.Point(730, 665);
            this.btn_emailClear.Name = "btn_emailClear";
            this.btn_emailClear.Size = new System.Drawing.Size(116, 34);
            this.btn_emailClear.TabIndex = 42;
            this.btn_emailClear.Text = "Clear";
            this.btn_emailClear.UseVisualStyleBackColor = true;
            this.btn_emailClear.Click += new System.EventHandler(this.btn_emailClear_Click);
            // 
            // grbx_emailDetails
            // 
            this.grbx_emailDetails.BackColor = System.Drawing.Color.Transparent;
            this.grbx_emailDetails.Controls.Add(this.label4);
            this.grbx_emailDetails.Controls.Add(this.txt_msgBody);
            this.grbx_emailDetails.Controls.Add(this.pnl_emailForm);
            this.grbx_emailDetails.Controls.Add(this.lbl_caseNo);
            this.grbx_emailDetails.Controls.Add(this.cbx_emailChoose);
            this.grbx_emailDetails.Controls.Add(this.label6);
            this.grbx_emailDetails.Controls.Add(this.lbl_email);
            this.grbx_emailDetails.Controls.Add(this.btn_emailSend);
            this.grbx_emailDetails.Enabled = false;
            this.grbx_emailDetails.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_emailDetails.Location = new System.Drawing.Point(63, 429);
            this.grbx_emailDetails.Name = "grbx_emailDetails";
            this.grbx_emailDetails.Size = new System.Drawing.Size(909, 230);
            this.grbx_emailDetails.TabIndex = 43;
            this.grbx_emailDetails.TabStop = false;
            this.grbx_emailDetails.Text = "E-mail Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "Msg Body";
            // 
            // txt_msgBody
            // 
            this.txt_msgBody.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msgBody.Location = new System.Drawing.Point(583, 53);
            this.txt_msgBody.Multiline = true;
            this.txt_msgBody.Name = "txt_msgBody";
            this.txt_msgBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_msgBody.Size = new System.Drawing.Size(320, 123);
            this.txt_msgBody.TabIndex = 44;
            // 
            // pnl_emailForm
            // 
            this.pnl_emailForm.BackColor = System.Drawing.Color.Transparent;
            this.pnl_emailForm.Controls.Add(this.txt_emailPssword);
            this.pnl_emailForm.Controls.Add(this.label7);
            this.pnl_emailForm.Controls.Add(this.txt_emailAddrss);
            this.pnl_emailForm.Controls.Add(this.label5);
            this.pnl_emailForm.Enabled = false;
            this.pnl_emailForm.Location = new System.Drawing.Point(6, 117);
            this.pnl_emailForm.Name = "pnl_emailForm";
            this.pnl_emailForm.Size = new System.Drawing.Size(467, 99);
            this.pnl_emailForm.TabIndex = 77;
            // 
            // txt_emailPssword
            // 
            this.txt_emailPssword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailPssword.Location = new System.Drawing.Point(205, 53);
            this.txt_emailPssword.Name = "txt_emailPssword";
            this.txt_emailPssword.PasswordChar = '*';
            this.txt_emailPssword.Size = new System.Drawing.Size(260, 27);
            this.txt_emailPssword.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 19);
            this.label7.TabIndex = 79;
            this.label7.Text = "Confirmation Password";
            // 
            // txt_emailAddrss
            // 
            this.txt_emailAddrss.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailAddrss.Location = new System.Drawing.Point(205, 11);
            this.txt_emailAddrss.Name = "txt_emailAddrss";
            this.txt_emailAddrss.Size = new System.Drawing.Size(260, 27);
            this.txt_emailAddrss.TabIndex = 78;
            this.txt_emailAddrss.TextChanged += new System.EventHandler(this.txt_emailAddrss_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "E-mail Address";
            // 
            // lbl_caseNo
            // 
            this.lbl_caseNo.AutoSize = true;
            this.lbl_caseNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_caseNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caseNo.Location = new System.Drawing.Point(398, 21);
            this.lbl_caseNo.Name = "lbl_caseNo";
            this.lbl_caseNo.Size = new System.Drawing.Size(73, 19);
            this.lbl_caseNo.TabIndex = 76;
            this.lbl_caseNo.Text = "Case No.";
            // 
            // cbx_emailChoose
            // 
            this.cbx_emailChoose.AutoSize = true;
            this.cbx_emailChoose.Location = new System.Drawing.Point(19, 90);
            this.cbx_emailChoose.Name = "cbx_emailChoose";
            this.cbx_emailChoose.Size = new System.Drawing.Size(156, 21);
            this.cbx_emailChoose.TabIndex = 76;
            this.cbx_emailChoose.Text = "Use another E-mail";
            this.cbx_emailChoose.UseVisualStyleBackColor = true;
            this.cbx_emailChoose.CheckedChanged += new System.EventHandler(this.cbx_emailChoose_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Send to:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(90, 56);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(128, 19);
            this.lbl_email.TabIndex = 69;
            this.lbl_email.Text = "abc@gmail.com";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // emailingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E1941045_ICT_Project_Lawyer_Management_System.Properties.Resources.img_backgroundnew_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 749);
            this.Controls.Add(this.grbx_emailDetails);
            this.Controls.Add(this.btn_emailClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_emailBack);
            this.Controls.Add(this.dgv_emailResult);
            this.Controls.Add(this.btn_emailSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_emailDate2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_emailDate1);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "emailingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.emailingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emailResult)).EndInit();
            this.grbx_emailDetails.ResumeLayout(false);
            this.grbx_emailDetails.PerformLayout();
            this.pnl_emailForm.ResumeLayout(false);
            this.pnl_emailForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_emailDate1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_emailDate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_emailSearch;
        private System.Windows.Forms.DataGridView dgv_emailResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_emailBack;
        private System.Windows.Forms.Button btn_emailSend;
        private System.Windows.Forms.Button btn_emailClear;
        private System.Windows.Forms.GroupBox grbx_emailDetails;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_emailForm;
        private System.Windows.Forms.TextBox txt_emailPssword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_emailAddrss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_caseNo;
        private System.Windows.Forms.CheckBox cbx_emailChoose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txt_msgBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}