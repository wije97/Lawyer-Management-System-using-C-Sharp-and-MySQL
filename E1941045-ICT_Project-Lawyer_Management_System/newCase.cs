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
    public partial class newCase : Form
    {
        private string type, status;

        private int intValidation;

        public newCase()
        {
            InitializeComponent();
        }

        private void newCase_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_caseBack_Click(object sender, EventArgs e)
        {
            addingForm form3 = new addingForm();
            form3.Show();
            this.Hide();
        }

        private void btn_CaseSave_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (txt_CaseCID.Text == "")
            {
                errorProvider1.SetError(txt_CaseCID, "Please enter Client ID for this Case!");
                errors = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txt_CaseID.Text == "" )
            {
                errorProvider2.SetError(txt_CaseID, "Please enter number for Case ID!");
                errors = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txt_CaseNo.Text == "" || !int.TryParse(txt_CaseNo.Text, out intValidation))
            {
                errorProvider3.SetError(txt_CaseNo, "Please enter number for Client No!");
                errors = true;
            }
            else
            {
                errorProvider3.Clear();
            }

            if (txt_CaseDes.Text == "")
            {
                errorProvider4.SetError(txt_CaseDes, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider4.Clear();
            }

            if (txt_CourtName.Text == "")
            {
                errorProvider5.SetError(txt_CourtName, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider5.Clear();
            }

            if (txt_CaseEvidences.Text == "")
            {
                errorProvider6.SetError(txt_CaseEvidences, "Please fill the required field!");
                errors = true;
            }
            else
            {
                errorProvider6.Clear();
            }

            if (!errors)
            {
                if (rbtn_callType.Checked)
                {
                    type = "Call";
                }
                else
                {
                    type = "Trial";
                }

                if (rbtn2_newStatus.Checked)
                {
                    status = "New";
                }else if (rbtn2_pendingStatus.Checked)
                {
                    status = "Pending";
                }
                else
                {
                    status = "Closed";
                }

                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database=lawdb; username=root; password=";
                    string Query = "INSERT INTO cases(Case_ID,Case_No,Case_Type,Case_Des,Court_Name,Case_Date,Case_Status,Case_Evidences,Client_ID) " +
                        "values('" + this.txt_CaseID.Text + "','" + this.txt_CaseNo.Text + "','" + type.ToString() + "','" + this.txt_CaseDes.Text + "','" + this.txt_CourtName.Text + "','" + dtp_caseReg.Value.Date.ToString("yyyyMMdd") + "','" + status.ToString() + "','" + this.txt_CaseEvidences.Text + "','" + this.txt_CaseCID.Text + "'); ";

                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;

                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();

                    while (MyReader.Read())
                    {
                    }
                    MyConn.Close();

                    txt_CaseCID.ResetText();
                    txt_CaseID.ResetText();
                    txt_CaseNo.ResetText();
                    txt_CaseDes.ResetText();
                    txt_CourtName.ResetText();
                    txt_CaseEvidences.ResetText();
                    rbtn_trialType.Checked = true;
                    rbtn2_newStatus.Checked = true;
                    dtp_caseReg.ResetText();

                    MessageBox.Show("Added Successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }


        }

        

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }
    }
}
