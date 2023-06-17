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
    public partial class chooseDeleting : Form
    {
        public chooseDeleting()
        {
            InitializeComponent();
        }

        private void btn_deleteBack_Click(object sender, EventArgs e)
        {
            mainMenu form2 = new mainMenu();
            form2.Show();
            this.Hide();
        }

        private void btn_deleteCase_Click(object sender, EventArgs e)
        {
            deletingForm form10 = new deletingForm();
            form10.Show();
            this.Hide();
        }

        private void btn_deleteClient_Click(object sender, EventArgs e)
        {
            deleteClient form14 = new deleteClient();
            form14.Show();
            this.Hide();
        }
    }
}
