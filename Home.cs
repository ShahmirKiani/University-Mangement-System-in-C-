using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CountStudents();
            CountProf();
            CountDepartment();
            CountFee();
            CountSalary();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shahm\Documents\UniversityDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void CountSalary()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(PrSalary) from SalaryTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SalaryLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountFee()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(FAmount) from FeeTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FeeLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountStudents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StdLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountProf()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from FacultyTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FacultyLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDepartment()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DepartmentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DepLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Department Obj = new Department();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Faculty Obj = new Faculty();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Courses Obj = new Courses();
            Obj.Show();
            this.Hide();
        }

        private void FeeLbl_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Salary Obj = new Salary();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
