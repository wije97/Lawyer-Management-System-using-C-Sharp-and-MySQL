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
    public partial class settingsForm : Form
    {
        private string password;

        public settingsForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cngUName_Click(object sender, EventArgs e)
        {
            if (txt_newUName.Text == "")
            {
                errorProvider1.SetError(txt_newUName, "Please fill the Uername!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string query = "UPDATE lawdb.user SET username='" + this.txt_newUName.Text +"';";

                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();

                    MessageBox.Show("Updated Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader.Read())
                    {
                    }
                    MyConn.Close();
                    txt_newUName.ResetText();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cmgPW_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (txt_currntPW.Text == "")
            {
                errorProvider1.SetError(txt_currntPW, "Please enter Current Password!");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txt_newPW.Text == "")
            {
                errorProvider2.SetError(txt_newPW, "Please enter New Password!");
                errors = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txt_confirmPW.Text == "")
            {
                errorProvider3.SetError(txt_confirmPW, "Please confirm your New Password!");
                errors = true;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (!errors)
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
                        password = MyReader.GetString("password");
                    }
                    MyConn.Close();

                    if (password == txt_currntPW.Text)
                    {
                        if (txt_newPW.Text == txt_confirmPW.Text)
                        {
                            try
                            {
                                MyConn.Open();

                                string query2 = "UPDATE lawdb.user SET password='" + this.txt_newPW.Text + "';";

                                MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn);


                                MyReader = MyCommand2.ExecuteReader();

                                MessageBox.Show("Updated Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                while (MyReader.Read())
                                {
                                }
                                MyConn.Close();
                                txt_newPW.ResetText();
                                txt_currntPW.ResetText();
                                txt_confirmPW.ResetText();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check confirmation password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_confirmPW.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_currntPW.ResetText();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_addEmainAcc_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (txt_email.Text=="")
            {
                errorProvider1.SetError(txt_email, "Please enter your E-mail Address!");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txt_emailPW.Text == "")
            {
                errorProvider2.SetError(txt_emailPW, "Please enter Password!");
                errors = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (!errors)
            {
                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlDataReader MyReader;
                    MyConn.Open();

                    string query2 = "UPDATE lawdb.user SET email='" + this.txt_email.Text + "',email_password='" + this.txt_emailPW.Text + "';";

                    MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn);


                    MyReader = MyCommand2.ExecuteReader();

                    MessageBox.Show("Added Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (MyReader.Read())
                    {
                    }
                    MyConn.Close();
                    txt_email.ResetText();
                    txt_emailPW.ResetText();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
