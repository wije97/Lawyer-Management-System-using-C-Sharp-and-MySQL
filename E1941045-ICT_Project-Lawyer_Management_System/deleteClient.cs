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
    public partial class deleteClient : Form
    {
        private int intValidation;
        private string gender;

        public deleteClient()
        {
            InitializeComponent();
        }

        private void btn_mainMenuDCl_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }

        private void btn_dltClientBack_Click(object sender, EventArgs e)
        {
            chooseDeleting form13 = new chooseDeleting();
            form13.Show();
            this.Hide();
        }

        private void btn_dltClientSearch_Click(object sender, EventArgs e)
        {
            if (txt_dltCientsearchClientID.Text == "")
            {
                errorProvider1.SetError(txt_dltCientsearchClientID, "Please enter Client ID for deleting!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string query = "SELECT Case_ID,Case_No,Case_Des,Case_Date FROM lawdb.cases WHERE Client_ID='" + this.txt_dltCientsearchClientID.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
                    MyConn.Open();

                    dgv_dltClientResults.DataSource = null;
                    dgv_dltClientResults.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_dltClientResults.AutoGenerateColumns = false;
                        dgv_dltClientResults.ColumnCount = 4;

                        dgv_dltClientResults.Columns[0].HeaderText = "Case ID";
                        dgv_dltClientResults.Columns[0].DataPropertyName = "Case_ID";

                        dgv_dltClientResults.Columns[1].HeaderText = "Case No";
                        dgv_dltClientResults.Columns[1].DataPropertyName = "Case_No";

                        dgv_dltClientResults.Columns[2].HeaderText = "Case Description";
                        dgv_dltClientResults.Columns[2].DataPropertyName = "Case_Des";

                        dgv_dltClientResults.Columns[3].HeaderText = "Case Date";
                        dgv_dltClientResults.Columns[3].DataPropertyName = "Case_Date";

                        dgv_dltClientResults.DataSource = table;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Cases for this Client ID!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string query2 = "SELECT * FROM lawdb.clients WHERE Client_ID='" + this.txt_dltCientsearchClientID.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn2);
                    MySqlDataReader MyReader2;

                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    if (MyReader2.Read())
                    {
                        txt_dltClientID.Text = MyReader2.GetString("Client_ID");
                        txt_dltCientFirstName.Text = MyReader2.GetString("First_Name");
                        txt_dltCientLastName.Text = MyReader2.GetString("Last_Name");
                        txt_dltCientNIC.Text = MyReader2.GetString("NIC");
                        txt_dltCientAge.Text = MyReader2.GetInt32("Age").ToString();
                        gender = MyReader2.GetString("Gender");
                        txt_dltCientAddress.Text = MyReader2.GetString("Address");
                        txt_dltCientPhone.Text = MyReader2.GetString("Phone_No");

                        if (gender == "Male")
                        {
                            rbtn_MdltClientGender.Checked = true;
                        }
                        else
                        {
                            rbtn_MdltClientGender.Checked = true;
                        }


                    }
                    else
                    {
                        MessageBox.Show("No Data For This Client Id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MyConn2.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
               
        }

        private void btn_dltClient_Click(object sender, EventArgs e)
        {
            if (!(txt_dltClientID.Text==""))
            {
                if (dgv_dltClientResults.Rows.Count > 1)
                {
                    MessageBox.Show("You cannot delete Clients with Cases!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult dr = MessageBox.Show("Want to delete this Client?", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                            string query = "DELETE FROM lawdb.clients where Client_ID='" + this.txt_dltCientsearchClientID.Text + "';";
                            MySqlConnection MyConn = new MySqlConnection(MyConnection);
                            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                            MySqlDataReader MyReader;
                            MyConn.Open();
                            MyReader = MyCommand.ExecuteReader();
                            MessageBox.Show("Deleted Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            while (MyReader.Read())
                            {
                            }
                            MyConn.Close();

                            txt_dltClientID.ResetText();
                            txt_dltCientFirstName.ResetText();
                            txt_dltCientLastName.ResetText();
                            txt_dltCientNIC.ResetText();
                            txt_dltCientAge.ResetText();
                            txt_dltCientAddress.ResetText();
                            txt_dltCientPhone.ResetText();
                            rbtn_MdltClientGender.Checked = true;
                            txt_dltCientsearchClientID.ResetText();
                            dgv_dltClientResults.Rows.Clear();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("Please select Client from Search!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
