using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System_in_Csharp
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "admin" && txt_Password.Text == "admin")
            {
                this.Hide();
                frmHome fh = new frmHome();
                fh.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Invalid Login Information", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
