using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Employee_Management_System_in_Csharp
{
    public partial class frmemployee : Form
    {
        public frmemployee()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txt_empid.Text = "" + GetUniqueKey(2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome fh = new frmHome();
            fh.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_empid.Text == "")
                {
                    MessageBox.Show("Please , Enter Employee ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (txt_empname.Text == "")
                    {
                        MessageBox.Show("Please , Enter Employee Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        if (txt_empaddress.Text == "")
                        {
                            MessageBox.Show("Please , Enter Employee Address", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            if (cmb_gender.Text == "")
                            {
                                MessageBox.Show("Please , Select Employee Gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                if (cmb_position.Text == "")
                                {
                                    MessageBox.Show("Please , Select Employee Position", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                    if (txt_phoneno.Text == "")
                                    {
                                        MessageBox.Show("Please , Enter Employee Phone No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                        if (cmb_education.Text == "")
                                        {
                                            MessageBox.Show("Please , Select Employee Education", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                        else
                                        {
                                            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gangu\EMS\Employee Management System in Csharp\Employee Management System\db_employee.mdf;Integrated Security=True;User Instance=True");

                                            con.Open();

                                            String str = "Insert Into dbemployee(employeeid,employeename,employeeaddress,employeegender,position,dateofbirth,phoneno,education)Values('" + txt_empid.Text + "','" + txt_empname.Text + "','" + txt_empaddress.Text + "','" + cmb_gender.Text + "','" + cmb_position.Text + "','" + dtp_dob.Text + "','" + txt_phoneno.Text + "','" + cmb_education.Text + "')";

                                            SqlCommand cmd = new SqlCommand(str, con);

                                            cmd.ExecuteNonQuery();

                                            String str2 = "Select max(employeeid) from dbemployee";

                                            SqlCommand cmd2 = new SqlCommand(str2, con);

                                            SqlDataReader dr = cmd2.ExecuteReader();

                                            if (dr.Read())
                                            {
                                                showdata();

                                                MessageBox.Show("Employee Added Successfull", "Thank You.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Employee Added Failed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }
                                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            auto();
        }

        private void frmemployee_Load(object sender, EventArgs e)
        {
            showdata();
            txt_empid.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_empid.Text == "")
                {
                    MessageBox.Show("Please , Enter Employee ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (txt_empname.Text == "")
                    {
                        MessageBox.Show("Please , Enter Employee Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        if (txt_empaddress.Text == "")
                        {
                            MessageBox.Show("Please , Enter Employee Address", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            if (cmb_gender.Text == "")
                            {
                                MessageBox.Show("Please , Select Employee Gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                if (cmb_position.Text == "")
                                {
                                    MessageBox.Show("Please , Select Employee Position", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                    if (txt_phoneno.Text == "")
                                    {
                                        MessageBox.Show("Please , Enter Employee Phone No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                        if (cmb_education.Text == "")
                                        {
                                            MessageBox.Show("Please , Select Employee Education", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                        else
                                        {
                                            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gangu\Downloads\EMS\Employee Management System in Csharp\Employee Management System in Csharp\db_employee.mdf;Integrated Security=True;User Instance=True");

                                            con.Open();

                                            String str = "Update dbemployee set employeename = '" + txt_empname.Text + "',employeeaddress = '" + txt_empaddress.Text + "',employeegender = '" + cmb_gender.Text + "',position = '" + cmb_position.Text + "',dateofbirth = '" + dtp_dob.Text + "',phoneno = '" + txt_phoneno.Text + "',education = '" + cmb_education.Text + "' Where employeeid = '" + txt_empid.Text + "'";

                                            SqlCommand cmd = new SqlCommand(str, con);

                                            cmd.ExecuteNonQuery();

                                            String str2 = "Select max(employeeid) from dbemployee";

                                            SqlCommand cmd2 = new SqlCommand(str2, con);

                                            SqlDataReader dr = cmd2.ExecuteReader();

                                            if (dr.Read())
                                            {
                                                showdata();
                                                MessageBox.Show("Employee Updated Successfull", "Thank You.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Employee Updated Failed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }
                                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showdata()
        {

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gangu\EMS\Employee Management System in Csharp\Employee Management System\db_employee.mdf;Integrated Security=True;User Instance=True");

            con.Open();

            String str = "Select * From dbemployee";

            SqlCommand cmd = new SqlCommand(str, con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dbemployeeDataGridView.DataSource = dt;

            con.Close();

        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_empid.Text == "")
                {
                    MessageBox.Show("Please , Enter Employee ID", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (txt_empname.Text == "")
                    {
                        MessageBox.Show("Please , Enter Employee Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        if (txt_empaddress.Text == "")
                        {
                            MessageBox.Show("Please , Enter Employee Address", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            if (cmb_gender.Text == "")
                            {
                                MessageBox.Show("Please , Select Employee Gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                if (cmb_position.Text == "")
                                {
                                    MessageBox.Show("Please , Select Employee Position", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                    if (txt_phoneno.Text == "")
                                    {
                                        MessageBox.Show("Please , Enter Employee Phone No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                        if (cmb_education.Text == "")
                                        {
                                            MessageBox.Show("Please , Select Employee Education", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                        else
                                        {
                                            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\gangu\EMS\Employee Management System in Csharp\Employee Management System\db_employee.mdf;Integrated Security=True;User Instance=True");

                                            con.Open();

                                            String str = "Delete From dbemployee Where employeeid = '" + txt_empid.Text + "'";

                                            SqlCommand cmd = new SqlCommand(str, con);

                                            cmd.ExecuteNonQuery();

                                            String str2 = "Select max(employeeid) from dbemployee";

                                            SqlCommand cmd2 = new SqlCommand(str2, con);

                                            SqlDataReader dr = cmd2.ExecuteReader();

                                            if (dr.Read())
                                            {
                                                showdata();

                                                MessageBox.Show("Employee Deleted Successfull", "Thank You.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Employee Deleted Failed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            }
                                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txt_empid.Clear();
            txt_empname.Clear();
            txt_phoneno.Clear();
            txt_empaddress.Clear();

            cmb_gender.Text = "";
            cmb_position.Text = "";
            cmb_education.Text = "";

            dtp_dob.Text = "";
        }

        private void dbemployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dbemployeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbemployee);

        }

        private void dbemployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dbemployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            index = e.RowIndex;

            DataGridViewRow dgvr = dbemployeeDataGridView.Rows[index];

            txt_empid.Text = dgvr.Cells[0].Value.ToString();
            txt_empname.Text = dgvr.Cells[1].Value.ToString();
            txt_empaddress.Text = dgvr.Cells[2].Value.ToString();
            cmb_gender.Text = dgvr.Cells[3].Value.ToString();
            cmb_position.Text = dgvr.Cells[4].Value.ToString();
            dtp_dob.Text = dgvr.Cells[5].Value.ToString();
            txt_phoneno.Text = dgvr.Cells[6].Value.ToString();
            cmb_education.Text = dgvr.Cells[7].Value.ToString();
            
        }


    }
}