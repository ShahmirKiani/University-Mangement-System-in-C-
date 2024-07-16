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
using static System.Windows.Forms.AxHost;

namespace University_Management_System
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            GetDepId();
            GetProfId();
            ShowCourse();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shahm\Documents\UniversityDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void GetProfId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PrNum from FacultyTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PrNum", typeof(int));
            dt.Load(Rdr);
            PrIdCb.ValueMember = "PrNum";
            PrIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetProfName()
        {
            Con.Open();
            string Query = "Select * from FacultyTbl where PrNum=" + PrIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(@Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ProfTb.Text = dr["PrName"].ToString();
            }
            Con.Close();
        }
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
        private void ShowCourse()
        {
            Con.Open();
            string Query = "select * from CourseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CourseDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            DepNameTb.Text = "";
            CNameTb.Text = "";
            DepIdCb.SelectedIndex = -1;
            DurationTb.Text = "";
            ProfTb.Text = "";
            PrIdCb.SelectedIndex = -1;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || DurationTb.Text == "" || DepNameTb.Text == "" || DepIdCb.SelectedIndex == -1 || ProfTb.Text == "" || PrIdCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CourseTbl(CName,CDuration,CDepId,CDepName,CprofId,CprofName)values(@CN,@CD,@CDI,@CDN,@CPI,@CPN)", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CD", DurationTb.Text);
                    cmd.Parameters.AddWithValue("@CDI", DepIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CDN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@CPI", PrIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CPN", ProfTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Added");
                    Con.Close();
                    ShowCourse();
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

        private void DepIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDepName();
        }

        private void PrIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetProfName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || DurationTb.Text == "" || DepNameTb.Text == "" || DepIdCb.SelectedIndex == -1 || ProfTb.Text == "" || PrIdCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CourseTbl set CName=@CN,CDuration=@CD,CDepId=@CDI,CDepName=@CDN,CprofId=@CPI,CprofName=@CPN where CNum=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CD", DurationTb.Text);
                    cmd.Parameters.AddWithValue("@CDI", DepIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CDN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@CPI", PrIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CPN", ProfTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Updated");
                    Con.Close();
                    ShowCourse();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void CourseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = CourseDGV.SelectedRows[0].Cells[1].Value.ToString();
            DurationTb.Text = CourseDGV.SelectedRows[0].Cells[2].Value.ToString();
            DepIdCb.SelectedValue = CourseDGV.SelectedRows[0].Cells[3].Value.ToString();
            DepNameTb.Text = CourseDGV.SelectedRows[0].Cells[4].Value.ToString();
            PrIdCb.SelectedValue = CourseDGV.SelectedRows[0].Cells[5].Value.ToString();
            ProfTb.Text = CourseDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CourseDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Course");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CourseTbl where CNum=@CKey", Con);

                    cmd.Parameters.AddWithValue("@Ckey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course Deleted");
                    Con.Close();
                    ShowCourse();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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
