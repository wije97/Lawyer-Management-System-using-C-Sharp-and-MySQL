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
    public partial class updateClient : Form
    {
        private int intValidation;
        private string gender;

        public updateClient()
        {
            InitializeComponent();
        }

        private void btn_updateBack_Click(object sender, EventArgs e)
        {
            updatingForm form7 = new updatingForm();
            form7.Show();
            this.Hide();
        }

        private void btn_updateClient_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (txt_updateFirstName.Text == "" || int.TryParse(txt_updateFirstName.Text, out intValidation))
            {
                errorProvider1.SetError(txt_updateFirstName, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txt_updateLastName.Text == "" || int.TryParse(txt_updateLastName.Text, out intValidation))
            {
                errorProvider2.SetError(txt_updateLastName, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txt_updateNIC.Text == "")
            {
                errorProvider3.SetError(txt_updateNIC, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (txt_updateAge.Text == "" || !int.TryParse(txt_updateAge.Text, out intValidation))
            {
                errorProvider4.SetError(txt_updateAge, "Please enter number for Age!");
                errors = true;
            }
            else
            {
                errorProvider4.Clear();
            }

            if (txt_updateAddress.Text == "")
            {
                errorProvider5.SetError(txt_updateAddress, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider5.Clear();
            }

            if (txt_updatePhone.Text == "" || !int.TryParse(txt_updatePhone.Text, out intValidation))
            {
                errorProvider6.SetError(txt_updatePhone, "Please enter phone number!");
                errors = true;
            }
            else if (txt_updatePhone.TextLength == 10)
            {
                errorProvider6.Clear();
            }
            else
            {
                errors = true;
                MessageBox.Show("Please enter valid phone number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!errors)
            {
                if (rbtn_MupdateGender.Checked)
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
                    string query = "UPDATE lawdb.clients SET First_Name='" + this.txt_updateFirstName.Text + "',Last_Name='" + this.txt_updateLastName.Text + "',NIC='" + this.txt_updateNIC.Text + "', Age='" + this.txt_updateAge.Text + "',Gender='" + gender.ToString() + "',Address='" + this.txt_updateAddress.Text + "',Phone_No='" + this.txt_updatePhone.Text + "' WHERE Client_ID='" + this.txt_updateID.Text + "';";

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
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_updateSearch_Click(object sender, EventArgs e)
        {
            if (txt_searchClientID.Text == "")
            {
                errorProvider1.SetError(txt_searchClientID, "Please enter Client ID for updating!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string query = "SELECT * FROM lawdb.clients WHERE Client_ID='" + this.txt_searchClientID.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                    MySqlDataReader MyReader;

                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();

                    if (MyReader.Read())
                    {
                        txt_updateID.Text = MyReader.GetString("Client_ID");
                        txt_updateFirstName.Text = MyReader.GetString("First_Name");
                        txt_updateLastName.Text = MyReader.GetString("Last_Name");
                        txt_updateNIC.Text = MyReader.GetString("NIC");
                        txt_updateAge.Text = MyReader.GetInt32("Age").ToString();
                        gender = MyReader.GetString("Gender");
                        txt_updateAddress.Text = MyReader.GetString("Address");
                        txt_updatePhone.Text = MyReader.GetString("Phone_No");

                        if (gender == "Male")
                        {
                            rbtn_MupdateGender.Checked = true;
                        }
                        else
                        {
                            rbtn_FupdateGender.Checked = true;
                        }


                    }
                    else
                    {
                        MessageBox.Show("No Data For This Client Id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MyConn.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_updateClear_Click(object sender, EventArgs e)
        {
            txt_updateID.ResetText();
            txt_updateFirstName.ResetText();
            txt_updateLastName.ResetText();
            txt_updateNIC.ResetText();
            txt_updateAge.ResetText();
            txt_updateAddress.ResetText();
            txt_updatePhone.ResetText();
            txt_searchClientID.ResetText();
            errorProvider1.Clear();
            rbtn_MupdateGender.Checked = true;
        }

    }
}
