namespace E1941045_ICT_Project_Lawyer_Management_System
{
    partial class deletingForm
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
            this.btn_deleteCase = new System.Windows.Forms.Button();
            this.btn_deleteSearchID = new System.Windows.Forms.Button();
            this.txt_deleteCourtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_deleteCaseDes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_deleteCaseNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_deleteCaseID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_deleteCID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deleteBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_deleteStatus = new System.Windows.Forms.Panel();
            this.rbtn_deleteclosedStatus = new System.Windows.Forms.RadioButton();
            this.rbtn_deletependingStatus = new System.Windows.Forms.RadioButton();
            this.rbtn_deletenewStatus = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_deleteresults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_mainmenuDC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_deleteStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deleteresults)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleteCase
            // 
            this.btn_deleteCase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_deleteCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteCase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteCase.Location = new System.Drawing.Point(751, 475);
            this.btn_deleteCase.Name = "btn_deleteCase";
            this.btn_deleteCase.Size = new System.Drawing.Size(273, 45);
            this.btn_deleteCase.TabIndex = 106;
            this.btn_deleteCase.Text = "Delete";
            this.btn_deleteCase.UseVisualStyleBackColor = false;
            this.btn_deleteCase.Click += new System.EventHandler(this.btn_deleteCase_Click);
            // 
            // btn_deleteSearchID
            // 
            this.btn_deleteSearchID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_deleteSearchID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteSearchID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteSearchID.Location = new System.Drawing.Point(751, 177);
            this.btn_deleteSearchID.Name = "btn_deleteSearchID";
            this.btn_deleteSearchID.Size = new System.Drawing.Size(273, 45);
            this.btn_deleteSearchID.TabIndex = 105;
            this.btn_deleteSearchID.Text = "Search ID";
            this.btn_deleteSearchID.UseVisualStyleBackColor = false;
            this.btn_deleteSearchID.Click += new System.EventHandler(this.btn_deleteSearchID_Click);
            // 
            // txt_deleteCourtName
            // 
            this.txt_deleteCourtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deleteCourtName.Location = new System.Drawing.Point(215, 426);
            this.txt_deleteCourtName.Name = "txt_deleteCourtName";
            this.txt_deleteCourtName.ReadOnly = true;
            this.txt_deleteCourtName.Size = new System.Drawing.Size(273, 27);
            this.txt_deleteCourtName.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 101;
            this.label8.Text = "Court Name";
            // 
            // txt_deleteCaseDes
            // 
            this.txt_deleteCaseDes.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deleteCaseDes.Location = new System.Drawing.Point(215, 223);
            this.txt_deleteCaseDes.Multiline = true;
            this.txt_deleteCaseDes.Name = "txt_deleteCaseDes";
            this.txt_deleteCaseDes.ReadOnly = true;
            this.txt_deleteCaseDes.Size = new System.Drawing.Size(273, 182);
            this.txt_deleteCaseDes.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "Case Description";
            // 
            // txt_deleteCaseNo
            // 
            this.txt_deleteCaseNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deleteCaseNo.Location = new System.Drawing.Point(215, 174);
            this.txt_deleteCaseNo.Name = "txt_deleteCaseNo";
            this.txt_deleteCaseNo.ReadOnly = true;
            this.txt_deleteCaseNo.Size = new System.Drawing.Size(273, 27);
            this.txt_deleteCaseNo.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 96;
            this.label5.Text = "Case No.";
            // 
            // txt_deleteCaseID
            // 
            this.txt_deleteCaseID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deleteCaseID.Location = new System.Drawing.Point(215, 128);
            this.txt_deleteCaseID.Name = "txt_deleteCaseID";
            this.txt_deleteCaseID.ReadOnly = true;
            this.txt_deleteCaseID.Size = new System.Drawing.Size(273, 27);
            this.txt_deleteCaseID.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 94;
            this.label4.Text = "Case ID";
            // 
            // txt_deleteCID
            // 
            this.txt_deleteCID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deleteCID.Location = new System.Drawing.Point(751, 128);
            this.txt_deleteCID.Name = "txt_deleteCID";
            this.txt_deleteCID.Size = new System.Drawing.Size(273, 27);
            this.txt_deleteCID.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(636, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Client ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Lawyer Management System";
            // 
            // btn_deleteBack
            // 
            this.btn_deleteBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteBack.Location = new System.Drawing.Point(891, 540);
            this.btn_deleteBack.Name = "btn_deleteBack";
            this.btn_deleteBack.Size = new System.Drawing.Size(133, 36);
            this.btn_deleteBack.TabIndex = 90;
            this.btn_deleteBack.Text = "Back";
            this.btn_deleteBack.UseVisualStyleBackColor = true;
            this.btn_deleteBack.Click += new System.EventHandler(this.btn_deleteBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 89;
            this.label1.Text = "Delete Case";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnl_deleteStatus
            // 
            this.pnl_deleteStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnl_deleteStatus.Controls.Add(this.rbtn_deleteclosedStatus);
            this.pnl_deleteStatus.Controls.Add(this.rbtn_deletependingStatus);
            this.pnl_deleteStatus.Controls.Add(this.rbtn_deletenewStatus);
            this.pnl_deleteStatus.Controls.Add(this.label9);
            this.pnl_deleteStatus.Location = new System.Drawing.Point(51, 459);
            this.pnl_deleteStatus.Name = "pnl_deleteStatus";
            this.pnl_deleteStatus.Size = new System.Drawing.Size(457, 48);
            this.pnl_deleteStatus.TabIndex = 114;
            // 
            // rbtn_deleteclosedStatus
            // 
            this.rbtn_deleteclosedStatus.AutoSize = true;
            this.rbtn_deleteclosedStatus.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_deleteclosedStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_deleteclosedStatus.Location = new System.Drawing.Point(356, 14);
            this.rbtn_deleteclosedStatus.Name = "rbtn_deleteclosedStatus";
            this.rbtn_deleteclosedStatus.Size = new System.Drawing.Size(81, 23);
            this.rbtn_deleteclosedStatus.TabIndex = 114;
            this.rbtn_deleteclosedStatus.TabStop = true;
            this.rbtn_deleteclosedStatus.Text = "Closed";
            this.rbtn_deleteclosedStatus.UseVisualStyleBackColor = false;
            // 
            // rbtn_deletependingStatus
            // 
            this.rbtn_deletependingStatus.AutoSize = true;
            this.rbtn_deletependingStatus.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_deletependingStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_deletependingStatus.Location = new System.Drawing.Point(248, 14);
            this.rbtn_deletependingStatus.Name = "rbtn_deletependingStatus";
            this.rbtn_deletependingStatus.Size = new System.Drawing.Size(91, 23);
            this.rbtn_deletependingStatus.TabIndex = 113;
            this.rbtn_deletependingStatus.TabStop = true;
            this.rbtn_deletependingStatus.Text = "Pending";
            this.rbtn_deletependingStatus.UseVisualStyleBackColor = false;
            // 
            // rbtn_deletenewStatus
            // 
            this.rbtn_deletenewStatus.AutoSize = true;
            this.rbtn_deletenewStatus.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_deletenewStatus.Checked = true;
            this.rbtn_deletenewStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_deletenewStatus.Location = new System.Drawing.Point(164, 14);
            this.rbtn_deletenewStatus.Name = "rbtn_deletenewStatus";
            this.rbtn_deletenewStatus.Size = new System.Drawing.Size(63, 23);
            this.rbtn_deletenewStatus.TabIndex = 112;
            this.rbtn_deletenewStatus.TabStop = true;
            this.rbtn_deletenewStatus.Text = "New";
            this.rbtn_deletenewStatus.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 111;
            this.label9.Text = "Case Status";
            // 
            // dgv_deleteresults
            // 
            this.dgv_deleteresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deleteresults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_deleteresults.Location = new System.Drawing.Point(541, 239);
            this.dgv_deleteresults.Name = "dgv_deleteresults";
            this.dgv_deleteresults.ReadOnly = true;
            this.dgv_deleteresults.RowHeadersWidth = 51;
            this.dgv_deleteresults.RowTemplate.Height = 24;
            this.dgv_deleteresults.Size = new System.Drawing.Size(483, 189);
            this.dgv_deleteresults.TabIndex = 115;
            this.dgv_deleteresults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_deleteresults_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Case ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Case No.";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Case Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Case Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // btn_mainmenuDC
            // 
            this.btn_mainmenuDC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenuDC.Location = new System.Drawing.Point(751, 540);
            this.btn_mainmenuDC.Name = "btn_mainmenuDC";
            this.btn_mainmenuDC.Size = new System.Drawing.Size(133, 36);
            this.btn_mainmenuDC.TabIndex = 116;
            this.btn_mainmenuDC.Text = "Main Menu";
            this.btn_mainmenuDC.UseVisualStyleBackColor = true;
            this.btn_mainmenuDC.Click += new System.EventHandler(this.btn_mainmenuDC_Click);
            // 
            // deletingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E1941045_ICT_Project_Lawyer_Management_System.Properties.Resources.img_backgroundnew_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 619);
            this.Controls.Add(this.btn_mainmenuDC);
            this.Controls.Add(this.dgv_deleteresults);
            this.Controls.Add(this.pnl_deleteStatus);
            this.Controls.Add(this.btn_deleteCase);
            this.Controls.Add(this.btn_deleteSearchID);
            this.Controls.Add(this.txt_deleteCourtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_deleteCaseDes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_deleteCaseNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_deleteCaseID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_deleteCID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deleteBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "deletingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Case";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_deleteStatus.ResumeLayout(false);
            this.pnl_deleteStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deleteresults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_deleteCase;
        private System.Windows.Forms.Button btn_deleteSearchID;
        private System.Windows.Forms.TextBox txt_deleteCourtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_deleteCaseDes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_deleteCaseNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_deleteCaseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_deleteCID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deleteBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_deleteStatus;
        private System.Windows.Forms.RadioButton rbtn_deleteclosedStatus;
        private System.Windows.Forms.RadioButton rbtn_deletependingStatus;
        private System.Windows.Forms.RadioButton rbtn_deletenewStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_deleteresults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_mainmenuDC;
    }
}