using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1941045_ICT_Project_Lawyer_Management_System
{
    public partial class addingForm : Form
    {
        public addingForm()
        {
            InitializeComponent();
        }

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            newClient form4 = new newClient();
            form4.Show();
            this.Hide();
        }

        private void btn_newCase_Click(object sender, EventArgs e)
        {
            newCase form5 = new newCase();
            form5.Show();
            this.Hide();
        }

        private void btn_addBack_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }
    }
}
