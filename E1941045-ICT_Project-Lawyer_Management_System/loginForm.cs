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
    public partial class loginForm : Form
    {
        private string userName, passWord; 

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
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
                    passWord = MyReader.GetString("password");
                    userName = MyReader.GetString("username");
                }
                MyConn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_uName.Text == userName.ToString() && txt_uPassword.Text == passWord.ToString())
            {
                mainMenu form2 = new mainMenu();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_uName.ResetText();
                txt_uPassword.ResetText();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
