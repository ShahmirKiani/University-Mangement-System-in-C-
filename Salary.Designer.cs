namespace University_Management_System
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PayDate = new Label();
            panel2 = new Panel();
            ResetBtn = new Button();
            PayBtn = new Button();
            ProfId = new ComboBox();
            label10 = new Label();
            Amount = new TextBox();
            label11 = new Label();
            ProfNameTb = new TextBox();
            label15 = new Label();
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
            PayDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SalaryDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).BeginInit();
            SuspendLayout();
            // 
            // PayDate
            // 
            PayDate.AutoSize = true;
            PayDate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayDate.ForeColor = Color.DimGray;
            PayDate.Location = new Point(769, 150);
            PayDate.Name = "PayDate";
            PayDate.Size = new Size(118, 32);
            PayDate.TabIndex = 234;
            PayDate.Text = "Pay Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Location = new Point(263, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 5);
            panel2.TabIndex = 233;
            // 
            // ResetBtn
            // 
            ResetBtn.AutoEllipsis = true;
            ResetBtn.BackColor = Color.LightGreen;
            ResetBtn.Location = new Point(784, 272);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(115, 34);
            ResetBtn.TabIndex = 232;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // PayBtn
            // 
            PayBtn.AutoEllipsis = true;
            PayBtn.BackColor = Color.LightGreen;
            PayBtn.Location = new Point(591, 272);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(115, 34);
            PayBtn.TabIndex = 231;
            PayBtn.Text = "Pay";
            PayBtn.UseVisualStyleBackColor = false;
            PayBtn.Click += PayBtn_Click;
            // 
            // ProfId
            // 
            ProfId.FormattingEnabled = true;
            ProfId.Location = new Point(351, 195);
            ProfId.Name = "ProfId";
            ProfId.Size = new Size(138, 33);
            ProfId.TabIndex = 230;
            ProfId.SelectionChangeCommitted += ProfId_SelectionChangeCommitted;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(958, 150);
            label10.Name = "label10";
            label10.Size = new Size(110, 32);
            label10.TabIndex = 229;
            label10.Text = "Amount";
            // 
            // Amount
            // 
            Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.Location = new Point(958, 185);
            Amount.Name = "Amount";
            Amount.Size = new Size(169, 39);
            Amount.TabIndex = 226;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(533, 150);
            label11.Name = "label11";
            label11.Size = new Size(173, 32);
            label11.TabIndex = 228;
            label11.Text = "Faculty Name";
            // 
            // ProfNameTb
            // 
            ProfNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfNameTb.Location = new Point(533, 189);
            ProfNameTb.Name = "ProfNameTb";
            ProfNameTb.Size = new Size(195, 39);
            ProfNameTb.TabIndex = 225;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(351, 150);
            label15.Name = "label15";
            label15.Size = new Size(131, 32);
            label15.TabIndex = 227;
            label15.Text = "Faculty ID";
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGreen;
            panel11.Location = new Point(61, 607);
            panel11.Name = "panel11";
            panel11.Size = new Size(112, 5);
            panel11.TabIndex = 224;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightGreen;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(303, 6);
            label13.Name = "label13";
            label13.Size = new Size(791, 32);
            label13.TabIndex = 222;
            label13.Text = "Federal Urdu University of Arts Science and Technology Islamabad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(9, 616);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 221;
            label8.Text = "Log Out";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(61, 572);
            label7.Name = "label7";
            label7.Size = new Size(85, 32);
            label7.TabIndex = 220;
            label7.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(60, 505);
            label6.Name = "label6";
            label6.Size = new Size(53, 32);
            label6.TabIndex = 219;
            label6.Text = "Fee";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(61, 440);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 218;
            label5.Text = "Courses";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(61, 376);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 223;
            label4.Text = "Faculty";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(60, 309);
            label3.Name = "label3";
            label3.Size = new Size(154, 32);
            label3.TabIndex = 217;
            label3.Text = "Department";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(61, 242);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 216;
            label2.Text = "Student";
            label2.Click += label2_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(9, 555);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 213;
            pictureBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(61, 178);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 215;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 488);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 212;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 423);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 211;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 359);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 210;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 292);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 209;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 208;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 207;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 214;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Location = new Point(247, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 674);
            panel1.TabIndex = 206;
            // 
            // PayDateTb
            // 
            PayDateTb.Checked = true;
            PayDateTb.CustomizableEdges = customizableEdges1;
            PayDateTb.Font = new Font("Segoe UI", 9F);
            PayDateTb.Format = DateTimePickerFormat.Long;
            PayDateTb.Location = new Point(769, 189);
            PayDateTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            PayDateTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            PayDateTb.Name = "PayDateTb";
            PayDateTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PayDateTb.Size = new Size(154, 39);
            PayDateTb.TabIndex = 235;
            PayDateTb.Value = new DateTime(2024, 5, 25, 16, 47, 10, 256);
            // 
            // SalaryDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 236, 201);
            SalaryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SalaryDGV.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(139, 194, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SalaryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SalaryDGV.ColumnHeadersHeight = 27;
            SalaryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(231, 242, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(177, 214, 134);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SalaryDGV.DefaultCellStyle = dataGridViewCellStyle3;
            SalaryDGV.GridColor = Color.FromArgb(219, 235, 199);
            SalaryDGV.Location = new Point(263, 359);
            SalaryDGV.Name = "SalaryDGV";
            SalaryDGV.RowHeadersVisible = false;
            SalaryDGV.RowHeadersWidth = 62;
            SalaryDGV.Size = new Size(974, 289);
            SalaryDGV.TabIndex = 236;
            SalaryDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            SalaryDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(220, 236, 201);
            SalaryDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalaryDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SalaryDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SalaryDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SalaryDGV.ThemeStyle.BackColor = SystemColors.Control;
            SalaryDGV.ThemeStyle.GridColor = Color.FromArgb(219, 235, 199);
            SalaryDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(139, 194, 74);
            SalaryDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SalaryDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            SalaryDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SalaryDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalaryDGV.ThemeStyle.HeaderStyle.Height = 27;
            SalaryDGV.ThemeStyle.ReadOnly = false;
            SalaryDGV.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(231, 242, 219);
            SalaryDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalaryDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            SalaryDGV.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            SalaryDGV.ThemeStyle.RowsStyle.Height = 33;
            SalaryDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(177, 214, 134);
            SalaryDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 663);
            Controls.Add(SalaryDGV);
            Controls.Add(PayDateTb);
            Controls.Add(PayDate);
            Controls.Add(panel2);
            Controls.Add(ResetBtn);
            Controls.Add(PayBtn);
            Controls.Add(ProfId);
            Controls.Add(label10);
            Controls.Add(Amount);
            Controls.Add(label11);
            Controls.Add(ProfNameTb);
            Controls.Add(label15);
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
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PayDate;
        private Panel panel2;
        private Button ResetBtn;
        private Button PayBtn;
        private ComboBox ProfId;
        private Label label10;
        private TextBox Amount;
        private Label label11;
        private TextBox ProfNameTb;
        private Label label15;
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
        private Guna.UI2.WinForms.Guna2DateTimePicker PayDateTb;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryDGV;
    }
}