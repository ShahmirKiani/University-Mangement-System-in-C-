namespace University_Management_System
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            Deletebtn = new Button();
            Editbtn = new Button();
            Savebtn = new Button();
            DepIdCb = new ComboBox();
            SemCb = new ComboBox();
            StdGenCb = new ComboBox();
            label10 = new Label();
            DepNameTb = new TextBox();
            label16 = new Label();
            label12 = new Label();
            StdAddTb = new TextBox();
            label18 = new Label();
            label15 = new Label();
            label14 = new Label();
            label17 = new Label();
            label9 = new Label();
            PhoneTb = new TextBox();
            StdTb = new TextBox();
            panel11 = new Panel();
            label13 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            StdDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            StdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StdDGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Location = new Point(270, 376);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 5);
            panel2.TabIndex = 105;
            // 
            // Deletebtn
            // 
            Deletebtn.AutoEllipsis = true;
            Deletebtn.BackColor = Color.LightGreen;
            Deletebtn.Location = new Point(901, 326);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(115, 34);
            Deletebtn.TabIndex = 104;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.AutoEllipsis = true;
            Editbtn.BackColor = Color.LightGreen;
            Editbtn.Location = new Point(688, 326);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(115, 34);
            Editbtn.TabIndex = 103;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.AutoEllipsis = true;
            Savebtn.BackColor = Color.LightGreen;
            Savebtn.Location = new Point(480, 326);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(115, 34);
            Savebtn.TabIndex = 102;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // DepIdCb
            // 
            DepIdCb.FormattingEnabled = true;
            DepIdCb.Location = new Point(939, 145);
            DepIdCb.Name = "DepIdCb";
            DepIdCb.Size = new Size(123, 33);
            DepIdCb.TabIndex = 100;
            DepIdCb.SelectionChangeCommitted += DepIdCb_SelectionChangeCommitted;
            // 
            // SemCb
            // 
            SemCb.FormattingEnabled = true;
            SemCb.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            SemCb.Location = new Point(492, 263);
            SemCb.Name = "SemCb";
            SemCb.Size = new Size(123, 33);
            SemCb.TabIndex = 99;
            // 
            // StdGenCb
            // 
            StdGenCb.FormattingEnabled = true;
            StdGenCb.Items.AddRange(new object[] { "Male", "Female" });
            StdGenCb.Location = new Point(598, 151);
            StdGenCb.Name = "StdGenCb";
            StdGenCb.Size = new Size(149, 33);
            StdGenCb.TabIndex = 101;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(1068, 110);
            label10.Name = "label10";
            label10.Size = new Size(135, 32);
            label10.TabIndex = 98;
            label10.Text = "Dep Name";
            // 
            // DepNameTb
            // 
            DepNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepNameTb.Location = new Point(1068, 145);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(165, 39);
            DepNameTb.TabIndex = 87;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(939, 110);
            label16.Name = "label16";
            label16.Size = new Size(93, 32);
            label16.TabIndex = 97;
            label16.Text = "Dep ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(753, 110);
            label12.Name = "label12";
            label12.Size = new Size(109, 32);
            label12.TabIndex = 96;
            label12.Text = "Address";
            // 
            // StdAddTb
            // 
            StdAddTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StdAddTb.Location = new Point(753, 145);
            StdAddTb.Multiline = true;
            StdAddTb.Name = "StdAddTb";
            StdAddTb.Size = new Size(180, 99);
            StdAddTb.TabIndex = 90;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.DimGray;
            label18.Location = new Point(492, 212);
            label18.Name = "label18";
            label18.Size = new Size(122, 32);
            label18.TabIndex = 95;
            label18.Text = "Semester";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(598, 110);
            label15.Name = "label15";
            label15.Size = new Size(97, 32);
            label15.TabIndex = 94;
            label15.Text = "Gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(492, 110);
            label14.Name = "label14";
            label14.Size = new Size(83, 32);
            label14.TabIndex = 93;
            label14.Text = "D.O.B";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(268, 212);
            label17.Name = "label17";
            label17.Size = new Size(129, 32);
            label17.TabIndex = 92;
            label17.Text = "Phone No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(268, 110);
            label9.Name = "label9";
            label9.Size = new Size(106, 32);
            label9.TabIndex = 91;
            label9.Text = "Student";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(270, 257);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(213, 39);
            PhoneTb.TabIndex = 89;
            // 
            // StdTb
            // 
            StdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StdTb.Location = new Point(270, 145);
            StdTb.Name = "StdTb";
            StdTb.Size = new Size(213, 39);
            StdTb.TabIndex = 88;
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGreen;
            panel11.Location = new Point(66, 277);
            panel11.Name = "panel11";
            panel11.Size = new Size(156, 5);
            panel11.TabIndex = 86;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightGreen;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(308, 6);
            label13.Name = "label13";
            label13.Size = new Size(791, 32);
            label13.TabIndex = 84;
            label13.Text = "Federal Urdu University of Arts Science and Technology Islamabad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(14, 616);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 83;
            label8.Text = "Log Out";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(66, 572);
            label7.Name = "label7";
            label7.Size = new Size(85, 32);
            label7.TabIndex = 82;
            label7.Text = "Salary";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(65, 505);
            label6.Name = "label6";
            label6.Size = new Size(53, 32);
            label6.TabIndex = 81;
            label6.Text = "Fee";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(66, 440);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 80;
            label5.Text = "Courses";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(66, 376);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 85;
            label4.Text = "Faculty";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(65, 309);
            label3.Name = "label3";
            label3.Size = new Size(154, 32);
            label3.TabIndex = 79;
            label3.Text = "Department";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(66, 242);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 78;
            label2.Text = "Student";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(14, 555);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 75;
            pictureBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(66, 178);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 77;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(14, 488);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 74;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(14, 423);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 73;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 359);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 72;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 292);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 71;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Location = new Point(252, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 674);
            panel1.TabIndex = 68;
            // 
            // StdDOB
            // 
            StdDOB.Checked = true;
            StdDOB.CustomizableEdges = customizableEdges1;
            StdDOB.Font = new Font("Segoe UI", 9F);
            StdDOB.Format = DateTimePickerFormat.Long;
            StdDOB.Location = new Point(489, 145);
            StdDOB.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StdDOB.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            StdDOB.Name = "StdDOB";
            StdDOB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            StdDOB.Size = new Size(103, 39);
            StdDOB.TabIndex = 205;
            StdDOB.Value = new DateTime(2024, 5, 25, 16, 47, 10, 256);
            // 
            // StdDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 236, 201);
            StdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            StdDGV.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(139, 194, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            StdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            StdDGV.ColumnHeadersHeight = 27;
            StdDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(231, 242, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(177, 214, 134);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            StdDGV.DefaultCellStyle = dataGridViewCellStyle3;
            StdDGV.GridColor = Color.FromArgb(219, 235, 199);
            StdDGV.Location = new Point(270, 387);
            StdDGV.Name = "StdDGV";
            StdDGV.RowHeadersVisible = false;
            StdDGV.RowHeadersWidth = 62;
            StdDGV.Size = new Size(965, 261);
            StdDGV.TabIndex = 208;
            StdDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            StdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(220, 236, 201);
            StdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            StdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            StdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            StdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            StdDGV.ThemeStyle.BackColor = SystemColors.Control;
            StdDGV.ThemeStyle.GridColor = Color.FromArgb(219, 235, 199);
            StdDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(139, 194, 74);
            StdDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            StdDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            StdDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            StdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            StdDGV.ThemeStyle.HeaderStyle.Height = 27;
            StdDGV.ThemeStyle.ReadOnly = false;
            StdDGV.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(231, 242, 219);
            StdDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            StdDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            StdDGV.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            StdDGV.ThemeStyle.RowsStyle.Height = 33;
            StdDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(177, 214, 134);
            StdDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            StdDGV.CellContentClick += StdDGV_CellContentClick;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 663);
            Controls.Add(StdDGV);
            Controls.Add(StdDOB);
            Controls.Add(panel2);
            Controls.Add(Deletebtn);
            Controls.Add(Editbtn);
            Controls.Add(Savebtn);
            Controls.Add(DepIdCb);
            Controls.Add(SemCb);
            Controls.Add(StdGenCb);
            Controls.Add(label10);
            Controls.Add(DepNameTb);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(StdAddTb);
            Controls.Add(label18);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(PhoneTb);
            Controls.Add(StdTb);
            Controls.Add(panel11);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox8);
            Controls.Add(label1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StdDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button Deletebtn;
        private Button Editbtn;
        private Button Savebtn;
        private ComboBox DepIdCb;
        private ComboBox SemCb;
        private ComboBox StdGenCb;
        private Label label10;
        private TextBox DepNameTb;
        private Label label16;
        private Label label12;
        private TextBox StdAddTb;
        private Label label18;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label9;
        private TextBox PhoneTb;
        private TextBox StdTb;
        private Panel panel11;
        private Label label13;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox8;
        private Label label1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker StdDOB;
        private Guna.UI2.WinForms.Guna2DataGridView StdDGV;
    }
}