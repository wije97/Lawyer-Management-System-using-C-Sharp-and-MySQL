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
    public partial class viewAllForm : Form
    {
        public viewAllForm()
        {
            InitializeComponent();
        }

        private void btn_viewBack_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }

        private void viewAllForm_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                string query = "SELECT Client_ID,First_Name,Last_Name,NIC,Age,Gender,Address,Phone_No,Reg_Date FROM lawdb.clients";

                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
                MyConn.Open();

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dgv_clientResult.AutoGenerateColumns = false;
                    dgv_clientResult.ColumnCount = 9;

                    dgv_clientResult.Columns[0].HeaderText = "Client ID";
                    dgv_clientResult.Columns[0].DataPropertyName = "Client_ID";

                    dgv_clientResult.Columns[1].HeaderText = "First Name";
                    dgv_clientResult.Columns[1].DataPropertyName = "First_Name";

                    dgv_clientResult.Columns[2].HeaderText = "Last Name";
                    dgv_clientResult.Columns[2].DataPropertyName = "Last_Name";

                    dgv_clientResult.Columns[3].HeaderText = "NIC";
                    dgv_clientResult.Columns[3].DataPropertyName = "NIC";

                    dgv_clientResult.Columns[4].HeaderText = "Age";
                    dgv_clientResult.Columns[4].DataPropertyName = "Age";

                    dgv_clientResult.Columns[5].HeaderText = "Gender";
                    dgv_clientResult.Columns[5].DataPropertyName = "Gender";

                    dgv_clientResult.Columns[6].HeaderText = "Address";
                    dgv_clientResult.Columns[6].DataPropertyName = "Address";

                    dgv_clientResult.Columns[7].HeaderText = "Phone No.";
                    dgv_clientResult.Columns[7].DataPropertyName = "Phone_No";

                    dgv_clientResult.Columns[8].HeaderText = "Reg. Date";
                    dgv_clientResult.Columns[8].DataPropertyName = "Reg_Date";

                    dgv_clientResult.DataSource = table;
                    
                }
                else
                {
                    MessageBox.Show("No Client Data in the System!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MyConn.Close();


                string query2 = "SELECT  Case_ID,Case_No,Case_Type,Case_Des,Court_Name,Case_Date,Case_Status,Client_ID FROM lawdb.cases";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand2 = new MySqlCommand(query2, MyConn2);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(MyCommand2);
                MyConn2.Open();

                DataTable table2 = new DataTable();
                adapter2.Fill(table2);

                if (table2.Rows.Count > 0)
                {
                    dgv_caseResult.AutoGenerateColumns = false;
                    dgv_caseResult.ColumnCount = 8;

                    dgv_caseResult.Columns[0].HeaderText = "Client ID";
                    dgv_caseResult.Columns[0].DataPropertyName = "Client_ID";

                    dgv_caseResult.Columns[1].HeaderText = "Case ID";
                    dgv_caseResult.Columns[1].DataPropertyName = "Case_ID";

                    dgv_caseResult.Columns[2].HeaderText = "Case No";
                    dgv_caseResult.Columns[2].DataPropertyName = "Case_No";

                    dgv_caseResult.Columns[3].HeaderText = "Case Type";
                    dgv_caseResult.Columns[3].DataPropertyName = "Case_Type";

                    dgv_caseResult.Columns[4].HeaderText = "Case Description";
                    dgv_caseResult.Columns[4].DataPropertyName = "Case_Des";

                    dgv_caseResult.Columns[5].HeaderText = "Court Name";
                    dgv_caseResult.Columns[5].DataPropertyName = "Court_Name";

                    dgv_caseResult.Columns[6].HeaderText = "Case Date";
                    dgv_caseResult.Columns[6].DataPropertyName = "Case_Date";

                    dgv_caseResult.Columns[7].HeaderText = "Case Status";
                    dgv_caseResult.Columns[7].DataPropertyName = "Case_Status";

                    dgv_caseResult.DataSource = table2;
                }
                
                MyConn2.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
