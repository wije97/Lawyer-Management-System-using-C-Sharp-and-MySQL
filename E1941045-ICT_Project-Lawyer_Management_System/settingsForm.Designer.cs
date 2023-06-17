namespace E1941045_ICT_Project_Lawyer_Management_System
{
    partial class settingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cmgPW = new System.Windows.Forms.Button();
            this.txt_confirmPW = new System.Windows.Forms.TextBox();
            this.txt_newPW = new System.Windows.Forms.TextBox();
            this.txt_currntPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addEmainAcc = new System.Windows.Forms.Button();
            this.txt_emailPW = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cngUName = new System.Windows.Forms.Button();
            this.txt_newUName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_cmgPW);
            this.groupBox1.Controls.Add(this.txt_confirmPW);
            this.groupBox1.Controls.Add(this.txt_newPW);
            this.groupBox1.Controls.Add(this.txt_currntPW);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // btn_cmgPW
            // 
            this.btn_cmgPW.Location = new System.Drawing.Point(172, 157);
            this.btn_cmgPW.Name = "btn_cmgPW";
            this.btn_cmgPW.Size = new System.Drawing.Size(214, 36);
            this.btn_cmgPW.TabIndex = 3;
            this.btn_cmgPW.Text = "Change";
            this.btn_cmgPW.UseVisualStyleBackColor = true;
            this.btn_cmgPW.Click += new System.EventHandler(this.btn_cmgPW_Click);
            // 
            // txt_confirmPW
            // 
            this.txt_confirmPW.Location = new System.Drawing.Point(172, 116);
            this.txt_confirmPW.MaxLength = 15;
            this.txt_confirmPW.Name = "txt_confirmPW";
            this.txt_confirmPW.PasswordChar = '*';
            this.txt_confirmPW.Size = new System.Drawing.Size(214, 27);
            this.txt_confirmPW.TabIndex = 5;
            // 
            // txt_newPW
            // 
            this.txt_newPW.Location = new System.Drawing.Point(172, 76);
            this.txt_newPW.MaxLength = 15;
            this.txt_newPW.Name = "txt_newPW";
            this.txt_newPW.PasswordChar = '*';
            this.txt_newPW.Size = new System.Drawing.Size(214, 27);
            this.txt_newPW.TabIndex = 4;
            // 
            // txt_currntPW
            // 
            this.txt_currntPW.Location = new System.Drawing.Point(172, 36);
            this.txt_currntPW.MaxLength = 15;
            this.txt_currntPW.Name = "txt_currntPW";
            this.txt_currntPW.PasswordChar = '*';
            this.txt_currntPW.Size = new System.Drawing.Size(214, 27);
            this.txt_currntPW.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_addEmainAcc);
            this.groupBox2.Controls.Add(this.txt_emailPW);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E-mail Account";
            // 
            // btn_addEmainAcc
            // 
            this.btn_addEmainAcc.Location = new System.Drawing.Point(172, 122);
            this.btn_addEmainAcc.Name = "btn_addEmainAcc";
            this.btn_addEmainAcc.Size = new System.Drawing.Size(214, 36);
            this.btn_addEmainAcc.TabIndex = 6;
            this.btn_addEmainAcc.Text = "Add";
            this.btn_addEmainAcc.UseVisualStyleBackColor = true;
            this.btn_addEmainAcc.Click += new System.EventHandler(this.btn_addEmainAcc_Click);
            // 
            // txt_emailPW
            // 
            this.txt_emailPW.Location = new System.Drawing.Point(172, 80);
            this.txt_emailPW.MaxLength = 20;
            this.txt_emailPW.Name = "txt_emailPW";
            this.txt_emailPW.PasswordChar = '*';
            this.txt_emailPW.Size = new System.Drawing.Size(214, 27);
            this.txt_emailPW.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(172, 40);
            this.txt_email.MaxLength = 30;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(214, 27);
            this.txt_email.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(345, 584);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 36);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_cngUName);
            this.groupBox3.Controls.Add(this.txt_newUName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 125);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Username";
            // 
            // btn_cngUName
            // 
            this.btn_cngUName.Location = new System.Drawing.Point(172, 74);
            this.btn_cngUName.Name = "btn_cngUName";
            this.btn_cngUName.Size = new System.Drawing.Size(214, 36);
            this.btn_cngUName.TabIndex = 6;
            this.btn_cngUName.Text = "Change";
            this.btn_cngUName.UseVisualStyleBackColor = true;
            this.btn_cngUName.Click += new System.EventHandler(this.btn_cngUName_Click);
            // 
            // txt_newUName
            // 
            this.txt_newUName.Location = new System.Drawing.Point(172, 35);
            this.txt_newUName.MaxLength = 15;
            this.txt_newUName.Name = "txt_newUName";
            this.txt_newUName.Size = new System.Drawing.Size(214, 27);
            this.txt_newUName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "New Username";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E1941045_ICT_Project_Lawyer_Management_System.Properties.Resources.img_backgroundnew_02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 663);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_cmgPW;
        private System.Windows.Forms.TextBox txt_confirmPW;
        private System.Windows.Forms.TextBox txt_newPW;
        private System.Windows.Forms.TextBox txt_currntPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addEmainAcc;
        private System.Windows.Forms.TextBox txt_emailPW;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cngUName;
        private System.Windows.Forms.TextBox txt_newUName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}