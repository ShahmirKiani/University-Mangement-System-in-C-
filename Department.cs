using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University_Management_System
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            ShowDep();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shahm\Documents\UniversityDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void ShowDep()
        {
            Con.Open();
            string Query = "select * from DepartmentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DepDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            DepNameTb.Text = "";
            DepIntakeTb.Text = "";
            DepFeesTb.Text = "";
        }
        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (DepNameTb.Text == "" || DepIntakeTb.Text == "" || DepFeesTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into DepartmentTbl(DepName,DepIntake,DepFees)values(@DN,@DI,@DF)", Con);
                    cmd.Parameters.AddWithValue("@DN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@DI", DepIntakeTb.Text);
                    cmd.Parameters.AddWithValue("@DF", DepFeesTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Added");
                    Con.Close();
                    ShowDep();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void DepDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepDGV.SelectedRows[0].Cells[1].Value.ToString();
            DepIntakeTb.Text = DepDGV.SelectedRows[0].Cells[2].Value.ToString();
            DepFeesTb.Text = DepDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
                /*DepNameTb.Text = "";
                DepFeesTb.Text = "";
                DepIntakeTb.Text = "";*/
            }
            else
            {
                Key = Convert.ToInt32(DepDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DepNameTb.Text == "" || DepIntakeTb.Text == "" || DepFeesTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DepartmentTbl set DepName=@DN,DepIntake=@DI,DepFees=@DF where DepNum=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@DI", DepIntakeTb.Text);
                    cmd.Parameters.AddWithValue("@DF", DepFeesTb.Text);
                    cmd.Parameters.AddWithValue("@Dkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Updated");
                    Con.Close();
                    ShowDep();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Department");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DepartmentTbl where DepNum=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@DI", DepIntakeTb.Text);
                    cmd.Parameters.AddWithValue("@DF", DepFeesTb.Text);
                    cmd.Parameters.AddWithValue("@Dkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Deleted");
                    Con.Close();
                    ShowDep();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
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
