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
    public partial class updatingForm : Form
    {
        public updatingForm()
        {
            InitializeComponent();
        }

        private void btn_updateClient_Click(object sender, EventArgs e)
        {
            updateClient form8 = new updateClient();
            form8.Show();
            this.Hide();
        }

        private void btn_updateBack_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }

        private void btn_updateCase_Click(object sender, EventArgs e)
        {
            updateCase form9 = new updateCase();
            form9.Show();
            this.Hide();
        }
    }
}
