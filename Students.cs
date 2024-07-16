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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            ShowStudents();
            GetDepId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shahm\Documents\UniversityDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void GetDepId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DepNum from DepartmentTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepNum", typeof(int));
            dt.Load(Rdr);
            DepIdCb.ValueMember = "DepNum";
            DepIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetDepName()
        {
            Con.Open();
            string Query = "Select * from DepartmentTbl where DepNum=" + DepIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(@Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DepNameTb.Text = dr["DepName"].ToString();
            }
            Con.Close();
        }
        private void ShowStudents()
        {
            Con.Open();
            string Query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            DepNameTb.Text = "";
            StdTb.Text = "";
            StdGenCb.SelectedIndex = -1;
            PhoneTb.Text = "";
            StdAddTb.Text = "";
            DepIdCb.SelectedIndex = -1;
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (StdTb.Text == "" || StdAddTb.Text == "" || DepNameTb.Text == "" || DepIdCb.SelectedIndex == -1 || PhoneTb.Text == "" || SemCb.SelectedIndex == -1 || StdGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into StudentTbl(StName,StDOB,StGen,StAddress,StDepId,StDepName,StPhone,StSem)values(@SN,@SD,@SG,@SA,@SDI,@SDN,@SP,@SS)", Con);
                    cmd.Parameters.AddWithValue("@SN", StdTb.Text);
                    cmd.Parameters.AddWithValue("@SD", StdDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@SG", StdGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SA", StdAddTb.Text);
                    cmd.Parameters.AddWithValue("@SDI", DepIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SDN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@SP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SS", SemCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");
                    Con.Close();
                    ShowStudents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DepIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDepName();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from StudentTbl where StNum=@SKey", Con);

                    cmd.Parameters.AddWithValue("@Skey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    Con.Close();
                    ShowStudents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void StdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdTb.Text = StdDGV.SelectedRows[0].Cells[1].Value.ToString();
            StdDOB.Text = StdDGV.SelectedRows[0].Cells[2].Value.ToString();
            StdGenCb.SelectedItem = StdDGV.SelectedRows[0].Cells[3].Value.ToString();
            StdAddTb.Text = StdDGV.SelectedRows[0].Cells[4].Value.ToString();
            DepIdCb.SelectedValue = StdDGV.SelectedRows[0].Cells[5].Value.ToString();
            DepNameTb.Text = StdDGV.SelectedRows[0].Cells[6].Value.ToString();
            PhoneTb.Text = StdDGV.SelectedRows[0].Cells[7].Value.ToString();
            SemCb.SelectedItem = StdDGV.SelectedRows[0].Cells[8].Value.ToString();
            if (StdTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StdDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (StdTb.Text == "" || StdAddTb.Text == "" || DepNameTb.Text == "" || DepIdCb.SelectedIndex == -1 || PhoneTb.Text == "" || SemCb.SelectedIndex == -1 || StdGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set StName=@SN,StDOB=@SD,StGen=@SG,StAddress=@SA,StDepId=@SDI,StDepName=@SDN,StPhone=@SP,StSem=@SS where StNum=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SN", StdTb.Text);
                    cmd.Parameters.AddWithValue("@SD", StdDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@SG", StdGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SA", StdAddTb.Text);
                    cmd.Parameters.AddWithValue("@SDI", DepIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SDN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@SP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SS", SemCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    ShowStudents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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
