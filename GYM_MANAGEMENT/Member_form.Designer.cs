namespace GYM_MANAGEMENT
{
    partial class Member_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_form));
            this.label_logout = new System.Windows.Forms.Label();
            this.TextBox_empid = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiom = new System.Windows.Forms.RadioButton();
            this.radiof = new System.Windows.Forms.RadioButton();
            this.TextBox_adress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datetime_join = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_gymytime = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_mobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_staff_ = new System.Windows.Forms.Button();
            this.button_member = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_equipment = new System.Windows.Forms.Button();
            this.TextBox_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_employee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.DataGridView_member = new Guna.UI2.WinForms.Guna2DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYM_MANAGEMEN_dbDataSet = new GYM_MANAGEMENT.GYM_MANAGEMEN_dbDataSet();
            this.membersTableAdapter = new GYM_MANAGEMENT.GYM_MANAGEMEN_dbDataSetTableAdapters.membersTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYM_MANAGEMEN_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Cyan;
            this.label_logout.Location = new System.Drawing.Point(2, 615);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(96, 32);
            this.label_logout.TabIndex = 65;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            // 
            // TextBox_empid
            // 
            this.TextBox_empid.BorderRadius = 18;
            this.TextBox_empid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_empid.DefaultText = "";
            this.TextBox_empid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_empid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_empid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_empid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_empid.Enabled = false;
            this.TextBox_empid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_empid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_empid.ForeColor = System.Drawing.Color.Black;
            this.TextBox_empid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_empid.Location = new System.Drawing.Point(440, 240);
            this.TextBox_empid.Name = "TextBox_empid";
            this.TextBox_empid.PasswordChar = '\0';
            this.TextBox_empid.PlaceholderText = "";
            this.TextBox_empid.ReadOnly = true;
            this.TextBox_empid.SelectedText = "";
            this.TextBox_empid.Size = new System.Drawing.Size(200, 36);
            this.TextBox_empid.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radiom);
            this.panel2.Controls.Add(this.radiof);
            this.panel2.Location = new System.Drawing.Point(135, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 37);
            this.panel2.TabIndex = 47;
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.Location = new System.Drawing.Point(3, 9);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(48, 17);
            this.radiom.TabIndex = 4;
            this.radiom.TabStop = true;
            this.radiom.Text = "Male";
            this.radiom.UseVisualStyleBackColor = true;
            // 
            // radiof
            // 
            this.radiof.AutoSize = true;
            this.radiof.Location = new System.Drawing.Point(93, 11);
            this.radiof.Name = "radiof";
            this.radiof.Size = new System.Drawing.Size(59, 17);
            this.radiof.TabIndex = 5;
            this.radiof.TabStop = true;
            this.radiof.Text = "Female";
            this.radiof.UseVisualStyleBackColor = true;
            // 
            // TextBox_adress
            // 
            this.TextBox_adress.BorderRadius = 18;
            this.TextBox_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_adress.DefaultText = "";
            this.TextBox_adress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_adress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_adress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_adress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_adress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_adress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_adress.ForeColor = System.Drawing.Color.Black;
            this.TextBox_adress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_adress.Location = new System.Drawing.Point(439, 200);
            this.TextBox_adress.Name = "TextBox_adress";
            this.TextBox_adress.PasswordChar = '\0';
            this.TextBox_adress.PlaceholderText = "";
            this.TextBox_adress.SelectedText = "";
            this.TextBox_adress.Size = new System.Drawing.Size(200, 36);
            this.TextBox_adress.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(349, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 28);
            this.label12.TabIndex = 44;
            this.label12.Text = "Adress";
            // 
            // datetime_join
            // 
            this.datetime_join.BackColor = System.Drawing.Color.Cyan;
            this.datetime_join.BorderColor = System.Drawing.Color.White;
            this.datetime_join.BorderRadius = 18;
            this.datetime_join.Checked = true;
            this.datetime_join.FillColor = System.Drawing.Color.White;
            this.datetime_join.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_join.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_join.Location = new System.Drawing.Point(439, 112);
            this.datetime_join.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_join.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_join.Name = "datetime_join";
            this.datetime_join.Size = new System.Drawing.Size(200, 36);
            this.datetime_join.TabIndex = 9;
            this.datetime_join.Value = new System.DateTime(2022, 7, 26, 17, 39, 50, 464);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(349, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 28);
            this.label11.TabIndex = 42;
            this.label11.Text = "Date Join";
            // 
            // TextBox_gymytime
            // 
            this.TextBox_gymytime.BorderRadius = 18;
            this.TextBox_gymytime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_gymytime.DefaultText = "";
            this.TextBox_gymytime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_gymytime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_gymytime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_gymytime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_gymytime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_gymytime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_gymytime.ForeColor = System.Drawing.Color.Black;
            this.TextBox_gymytime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_gymytime.Location = new System.Drawing.Point(439, 157);
            this.TextBox_gymytime.Name = "TextBox_gymytime";
            this.TextBox_gymytime.PasswordChar = '\0';
            this.TextBox_gymytime.PlaceholderText = "";
            this.TextBox_gymytime.SelectedText = "";
            this.TextBox_gymytime.Size = new System.Drawing.Size(200, 36);
            this.TextBox_gymytime.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(349, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 28);
            this.label10.TabIndex = 40;
            this.label10.Text = "GYM Time";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Cyan;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.BorderRadius = 18;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(126, 240);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 6;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 7, 26, 17, 39, 50, 464);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(36, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 28);
            this.label9.TabIndex = 37;
            this.label9.Text = "Date B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 28);
            this.label8.TabIndex = 33;
            this.label8.Text = "Gender";
            // 
            // TextBox_lname
            // 
            this.TextBox_lname.BorderRadius = 18;
            this.TextBox_lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_lname.DefaultText = "";
            this.TextBox_lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_lname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_lname.ForeColor = System.Drawing.Color.Black;
            this.TextBox_lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_lname.Location = new System.Drawing.Point(128, 156);
            this.TextBox_lname.Name = "TextBox_lname";
            this.TextBox_lname.PasswordChar = '\0';
            this.TextBox_lname.PlaceholderText = "";
            this.TextBox_lname.SelectedText = "";
            this.TextBox_lname.Size = new System.Drawing.Size(200, 36);
            this.TextBox_lname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "L_Name";
            // 
            // TextBox_mobile
            // 
            this.TextBox_mobile.BorderRadius = 18;
            this.TextBox_mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_mobile.DefaultText = "";
            this.TextBox_mobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_mobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_mobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_mobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_mobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_mobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_mobile.ForeColor = System.Drawing.Color.Black;
            this.TextBox_mobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_mobile.Location = new System.Drawing.Point(126, 281);
            this.TextBox_mobile.Name = "TextBox_mobile";
            this.TextBox_mobile.PasswordChar = '\0';
            this.TextBox_mobile.PlaceholderText = "";
            this.TextBox_mobile.SelectedText = "";
            this.TextBox_mobile.Size = new System.Drawing.Size(200, 36);
            this.TextBox_mobile.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(349, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Id_emp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mobile";
            // 
            // button_staff_
            // 
            this.button_staff_.BackColor = System.Drawing.Color.Black;
            this.button_staff_.FlatAppearance.BorderSize = 0;
            this.button_staff_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_staff_.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_staff_.ForeColor = System.Drawing.Color.Cyan;
            this.button_staff_.Location = new System.Drawing.Point(2, 198);
            this.button_staff_.Name = "button_staff_";
            this.button_staff_.Size = new System.Drawing.Size(121, 52);
            this.button_staff_.TabIndex = 67;
            this.button_staff_.Text = "Staff";
            this.button_staff_.UseVisualStyleBackColor = false;
            this.button_staff_.Click += new System.EventHandler(this.button_staff__Click);
            // 
            // button_member
            // 
            this.button_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_member.FlatAppearance.BorderSize = 0;
            this.button_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_member.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_member.ForeColor = System.Drawing.Color.Cyan;
            this.button_member.Location = new System.Drawing.Point(2, 121);
            this.button_member.Name = "button_member";
            this.button_member.Size = new System.Drawing.Size(121, 52);
            this.button_member.TabIndex = 68;
            this.button_member.Text = "Member";
            this.button_member.UseVisualStyleBackColor = false;
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.Black;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.Cyan;
            this.button_home.Location = new System.Drawing.Point(2, 39);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(121, 52);
            this.button_home.TabIndex = 70;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_equipment
            // 
            this.button_equipment.BackColor = System.Drawing.Color.Black;
            this.button_equipment.FlatAppearance.BorderSize = 0;
            this.button_equipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equipment.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equipment.ForeColor = System.Drawing.Color.Cyan;
            this.button_equipment.Location = new System.Drawing.Point(2, 276);
            this.button_equipment.Name = "button_equipment";
            this.button_equipment.Size = new System.Drawing.Size(121, 52);
            this.button_equipment.TabIndex = 66;
            this.button_equipment.Text = "Equipment";
            this.button_equipment.UseVisualStyleBackColor = false;
            this.button_equipment.Click += new System.EventHandler(this.button_equipment_Click);
            // 
            // TextBox_email
            // 
            this.TextBox_email.BorderRadius = 18;
            this.TextBox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_email.DefaultText = "";
            this.TextBox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_email.ForeColor = System.Drawing.Color.Black;
            this.TextBox_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_email.Location = new System.Drawing.Point(439, 70);
            this.TextBox_email.Name = "TextBox_email";
            this.TextBox_email.PasswordChar = '\0';
            this.TextBox_email.PlaceholderText = "";
            this.TextBox_email.SelectedText = "";
            this.TextBox_email.Size = new System.Drawing.Size(200, 36);
            this.TextBox_email.TabIndex = 8;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Cyan;
            this.label_exit.Location = new System.Drawing.Point(1032, 4);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(31, 32);
            this.label_exit.TabIndex = 64;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(349, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 18;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(128, 114);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 18;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.Enabled = false;
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(128, 70);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.ReadOnly = true;
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(200, 36);
            this.TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(404, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "MEMBER";
            // 
            // button_employee
            // 
            this.button_employee.BackColor = System.Drawing.Color.Black;
            this.button_employee.FlatAppearance.BorderSize = 0;
            this.button_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee.ForeColor = System.Drawing.Color.Cyan;
            this.button_employee.Location = new System.Drawing.Point(2, 356);
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(121, 52);
            this.button_employee.TabIndex = 69;
            this.button_employee.Text = "Employee";
            this.button_employee.UseVisualStyleBackColor = false;
            this.button_employee.Click += new System.EventHandler(this.button_employee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_empid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TextBox_adress);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.datetime_join);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TextBox_gymytime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.guna2DateTimePicker1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TextBox_lname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TextBox_mobile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataGridView_member);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(129, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 608);
            this.panel1.TabIndex = 63;
            // 
            // button_clear
            // 
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.Black;
            this.button_clear.Location = new System.Drawing.Point(683, 250);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(88, 39);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(683, 200);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(88, 37);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(683, 153);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 35);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(683, 104);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(88, 35);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // DataGridView_member
            // 
            this.DataGridView_member.AllowUserToAddRows = false;
            this.DataGridView_member.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_member.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_member.AutoGenerateColumns = false;
            this.DataGridView_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_member.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_member.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_member.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_member.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_member.ColumnHeadersHeight = 24;
            this.DataGridView_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.datebirthDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.gymtimeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn});
            this.DataGridView_member.DataSource = this.membersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_member.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_member.EnableHeadersVisualStyles = false;
            this.DataGridView_member.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_member.Location = new System.Drawing.Point(6, 372);
            this.DataGridView_member.Name = "DataGridView_member";
            this.DataGridView_member.ReadOnly = true;
            this.DataGridView_member.RowHeadersVisible = false;
            this.DataGridView_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_member.Size = new System.Drawing.Size(920, 233);
            this.DataGridView_member.TabIndex = 17;
            this.DataGridView_member.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_member.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_member.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_member.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_member.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_member.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_member.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_member.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_member.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_member.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_member.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_member.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_member.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_member.ThemeStyle.ReadOnly = true;
            this.DataGridView_member.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_member.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_member.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_member.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_member.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_member.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_member.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_member_CellClick);
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "m_id";
            this.midDataGridViewTextBoxColumn.HeaderText = "m_id";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "f_name";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "f_name";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "l_name";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "l_name";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datebirthDataGridViewTextBoxColumn
            // 
            this.datebirthDataGridViewTextBoxColumn.DataPropertyName = "date_birth";
            this.datebirthDataGridViewTextBoxColumn.HeaderText = "date_birth";
            this.datebirthDataGridViewTextBoxColumn.Name = "datebirthDataGridViewTextBoxColumn";
            this.datebirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "join_date";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "join_date";
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            this.joindateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gymtimeDataGridViewTextBoxColumn
            // 
            this.gymtimeDataGridViewTextBoxColumn.DataPropertyName = "gym_time";
            this.gymtimeDataGridViewTextBoxColumn.HeaderText = "gym_time";
            this.gymtimeDataGridViewTextBoxColumn.Name = "gymtimeDataGridViewTextBoxColumn";
            this.gymtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.gYM_MANAGEMEN_dbDataSet;
            // 
            // gYM_MANAGEMEN_dbDataSet
            // 
            this.gYM_MANAGEMEN_dbDataSet.DataSetName = "GYM_MANAGEMEN_dbDataSet";
            this.gYM_MANAGEMEN_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // Member_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1065, 650);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_staff_);
            this.Controls.Add(this.button_member);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_equipment);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_employee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Member_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member_form";
            this.Load += new System.EventHandler(this.Member_form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYM_MANAGEMEN_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_empid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.RadioButton radiof;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_adress;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_join;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_gymytime;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_lname;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_staff_;
        private System.Windows.Forms.Button button_member;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_equipment;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_email;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_employee;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_member;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private GYM_MANAGEMEN_dbDataSet gYM_MANAGEMEN_dbDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private GYM_MANAGEMEN_dbDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
    }
}