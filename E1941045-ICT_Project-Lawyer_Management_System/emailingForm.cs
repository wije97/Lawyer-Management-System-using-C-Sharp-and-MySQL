using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace E1941045_ICT_Project_Lawyer_Management_System
{
    public partial class emailingForm : Form
    {
        private string user_email, user_password, password;

        string email = "";

        public emailingForm()
        {
            InitializeComponent();
        }

        private void emailingForm_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlDataReader MyReader;
                MyConn.Open();

                string query = "SELECT * FROM lawdb.user ";

                MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                MyReader = MyCommand.ExecuteReader();

                while (MyReader.Read())
                {
                    user_email = MyReader.GetString("email");
                    user_password = MyReader.GetString("email_password");
                    password = MyReader.GetString("password");
                }
                MyConn.Close();
                lbl_email.Text = user_email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_emailBack_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }

        private void btn_emailSearch_Click(object sender, EventArgs e)
        {
            DateTime dateVal1 = dtp_emailDate1.Value.Date;
            DateTime dateVal2 = dtp_emailDate2.Value.Date;

            if (dateVal2 >= dateVal1)
            {
                try
                {
                    string date1 = dateVal1.ToString("yyyyMMdd");
                    string date2 = dateVal2.ToString("yyyyMMdd");

                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MyConn.Open();

                    string Query = "SELECT CONCAT( `First_Name`,' ',`Last_Name`) AS Client_Name, clients.Phone_No,cases.Case_No,cases.Court_Name,cases.Case_Type,cases.Case_Date FROM lawdb.clients INNER JOIN cases ON clients.Client_ID=cases.Client_ID WHERE cases.Case_Date BETWEEN'" + date1 + "'AND'" + date2 + "';";
                   
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);

                    dgv_emailResult.DataSource = null;
                    dgv_emailResult.Rows.Clear();

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {

                        dgv_emailResult.AutoGenerateColumns = false;
                        dgv_emailResult.ColumnCount = 6;

                        dgv_emailResult.Columns[0].HeaderText = "Client Name";
                        dgv_emailResult.Columns[0].DataPropertyName = "Client_Name";

                        dgv_emailResult.Columns[1].HeaderText = "Case No";
                        dgv_emailResult.Columns[1].DataPropertyName = "Case_No";

                        dgv_emailResult.Columns[2].HeaderText = "Case Type";
                        dgv_emailResult.Columns[2].DataPropertyName = "Case_Type";

                        dgv_emailResult.Columns[3].HeaderText = "Court Name";
                        dgv_emailResult.Columns[3].DataPropertyName = "Court_Name";

                        dgv_emailResult.Columns[4].HeaderText = "Court Date";
                        dgv_emailResult.Columns[4].DataPropertyName = "Case_Date";

                        dgv_emailResult.Columns[5].HeaderText = "Phone No.";
                        dgv_emailResult.Columns[5].DataPropertyName = "Phone_No";

                        dgv_emailResult.DataSource = table;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Cases for this date range!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid date range!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_emailClear_Click(object sender, EventArgs e)
        {
            dgv_emailResult.DataSource = null;
            dgv_emailResult.Rows.Clear();
            dtp_emailDate1.ResetText();
            dtp_emailDate2.ResetText();
            txt_msgBody.ResetText();
            txt_emailAddrss.ResetText();
            txt_emailPssword.ResetText();
            cbx_emailChoose.Checked = false;
            grbx_emailDetails.Enabled = false;
            errorProvider1.Clear();
            lbl_caseNo.Text = "Case No.";
            lbl_email.Text = user_email;
        }

        private void cbx_emailChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_emailChoose.Checked)
            {
                pnl_emailForm.Enabled = true;
                email = "";
            }
            else
            {
                pnl_emailForm.Enabled = false;
            }
        }

        private void dgv_emailResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_emailResult.Rows.Count > 1)
            {
                grbx_emailDetails.Enabled = true;

                lbl_caseNo.Text = "Case No: " + dgv_emailResult.CurrentRow.Cells[1].Value.ToString();

                if (!(lbl_caseNo.Text == "Case No."))
                {
                    errorProvider1.SetError(lbl_caseNo, "Case Added to Send.");
                }
                else
                {
                    errorProvider1.Clear();
                }

                txt_msgBody.Text = "01. Client Name : " + dgv_emailResult.CurrentRow.Cells[0].Value.ToString() + "\r\n" +
                                "02. Case No      : " + dgv_emailResult.CurrentRow.Cells[1].Value.ToString() + "\r\n" +
                                "03. Case Type    : " + dgv_emailResult.CurrentRow.Cells[2].Value.ToString() + "\r\n" +
                                "04. Court Name : " + dgv_emailResult.CurrentRow.Cells[3].Value.ToString() + "\r\n" +
                                "05. Case Date    : " + dgv_emailResult.CurrentRow.Cells[4].Value.ToString() + "\r\n" +
                                "06. Phone No    : " + dgv_emailResult.CurrentRow.Cells[5].Value.ToString() + "\r\n";

            }
        }

        private void btn_emailSend_Click(object sender, EventArgs e)
        {
            if (cbx_emailChoose.Checked)
            {
                bool errors = false;
                if (txt_emailAddrss.Text == "" )
                {
                    errorProvider2.SetError(txt_emailAddrss, "Please enter valid E-mail Address!");
                    errors = true;
                }
                else
                {
                    errorProvider2.Clear();
                }

                if (txt_emailPssword.Text == "" || !(txt_emailPssword.Text == password))
                {
                    errorProvider3.SetError(txt_emailPssword, "Invalid E-mail or Password!");
                    errors = true;
                }
                else
                {
                    errorProvider3.Clear();
                }

                if (!errors)
                {
                    email = txt_emailAddrss.Text.ToString();
                }

            }
            else
            {
                email = lbl_email.Text.ToString();
            }

            if (!(email==""))
            {
                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    message.From = new MailAddress(user_email);
                    message.To.Add(new MailAddress(email));
                    message.Subject = lbl_caseNo.Text;
                    message.Body = txt_msgBody.Text;

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(user_email, user_password);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);

                    MessageBox.Show("Send Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_email.Text = user_email;
                    errorProvider1.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid E-mail address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter E-mail or Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_emailAddrss_TextChanged(object sender, EventArgs e)
        {
            lbl_email.Text = txt_emailAddrss.Text;
        }
    }
}
