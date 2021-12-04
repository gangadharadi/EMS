namespace Employee_Management_System_in_Csharp
{
    partial class frmemployee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmemployee));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_empaddress = new System.Windows.Forms.TextBox();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_phoneno = new System.Windows.Forms.TextBox();
            this.dbemployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbemployee = new Employee_Management_System_in_Csharp.dbemployee();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.cmb_education = new System.Windows.Forms.ComboBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dbemployeeTableAdapter = new Employee_Management_System_in_Csharp.dbemployeeTableAdapters.dbemployeeTableAdapter();
            this.tableAdapterManager = new Employee_Management_System_in_Csharp.dbemployeeTableAdapters.TableAdapterManager();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 84;
            this.label1.Text = "Manage Employee";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 34);
            this.panel2.TabIndex = 7;
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
            this.panel1.Size = new System.Drawing.Size(1535, 93);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Employee_Management_System_in_Csharp.Properties.Resources.icons8_logout_rounded_up_64px;
            this.pictureBox2.Location = new System.Drawing.Point(1468, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Employee_Management_System_in_Csharp.Properties.Resources.icons8_employee_100px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // txt_empid
            // 
            this.txt_empid.BackColor = System.Drawing.Color.White;
            this.txt_empid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.ForeColor = System.Drawing.Color.Black;
            this.txt_empid.Location = new System.Drawing.Point(29, 63);
            this.txt_empid.Multiline = true;
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(250, 45);
            this.txt_empid.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "Employee Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "Employee ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_empaddress
            // 
            this.txt_empaddress.BackColor = System.Drawing.Color.White;
            this.txt_empaddress.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empaddress.ForeColor = System.Drawing.Color.Black;
            this.txt_empaddress.Location = new System.Drawing.Point(33, 173);
            this.txt_empaddress.Multiline = true;
            this.txt_empaddress.Name = "txt_empaddress";
            this.txt_empaddress.Size = new System.Drawing.Size(313, 49);
            this.txt_empaddress.TabIndex = 83;
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label4.Location = new System.Drawing.Point(347, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 28);
            this.label4.TabIndex = 85;
            this.label4.Text = "Employee Gender :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label5.Location = new System.Drawing.Point(347, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 28);
            this.label5.TabIndex = 86;
            this.label5.Text = "Employee Name :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label6.Location = new System.Drawing.Point(347, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 28);
            this.label6.TabIndex = 93;
            this.label6.Text = "Education :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label7.Location = new System.Drawing.Point(347, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 94;
            this.label7.Text = "Date of Birth :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label8.Location = new System.Drawing.Point(11, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 28);
            this.label8.TabIndex = 89;
            this.label8.Text = "Phone No. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.label9.Location = new System.Drawing.Point(11, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 28);
            this.label9.TabIndex = 90;
            this.label9.Text = "Position :";
            // 
            // txt_phoneno
            // 
            this.txt_phoneno.BackColor = System.Drawing.Color.White;
            this.txt_phoneno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneno.ForeColor = System.Drawing.Color.Black;
            this.txt_phoneno.Location = new System.Drawing.Point(33, 396);
            this.txt_phoneno.Multiline = true;
            this.txt_phoneno.Name = "txt_phoneno";
            this.txt_phoneno.Size = new System.Drawing.Size(313, 45);
            this.txt_phoneno.TabIndex = 91;
            // 
            // dbemployeeDataGridView
            // 
            this.dbemployeeDataGridView.AllowUserToAddRows = false;
            this.dbemployeeDataGridView.AutoGenerateColumns = false;
            this.dbemployeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dbemployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbemployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbemployeeDataGridView.ColumnHeadersHeight = 35;
            this.dbemployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dbemployeeDataGridView.DataSource = this.dbemployeeBindingSource;
            this.dbemployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dbemployeeDataGridView.EnableHeadersVisualStyles = false;
            this.dbemployeeDataGridView.GridColor = System.Drawing.Color.White;
            this.dbemployeeDataGridView.Location = new System.Drawing.Point(726, 93);
            this.dbemployeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.dbemployeeDataGridView.Name = "dbemployeeDataGridView";
            this.dbemployeeDataGridView.RowHeadersVisible = false;
            this.dbemployeeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dbemployeeDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbemployeeDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dbemployeeDataGridView.RowTemplate.Height = 24;
            this.dbemployeeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dbemployeeDataGridView.Size = new System.Drawing.Size(809, 611);
            this.dbemployeeDataGridView.TabIndex = 0;
            this.dbemployeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbemployeeDataGridView_CellClick);
            this.dbemployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbemployeeDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "employeeid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "employeename";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "employeeaddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "employeegender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateofbirth";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date of Birth";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phoneno";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone No.";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "education";
            this.dataGridViewTextBoxColumn8.HeaderText = "Education";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dbemployeeBindingSource
            // 
            this.dbemployeeBindingSource.DataMember = "dbemployee";
            this.dbemployeeBindingSource.DataSource = this.dbemployee;
            // 
            // dbemployee
            // 
            this.dbemployee.DataSetName = "dbemployee";
            this.dbemployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_gender
            // 
            this.cmb_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_gender.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_gender.Location = new System.Drawing.Point(371, 173);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(313, 49);
            this.cmb_gender.TabIndex = 97;
            // 
            // cmb_position
            // 
            this.cmb_position.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Items.AddRange(new object[] {
            "Android Devloper",
            "Software Devloper",
            "Web Devloper",
            "PHP Devloper",
            "Web Designer",
            "Wordpress Devloper",
            "Graphics Designer"});
            this.cmb_position.Location = new System.Drawing.Point(33, 285);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(313, 49);
            this.cmb_position.TabIndex = 98;
            // 
            // cmb_education
            // 
            this.cmb_education.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_education.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.cmb_education.FormattingEnabled = true;
            this.cmb_education.Items.AddRange(new object[] {
            "BSC.CS",
            "BCA",
            "MSC.CS",
            "MCA",
            "BBA",
            "MBA IT",
            "B.TECH",
            "M.TECH"});
            this.cmb_education.Location = new System.Drawing.Point(371, 396);
            this.cmb_education.Name = "cmb_education";
            this.cmb_education.Size = new System.Drawing.Size(313, 49);
            this.cmb_education.TabIndex = 99;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_dob.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(371, 282);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(313, 48);
            this.dtp_dob.TabIndex = 100;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(67, 471);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(170, 50);
            this.btn_save.TabIndex = 101;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(276, 471);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(170, 50);
            this.btn_edit.TabIndex = 102;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(480, 471);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(170, 50);
            this.btn_remove.TabIndex = 103;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(162)))), ((int)(((byte)(209)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(67, 540);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(583, 50);
            this.btn_clear.TabIndex = 104;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(285, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 105;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dbemployeeTableAdapter
            // 
            this.dbemployeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dbemployeeTableAdapter = this.dbemployeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Employee_Management_System_in_Csharp.dbemployeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.txt_empaddress);
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btn_remove);
            this.panel4.Controls.Add(this.txt_empid);
            this.panel4.Controls.Add(this.btn_edit);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtp_dob);
            this.panel4.Controls.Add(this.txt_empname);
            this.panel4.Controls.Add(this.cmb_education);
            this.panel4.Controls.Add(this.txt_phoneno);
            this.panel4.Controls.Add(this.cmb_position);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cmb_gender);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 611);
            this.panel4.TabIndex = 106;
            // 
            // frmemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1535, 738);
            this.Controls.Add(this.dbemployeeDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmemployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmemployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbemployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_empaddress;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_phoneno;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.ComboBox cmb_education;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox pictureBox3;
        private dbemployee dbemployee;
        private System.Windows.Forms.BindingSource dbemployeeBindingSource;
        private dbemployeeTableAdapters.dbemployeeTableAdapter dbemployeeTableAdapter;
        private dbemployeeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dbemployeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Panel panel4;

    }
}