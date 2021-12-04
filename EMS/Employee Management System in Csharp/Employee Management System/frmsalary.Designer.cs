namespace Employee_Management_System_in_Csharp
{
    partial class frmsalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsalary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_education = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_workeddays = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dailysalaryrs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_empaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1733, 34);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1733, 93);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Employee_Management_System_in_Csharp.Properties.Resources.icons8_logout_rounded_up_64px;
            this.pictureBox2.Location = new System.Drawing.Point(1477, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 41);
            this.label1.TabIndex = 84;
            this.label1.Text = "Manage Employee Salary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_Management_System_in_Csharp.Properties.Resources.icons8_paycheque_60px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_education);
            this.panel4.Controls.Add(this.txtdob);
            this.panel4.Controls.Add(this.txt_position);
            this.panel4.Controls.Add(this.txt_gender);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txt_workeddays);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_dailysalaryrs);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_empaddress);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_print);
            this.panel4.Controls.Add(this.txt_empid);
            this.panel4.Controls.Add(this.btn_view);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_empname);
            this.panel4.Controls.Add(this.txt_phoneno);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 611);
            this.panel4.TabIndex = 107;
            // 
            // txt_education
            // 
            this.txt_education.BackColor = System.Drawing.Color.White;
            this.txt_education.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_education.ForeColor = System.Drawing.Color.Black;
            this.txt_education.Location = new System.Drawing.Point(371, 346);
            this.txt_education.Multiline = true;
            this.txt_education.Name = "txt_education";
            this.txt_education.Size = new System.Drawing.Size(313, 49);
            this.txt_education.TabIndex = 113;
            // 
            // txtdob
            // 
            this.txtdob.BackColor = System.Drawing.Color.White;
            this.txtdob.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.ForeColor = System.Drawing.Color.Black;
            this.txtdob.Location = new System.Drawing.Point(371, 251);
            this.txtdob.Multiline = true;
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(313, 49);
            this.txtdob.TabIndex = 112;
            // 
            // txt_position
            // 
            this.txt_position.BackColor = System.Drawing.Color.White;
            this.txt_position.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position.ForeColor = System.Drawing.Color.Black;
            this.txt_position.Location = new System.Drawing.Point(33, 251);
            this.txt_position.Multiline = true;
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(313, 49);
            this.txt_position.TabIndex = 111;
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.Color.White;
            this.txt_gender.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender.ForeColor = System.Drawing.Color.Black;
            this.txt_gender.Location = new System.Drawing.Point(371, 155);
            this.txt_gender.Multiline = true;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(313, 49);
            this.txt_gender.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label10.Location = new System.Drawing.Point(7, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 107;
            this.label10.Text = "Worked Days :";
            // 
            // txt_workeddays
            // 
            this.txt_workeddays.BackColor = System.Drawing.Color.White;
            this.txt_workeddays.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workeddays.ForeColor = System.Drawing.Color.Black;
            this.txt_workeddays.Location = new System.Drawing.Point(29, 440);
            this.txt_workeddays.Multiline = true;
            this.txt_workeddays.Name = "txt_workeddays";
            this.txt_workeddays.Size = new System.Drawing.Size(314, 45);
            this.txt_workeddays.TabIndex = 106;
            this.txt_workeddays.TextChanged += new System.EventHandler(this.txt_workeddays_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label11.Location = new System.Drawing.Point(347, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 29);
            this.label11.TabIndex = 109;
            this.label11.Text = "Daily Salary Rs :";
            // 
            // txt_dailysalaryrs
            // 
            this.txt_dailysalaryrs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dailysalaryrs.BackColor = System.Drawing.Color.White;
            this.txt_dailysalaryrs.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dailysalaryrs.ForeColor = System.Drawing.Color.Black;
            this.txt_dailysalaryrs.Location = new System.Drawing.Point(371, 440);
            this.txt_dailysalaryrs.Multiline = true;
            this.txt_dailysalaryrs.Name = "txt_dailysalaryrs";
            this.txt_dailysalaryrs.Size = new System.Drawing.Size(313, 45);
            this.txt_dailysalaryrs.TabIndex = 108;
            this.txt_dailysalaryrs.TextChanged += new System.EventHandler(this.txt_dailysalaryrs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 82;
            this.label2.Text = "Employee ID :";
            // 
            // txt_empaddress
            // 
            this.txt_empaddress.BackColor = System.Drawing.Color.White;
            this.txt_empaddress.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empaddress.ForeColor = System.Drawing.Color.Black;
            this.txt_empaddress.Location = new System.Drawing.Point(33, 155);
            this.txt_empaddress.Multiline = true;
            this.txt_empaddress.Name = "txt_empaddress";
            this.txt_empaddress.Size = new System.Drawing.Size(313, 49);
            this.txt_empaddress.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 81;
            this.label3.Text = "Employee Address :";
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(480, 522);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(170, 50);
            this.btn_print.TabIndex = 103;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_empid
            // 
            this.txt_empid.BackColor = System.Drawing.Color.White;
            this.txt_empid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.ForeColor = System.Drawing.Color.Black;
            this.txt_empid.Location = new System.Drawing.Point(29, 63);
            this.txt_empid.Multiline = true;
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(317, 45);
            this.txt_empid.TabIndex = 80;
            this.txt_empid.TextChanged += new System.EventHandler(this.txt_empid_TextChanged);
            // 
            // btn_view
            // 
            this.btn_view.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(276, 522);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(170, 50);
            this.btn_view.TabIndex = 102;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label5.Location = new System.Drawing.Point(347, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 86;
            this.label5.Text = "Employee Name :";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(67, 522);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(170, 50);
            this.btn_clear.TabIndex = 101;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(347, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "Employee Gender :";
            // 
            // txt_empname
            // 
            this.txt_empname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_empname.BackColor = System.Drawing.Color.White;
            this.txt_empname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empname.ForeColor = System.Drawing.Color.Black;
            this.txt_empname.Location = new System.Drawing.Point(371, 63);
            this.txt_empname.Multiline = true;
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(313, 45);
            this.txt_empname.TabIndex = 84;
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.BackColor = System.Drawing.Color.White;
            this.txt_phoneno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneno.ForeColor = System.Drawing.Color.Black;
            this.txt_phoneno.Location = new System.Drawing.Point(33, 346);
            this.txt_phoneno.Multiline = true;
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(313, 45);
            this.txt_phoneno.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label9.Location = new System.Drawing.Point(11, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 90;
            this.label9.Text = "Position :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label8.Location = new System.Drawing.Point(11, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 89;
            this.label8.Text = "Phone No. :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label6.Location = new System.Drawing.Point(347, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 29);
            this.label6.TabIndex = 93;
            this.label6.Text = "Education :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label7.Location = new System.Drawing.Point(347, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 94;
            this.label7.Text = "Date of Birth :";
            // 
            // txtPrint
            // 
            this.txtPrint.BackColor = System.Drawing.Color.White;
            this.txtPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrint.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrint.Location = new System.Drawing.Point(720, 93);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(1013, 611);
            this.txtPrint.TabIndex = 109;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmsalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1733, 738);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmsalary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_empaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_workeddays;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dailysalaryrs;
        private System.Windows.Forms.TextBox txt_education;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}