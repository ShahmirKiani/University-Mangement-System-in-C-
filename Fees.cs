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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            ShowFees();
            GetStdId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shahm\Documents\UniversityDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void ShowFees()
        {
            Con.Open();
            string Query = "select * from FeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            StdNameTb.Text = "";
            DepNameTb.Text = "";
            StdIdCb.SelectedIndex = -1;

        }
        private void GetStdId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select StNum from StudentTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StNum", typeof(int));
            dt.Load(Rdr);
            StdIdCb.ValueMember = "StNum";
            StdIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetStdName()
        {
            Con.Open();
            string Query = "Select * from StudentTbl where StNum=" + StdIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(@Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StdNameTb.Text = dr["StName"].ToString();
                DepNameTb.Text = dr["StDepName"].ToString();
            }
            Con.Close();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (StdNameTb.Text == "" || FeeAmtTb.Text == "" || DepNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FeeTbl(StNum,StName,StDep,FAmount,PayDate)values(@SN,@SNA,@SD,@FA,@PD)", Con);
                    cmd.Parameters.AddWithValue("@SN", StdIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SNA", StdNameTb.Text);
                    cmd.Parameters.AddWithValue("@SD", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@FA", FeeAmtTb.Text);
                    cmd.Parameters.AddWithValue("@PD", FeePeriod.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fee Paid");
                    Con.Close();
                    ShowFees();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStdName();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
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

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
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
