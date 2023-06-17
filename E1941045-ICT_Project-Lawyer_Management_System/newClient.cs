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

namespace E1941045_ICT_Project_Lawyer_Management_System
{
    public partial class newClient : Form
    {
        private string gender;

        private int intValidation;

        public newClient()
        {
            InitializeComponent();
        }

        private void newClient_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_CNext_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (txt_CID.Text == "")
            {
                errorProvider1.SetError(txt_CID, "Please enter Client ID!");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txt_CFirstName.Text == "" || int.TryParse(txt_CFirstName.Text, out intValidation))
            {
                errorProvider2.SetError(txt_CFirstName, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txt_CLastName.Text=="" || int.TryParse(txt_CLastName.Text, out intValidation))
            {
                errorProvider3.SetError(txt_CLastName, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (txt_CNIC.Text == "")
            {
                errorProvider4.SetError(txt_CNIC, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider4.Clear();
            }

            if (txt_CAge.Text == "" || !int.TryParse(txt_CAge.Text, out intValidation))
            {
                errorProvider5.SetError(txt_CAge, "Please enter number for Age!");
                errors = true;
            }
            else
            {
                errorProvider5.Clear();
            }

            if (txt_CAddress.Text == "")
            {
                errorProvider6.SetError(txt_CAddress, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider6.Clear();
            }

            if (txt_CPhone.Text == "" || !int.TryParse(txt_CPhone.Text, out intValidation))
            {
                errorProvider7.SetError(txt_CPhone, "Please enter phone number!");
                errors = true;
            }
            else if (!(txt_CPhone.Text.Trim().Length == 10))
            {
                errors = true;
                MessageBox.Show("Please enter valid phone number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                errorProvider7.Clear();
            }

            if (!(errors==true))
            {
                if (rbtn_MGender.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string Query = "INSERT INTO lawdb.clients(Client_ID,First_Name,Last_Name,NIC,Age,Gender,Address,Phone_No,Reg_Date) " +
                        "values('" + this.txt_CID.Text + "','" + this.txt_CFirstName.Text + "','" + this.txt_CLastName.Text + "','" + this.txt_CNIC.Text + "','" + this.txt_CAge.Text + "','"+ gender.ToString() + "','" + this.txt_CAddress.Text + "','" + this.txt_CPhone.Text + "','" + dtp_ClientReg.Value.Date.ToString("yyyyMMdd") +"'); ";  
                    
                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                   
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();

                    while (MyReader.Read())
                    {
                    }
                    MyConn.Close();

                    MessageBox.Show("Added Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_addcaseFromClient.Enabled = true;
                    btn_CNext.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btn_clientBack_Click(object sender, EventArgs e)
        {
            addingForm form3 = new addingForm();
            form3.Show();
            this.Hide();
        }

        private void btn_addcaseFromClient_Click(object sender, EventArgs e)
        {
            newCase form5 = new newCase();
            form5.txt_CaseCID.Text = txt_CID.Text;
            form5.Show();
            this.Hide();
        }
    }
}
