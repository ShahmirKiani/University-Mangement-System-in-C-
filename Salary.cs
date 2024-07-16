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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            ShowSalary();
            GetProfId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shahm\Documents\UniversityDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void ShowSalary()
        {
            Con.Open();
            string Query = "select * from SalaryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalaryDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            ProfNameTb.Text = "";
            Amount.Text = "";
            ProfId.SelectedIndex = -1;

        }
        private void GetProfId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PrNum from FacultyTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PrNum", typeof(int));
            dt.Load(Rdr);
            ProfId.ValueMember = "PrNum";
            ProfId.DataSource = dt;
            Con.Close();
        }
        private void GetProfName()
        {
            Con.Open();
            string Query = "Select * from FacultyTbl where PrNum=" + ProfId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(@Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ProfNameTb.Text = dr["PrName"].ToString();

            }
            Con.Close();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (ProfNameTb.Text == "" || Amount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into SalaryTbl(PrNum,PrName,PrSalary,Speriod)values(@PN,@PNA,@PS,@SP)", Con);
                    cmd.Parameters.AddWithValue("@PN", ProfId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PNA", ProfNameTb.Text);
                    cmd.Parameters.AddWithValue("@PS", Amount.Text);

                    cmd.Parameters.AddWithValue("@SP", PayDateTb.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Paid");
                    Con.Close();
                    ShowSalary();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void ProfId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetProfName();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
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
