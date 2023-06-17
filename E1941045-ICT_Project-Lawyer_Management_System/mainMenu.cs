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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                string date1 = DateTime.Now.ToString("yyyyMMdd");
                string date2 = DateTime.Now.AddDays(7).ToString("yyyyMMdd");

                string MyConnection = "datasource=localhost; port=3306; database= lawdb; username=root; password=";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MyConn.Open();

                string Query = "SELECT CONCAT( `First_Name`,' ',`Last_Name`) AS Client_Name, cases.Case_No,cases.Court_Name,cases.Case_Type,cases.Case_Date FROM lawdb.clients INNER JOIN cases ON clients.Client_ID=cases.Client_ID WHERE cases.Case_Date BETWEEN'" + date1 + "'AND'" + date2 + "';";

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);

                dgv_Recent.DataSource = null;
                dgv_Recent.Rows.Clear();

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {

                    dgv_Recent.AutoGenerateColumns = false;
                    dgv_Recent.ColumnCount = 5;

                    dgv_Recent.Columns[0].HeaderText = "Client Name";
                    dgv_Recent.Columns[0].DataPropertyName = "Client_Name";

                    dgv_Recent.Columns[1].HeaderText = "Case No";
                    dgv_Recent.Columns[1].DataPropertyName = "Case_No";

                    dgv_Recent.Columns[2].HeaderText = "Court Name";
                    dgv_Recent.Columns[2].DataPropertyName = "Court_Name";

                    dgv_Recent.Columns[3].HeaderText = "Case Type";
                    dgv_Recent.Columns[3].DataPropertyName = "Case_Type";

                    dgv_Recent.Columns[4].HeaderText = "Court Date";
                    dgv_Recent.Columns[4].DataPropertyName = "Case_Date";

                    dgv_Recent.DataSource = table;
                    MyConn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addingForm form3 = new addingForm();
            form3.Show();
            this.Hide();
        }

        private void btn_Exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchForm form6 = new searchForm();
            form6.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            updatingForm form7 = new updatingForm();
            form7.Show();
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            chooseDeleting form13 = new chooseDeleting();
            form13.Show();
            this.Hide();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            viewAllForm form11 = new viewAllForm();
            form11.Show();
            this.Hide();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            emailingForm form12 = new emailingForm();
            form12.Show();
            this.Hide();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settingsForm form15 = new settingsForm();
            form15.Show();
        }
    }
}
