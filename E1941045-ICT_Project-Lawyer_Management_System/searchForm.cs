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
    public partial class searchForm : Form
    {
        private int intValidation;

        public searchForm()
        {
            InitializeComponent();
        }

        private void btn_searchBack_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }

        private void btn_SearchItem_Click(object sender, EventArgs e)
        {
            if (txt_SearchID.Text == "")
            {
                errorProvider1.SetError(txt_SearchID, "Please enter Client ID for Search!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MyConn.Open();

                    string Query = "SELECT clients.Client_ID, CONCAT( `First_Name`,' ',`Last_Name`) AS Client_Name, clients.Phone_No, cases.Case_ID,cases.Case_Date,cases.Case_Type,cases.Case_Status FROM lawdb.clients INNER JOIN cases ON clients.Client_ID=cases.Client_ID WHERE clients.Client_ID='" + txt_SearchID.Text.ToString() + "';"; 

                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);

                    dgv_SearchResult.DataSource = null;
                    dgv_SearchResult.Rows.Clear();

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        
                        dgv_SearchResult.AutoGenerateColumns = false;
                        dgv_SearchResult.ColumnCount = 7;

                        dgv_SearchResult.Columns[0].HeaderText = "Client ID";
                        dgv_SearchResult.Columns[0].DataPropertyName = "Client_ID";

                        dgv_SearchResult.Columns[1].HeaderText = "Client Name";
                        dgv_SearchResult.Columns[1].DataPropertyName = "Client_Name";

                        dgv_SearchResult.Columns[2].HeaderText = "Case ID";
                        dgv_SearchResult.Columns[2].DataPropertyName = "Case_ID";

                        dgv_SearchResult.Columns[3].HeaderText = "Phone No.";
                        dgv_SearchResult.Columns[3].DataPropertyName = "Phone_No";

                        dgv_SearchResult.Columns[4].HeaderText = "Court Date";
                        dgv_SearchResult.Columns[4].DataPropertyName = "Case_Date";

                        dgv_SearchResult.Columns[5].HeaderText = "Case Type";
                        dgv_SearchResult.Columns[5].DataPropertyName = "Case_Type";

                        dgv_SearchResult.Columns[6].HeaderText = "Status";
                        dgv_SearchResult.Columns[6].DataPropertyName = "Case_Status";

                        dgv_SearchResult.DataSource = table;
                        MyConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Client or Cases for this Client ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
