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
    public partial class updateCase : Form
    {
        private string type, status;
        private int intValidation;

        public updateCase()
        {
            InitializeComponent();
        }

        private void btn_UpdtcaseBack_Click(object sender, EventArgs e)
        {
            updatingForm form7 = new updatingForm();
            form7.Show();
            this.Hide();
        }

        private void btn_UpdtCaseUpdate_Click(object sender, EventArgs e)
        {
            bool errors = false;


            if (txt_UpdtCaseNo.Text == "" || !int.TryParse(txt_UpdtCaseNo.Text, out intValidation))
            {
                errorProvider1.SetError(txt_UpdtCaseNo, "Please enter number for Client No!");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txt_UpdtCaseDes.Text == "")
            {
                errorProvider2.SetError(txt_UpdtCaseDes, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txt_UpdtCourtName.Text == "")
            {
                errorProvider3.SetError(txt_UpdtCourtName, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (txt_UpdtCaseEvidences.Text == "")
            {
                errorProvider4.SetError(txt_UpdtCaseEvidences, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider4.Clear();
            }

            if (!errors)
            {
                if (rbtn_UpdttrialType.Checked)
                {
                    type = "Trial";
                }
                else
                {
                    type = "Call";
                }

                if (rbtn_UpdtnewStatus.Checked)
                {
                    status = "New";
                }
                else if (rbtn_UpdtpendingStatus.Checked)
                {
                    status = "Pending";
                }
                else
                {
                    status = "Closed";
                }

                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string query = "UPDATE lawdb.cases SET Case_No='" + this.txt_UpdtCaseNo.Text + "',Case_Type='" + type.ToString() + "', Case_Des='" + this.txt_UpdtCaseDes.Text + "',Court_Name='" + this.txt_UpdtCourtName.Text + "',Case_Status='" + status.ToString() + "',Case_Evidences='" + this.txt_UpdtCaseEvidences.Text + "',Case_Date='"+dtp_updatecaseReg.Value.Date.ToString("yyyyMMdd") + "' WHERE Case_ID='" + this.txt_UpdtCaseID.Text + "';";

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

                    string queryx = "SELECT Case_ID,Case_No,Case_Des,Case_Date FROM lawdb.cases WHERE Client_ID='" + this.txt_UpdtCaseCID.Text + "';";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand2 = new MySqlCommand(queryx, MyConn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand2);
                    MyConn2.Open();

                    dgv_Updtresults.DataSource = null;
                    dgv_Updtresults.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_Updtresults.AutoGenerateColumns = false;
                        dgv_Updtresults.ColumnCount = 4;

                        dgv_Updtresults.Columns[0].HeaderText = "Case ID";
                        dgv_Updtresults.Columns[0].DataPropertyName = "Case_ID";

                        dgv_Updtresults.Columns[1].HeaderText = "Case No";
                        dgv_Updtresults.Columns[1].DataPropertyName = "Case_No";

                        dgv_Updtresults.Columns[2].HeaderText = "Case Description";
                        dgv_Updtresults.Columns[2].DataPropertyName = "Case_Des";

                        dgv_Updtresults.Columns[3].HeaderText = "Case Date";
                        dgv_Updtresults.Columns[3].DataPropertyName = "Case_Date";

                        dgv_Updtresults.DataSource = table;
                        MyConn2.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Client or Cases For This Client Id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_UpdtCaseSearch_Click(object sender, EventArgs e)
        {
            if (txt_UpdtCaseCID.Text == "")
            {
                errorProvider1.SetError(txt_UpdtCaseCID, "Please enter Client ID for updating Case!");
            }
            else
            {
                errorProvider1.Clear();
               

                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    string query = "SELECT Case_ID,Case_No,Case_Des,Case_Date FROM lawdb.cases WHERE Client_ID='" + this.txt_UpdtCaseCID.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
                    MyConn.Open();

                    dgv_Updtresults.DataSource = null;
                    dgv_Updtresults.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgv_Updtresults.AutoGenerateColumns = false;
                        dgv_Updtresults.ColumnCount = 4;

                        dgv_Updtresults.Columns[0].HeaderText = "Case ID";
                        dgv_Updtresults.Columns[0].DataPropertyName = "Case_ID";

                        dgv_Updtresults.Columns[1].HeaderText = "Case No";
                        dgv_Updtresults.Columns[1].DataPropertyName = "Case_No";

                        dgv_Updtresults.Columns[2].HeaderText = "Case Description";
                        dgv_Updtresults.Columns[2].DataPropertyName = "Case_Des";

                        dgv_Updtresults.Columns[3].HeaderText = "Case Date";
                        dgv_Updtresults.Columns[3].DataPropertyName = "Case_Date";

                        dgv_Updtresults.DataSource = table;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Client or Cases For This Client Id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_updtCaseClear_Click(object sender, EventArgs e)
        {
            txt_UpdtCaseCID.ResetText();
            txt_UpdtCaseDes.ResetText();
            txt_UpdtCaseNo.ResetText();
            txt_UpdtCaseID.ResetText();
            txt_UpdtCourtName.ResetText();
            txt_UpdtCaseEvidences.ResetText();
            dgv_Updtresults.DataSource = null;
            dgv_Updtresults.Rows.Clear();
            errorProvider1.Clear();
            rbtn_UpdttrialType.Checked = true;
            rbtn_UpdtnewStatus.Checked = true;
        }

        private void dgv_Updtresults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                string query = "SELECT * FROM lawdb.cases WHERE Case_ID='" +dgv_Updtresults.CurrentRow.Cells[0].Value.ToString() + "';";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                MySqlDataReader MyReader;

                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();

                if (MyReader.Read())
                {
                    txt_UpdtCaseID.Text = MyReader.GetString("Case_ID");
                    txt_UpdtCaseNo.Text = MyReader.GetString("Case_No");
                    type = MyReader.GetString("Case_Type");
                    txt_UpdtCaseDes.Text = MyReader.GetString("Case_Des");
                    txt_UpdtCourtName.Text = MyReader.GetString("Court_Name");
                    status = MyReader.GetString("Case_Status");
                    txt_UpdtCaseEvidences.Text = MyReader.GetString("Case_Evidences");
                    dtp_updatecaseReg.Value = MyReader.GetDateTime("Case_Date");

                    if (type == "Trial")
                    {
                        rbtn_UpdttrialType.Checked = true;
                    }
                    else
                    {
                        rbtn_UpdtcallType.Checked = true;
                    }

                    if (status == "New")
                    {
                        rbtn_UpdtnewStatus.Checked = true;
                    }
                    else if (status == "Pending")
                    {
                        rbtn_UpdtpendingStatus.Checked = true;
                    }
                    else
                    {
                        rbtn_UpdtclosedStatus.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("No Data For This Client Id!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
