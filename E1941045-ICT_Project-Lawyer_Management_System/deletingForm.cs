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
    public partial class deletingForm : Form
    {
        private string status;
        private int intValidation;

        public deletingForm()
        {
            InitializeComponent();
        }

        private void btn_deleteBack_Click(object sender, EventArgs e)
        {
            chooseDeleting form13 = new chooseDeleting();
            form13.Show();
            this.Hide();
        }

        private void btn_deleteSearchID_Click(object sender, EventArgs e)
        {
            if (txt_deleteCID.Text == "")
            {
                errorProvider1.SetError(txt_deleteCID, "Please enter Client ID for Delete!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string query = "SELECT Case_ID,Case_No,Case_Des,Case_Date FROM lawdb.cases WHERE Client_ID='" + this.txt_deleteCID.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
                    MyConn.Open();

                    dgv_deleteresults.DataSource = null;
                    dgv_deleteresults.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_deleteresults.AutoGenerateColumns = false;
                        dgv_deleteresults.ColumnCount = 4;

                        dgv_deleteresults.Columns[0].HeaderText = "Case ID";
                        dgv_deleteresults.Columns[0].DataPropertyName = "Case_ID";

                        dgv_deleteresults.Columns[1].HeaderText = "Case No";
                        dgv_deleteresults.Columns[1].DataPropertyName = "Case_No";

                        dgv_deleteresults.Columns[2].HeaderText = "Case Description";
                        dgv_deleteresults.Columns[2].DataPropertyName = "Case_Des";

                        dgv_deleteresults.Columns[3].HeaderText = "Case Date";
                        dgv_deleteresults.Columns[3].DataPropertyName = "Case_Date";

                        dgv_deleteresults.DataSource = table;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Cases for this Client ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_deleteCase_Click(object sender, EventArgs e)
        {
            if (!(txt_deleteCID.Text==""))
            {
                DialogResult dr = MessageBox.Show("Want to delete this Case?", "Are you Sure?", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                        string query = "DELETE FROM lawdb.cases where Case_ID='" + this.txt_deleteCaseID.Text + "';";
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

                        txt_deleteCaseID.ResetText();
                        txt_deleteCaseNo.ResetText();
                        txt_deleteCaseDes.ResetText();
                        txt_deleteCourtName.ResetText();
                        rbtn_deletenewStatus.Checked = true;

                        string query2 = "SELECT Case_ID,Case_No,Case_Des,Case_Date FROM lawdb.cases WHERE Client_ID='" + this.txt_deleteCID.Text + "';";

                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                        MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn2);
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(MyCommand2);
                        MyConn2.Open();

                        dgv_deleteresults.DataSource = null;
                        dgv_deleteresults.Rows.Clear();
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);

                        if (table2.Rows.Count > 0)
                        {
                            dgv_deleteresults.AutoGenerateColumns = false;
                            dgv_deleteresults.ColumnCount = 4;

                            dgv_deleteresults.Columns[0].HeaderText = "Case ID";
                            dgv_deleteresults.Columns[0].DataPropertyName = "Case_ID";

                            dgv_deleteresults.Columns[1].HeaderText = "Case No";
                            dgv_deleteresults.Columns[1].DataPropertyName = "Case_No";

                            dgv_deleteresults.Columns[2].HeaderText = "Case Description";
                            dgv_deleteresults.Columns[2].DataPropertyName = "Case_Des";

                            dgv_deleteresults.Columns[3].HeaderText = "Case Date";
                            dgv_deleteresults.Columns[3].DataPropertyName = "Case_Date";

                            dgv_deleteresults.DataSource = table2;
                            MyConn2.Close();
                        }
                        else
                        {
                            MessageBox.Show("No Cases for fhis Client ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Case from Search Client ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgv_deleteresults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                string query = "SELECT * FROM lawdb.cases WHERE Case_ID='" + dgv_deleteresults.CurrentRow.Cells[0].Value.ToString() + "';";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                MySqlDataReader MyReader;

                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();

                if (MyReader.Read())
                {
                    txt_deleteCaseID.Text = MyReader.GetString("Case_ID");
                    txt_deleteCaseNo.Text = MyReader.GetString("Case_No");
                    txt_deleteCaseDes.Text = MyReader.GetString("Case_Des");
                    txt_deleteCourtName.Text = MyReader.GetString("Court_Name");
                    status = MyReader.GetString("Case_Status");
                    
                    if (status == "New")
                    {
                        rbtn_deletenewStatus.Checked = true;
                    }
                    else if (status == "Pending")
                    {
                        rbtn_deletependingStatus.Checked = true;
                    }
                    else
                    {
                        rbtn_deleteclosedStatus.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("No Data for this Client ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_mainmenuDC_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }
    }
}
