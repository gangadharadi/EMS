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
    public partial class frmsalary : Form
    {
        int salary;

        public frmsalary()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome fh = new frmHome();
            fh.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_dailysalaryrs.Clear();
            txt_education.Clear();
            txt_empaddress.Clear();
            txt_empid.Clear();
            txt_empname.Clear();
            txt_gender.Clear();
            txt_phoneno.Clear();
            txt_position.Clear();
            txtPrint.Clear();
            txt_workeddays.Clear();
            txtdob.Clear();
            txt_empid.Focus();
        }

        private void frmsalary_Load(object sender, EventArgs e)
        {
            txt_education.Enabled = false;
            txt_empaddress.Enabled = false;
            txt_empname.Enabled = false;
            txt_gender.Enabled = false;
            txt_phoneno.Enabled = false;
            txt_position.Enabled = false;
            txtPrint.Enabled = false;
            txtdob.Enabled = false;
        }

        private void txt_empid_TextChanged(object sender, EventArgs e)
        {
            if (txt_empid.Text == "")
            {
                txt_dailysalaryrs.Clear();
                txt_education.Clear();
                txt_empaddress.Clear();
                txt_empname.Clear();
                txt_gender.Clear();
                txt_phoneno.Clear();
                txt_position.Clear();
                txtPrint.Clear();
                txt_workeddays.Clear();
                txtdob.Clear();
                txt_empid.Focus();
            }
            else 
            {

                try
                {
                        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gangu\EMS\Employee Management System in Csharp\Employee Management System\db_employee.mdf;Integrated Security=True;User Instance=True");

                        con.Open();

                        String str = "Select employeeid,employeename,employeeaddress,employeegender,position,dateofbirth,phoneno,education From dbemployee Where employeeid = '" + txt_empid.Text + "'";

                        SqlCommand cmd = new SqlCommand(str, con);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            txt_empid.Text = dr.GetValue(0).ToString();
                            txt_empname.Text = dr.GetValue(1).ToString();
                            txt_empaddress.Text = dr.GetValue(2).ToString();
                            txt_gender.Text = dr.GetValue(3).ToString();
                            txt_position.Text = dr.GetValue(4).ToString();
                            txtdob.Text = dr.GetValue(5).ToString();
                            txt_phoneno.Text = dr.GetValue(6).ToString();
                            txt_education.Text = dr.GetValue(7).ToString();

                        }

                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txt_workeddays_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_dailysalaryrs_TextChanged(object sender, EventArgs e)
        {
            if (txt_dailysalaryrs.Text == "")
            {
                txtPrint.Clear();
            }
            else 
            {
                try
                {                   

                    salary = Int32.Parse(txt_workeddays.Text) * Int32.Parse(txt_dailysalaryrs.Text);

                    txtPrint.Text = salary.ToString();
                }
                catch (Exception)
                {

                }
            }
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            txtPrint.Clear();

            txtPrint.AppendText("- Employee Salary Receipt -\n"+ Environment.NewLine);
            txtPrint.AppendText("--------------------------------------------\n" + Environment.NewLine);
            txtPrint.AppendText("Employee ID -:" + txt_empid.Text + "\n" + Environment.NewLine);
            txtPrint.AppendText("Employee Name -:" + txt_empname.Text + "\n" + Environment.NewLine);
            txtPrint.AppendText("Employee Address-:" + txt_empaddress.Text + "\n"+ Environment.NewLine);
            txtPrint.AppendText("Employee Phone No-:" + txt_phoneno.Text + "\n" + Environment.NewLine);
            txtPrint.AppendText("Worked Day -:" + txt_workeddays.Text + "\n" + Environment.NewLine);
            txtPrint.AppendText("--------------------------------------------\n" + Environment.NewLine);
            txtPrint.AppendText("Salary -:" + salary + "Rs.\n" + Environment.NewLine);
            txtPrint.AppendText("--------------------------------------------\n" + Environment.NewLine);
       
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtPrint.Text, new Font("Palatino Linotype", 16, FontStyle.Bold), Brushes.Blue, new Point(40, 60));
           
        }
    }
}
