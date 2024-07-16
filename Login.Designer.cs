namespace University_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            DepLbl = new Label();
            label12 = new Label();
            label13 = new Label();
            UNameTb = new TextBox();
            label1 = new Label();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            ResetBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(DepLbl);
            panel2.Location = new Point(-2, -7);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 671);
            panel2.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 441);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 2;
            label4.Text = "Education";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 384);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 2;
            label3.Text = "Unity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 321);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 2;
            label2.Text = "Discipline";
            // 
            // DepLbl
            // 
            DepLbl.AutoSize = true;
            DepLbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepLbl.Location = new Point(100, 258);
            DepLbl.Name = "DepLbl";
            DepLbl.Size = new Size(134, 32);
            DepLbl.TabIndex = 2;
            DepLbl.Text = "Excellence";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(606, 237);
            label12.Name = "label12";
            label12.Size = new Size(135, 32);
            label12.TabIndex = 2;
            label12.Text = "UserName";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.LightGreen;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(374, 19);
            label13.Name = "label13";
            label13.Size = new Size(791, 32);
            label13.TabIndex = 27;
            label13.Text = "Federal Urdu University of Arts Science and Technology Islamabad";
            // 
            // UNameTb
            // 
            UNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UNameTb.Location = new Point(606, 283);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(323, 39);
            UNameTb.TabIndex = 227;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 343);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(606, 392);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(323, 39);
            PasswordTb.TabIndex = 227;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoEllipsis = true;
            LoginBtn.BackColor = Color.LightGreen;
            LoginBtn.Location = new Point(606, 453);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(115, 34);
            LoginBtn.TabIndex = 232;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.AutoEllipsis = true;
            ResetBtn.BackColor = Color.LightGreen;
            ResetBtn.Location = new Point(814, 453);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(115, 34);
            ResetBtn.TabIndex = 232;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 663);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label DepLbl;
        private Label label12;
        private Label label13;
        private TextBox UNameTb;
        private Label label1;
        private TextBox PasswordTb;
        private Button LoginBtn;
        private Button ResetBtn;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}