using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System_in_Csharp
{
    public partial class frmview : Form
    {
        public frmview()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome fh = new frmHome();
            fh.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_empid_TextChanged(object sender, EventArgs e)
        {
            if (txt_empid.Text == "")
            {
                 cleardata();
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_empid.Text == "")
                {
                    MessageBox.Show("Please , Enter Employee ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata();
                }
                else 
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gangu\EMS\Employee Management System in Csharp\Employee Management System\db_employee.mdf;Integrated Security=True;User Instance=True");

                    con.Open();

                    String str = "Select employeeid,employeename,employeeaddress,employeegender,position,dateofbirth,phoneno,education From dbemployee Where employeeid = '" + txt_empid.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read()) 
                    {
                        lbl_empid.Text = dr.GetValue(0).ToString();
                        lbl_empname.Text = dr.GetValue(1).ToString();
                        lbl_empaddress.Text = dr.GetValue(2).ToString();
                        lbl_empgender.Text = dr.GetValue(3).ToString();
                        lbl_empposition.Text = dr.GetValue(4).ToString();
                        lbl_dob.Text = dr.GetValue(5).ToString();
                        lbl_phoneno.Text = dr.GetValue(6).ToString();
                        lbl_education.Text = dr.GetValue(7).ToString();
                       
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cleardata()
        {
            lbl_empid.Text = "";
            lbl_empname.Text = "";
            lbl_empaddress.Text = "";
            lbl_empgender.Text = "";
            lbl_empposition.Text = "";
            lbl_dob.Text = "";
            lbl_phoneno.Text = "";
            lbl_education.Text = "";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_empid.Text == "")
            {
                MessageBox.Show("Please , Enter Employee ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\n\n\t ------------------------- Employee Details -------------------------------", new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 60));
            e.Graphics.DrawString("\n\n\t ID -\t\t" + lbl_empid.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 100));
            e.Graphics.DrawString("\n\n\t Name -\t\t" + lbl_empname.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 140));
            e.Graphics.DrawString("\n\n\t Address -\t" + lbl_empaddress.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 180));
            e.Graphics.DrawString("\n\n\t Gender -\t" + lbl_empgender.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 220));
            e.Graphics.DrawString("\n\n\t Position -\t" + lbl_empposition.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 260));
            e.Graphics.DrawString("\n\n\t Date of Birth -\t" + lbl_dob.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 300));
            e.Graphics.DrawString("\n\n\t Phone No. -\t" + lbl_phoneno.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 340));
            e.Graphics.DrawString("\n\n\t Education -\t" + lbl_education.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 380));
            e.Graphics.DrawString("\n\n\t --------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 420));
          
          
        }
    }
}
