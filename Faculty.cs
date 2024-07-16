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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
            ShowProfs();
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
        private void ShowProfs()
        {
            Con.Open();
            string Query = "select * from FacultyTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProfDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            DepNameTb.Text = "";
            PrAddTb.Text = "";
            GenderCb.SelectedIndex = -1;
            ExpTb.Text = "";
            SalaryTb.Text = "";
            QualificationCb.SelectedIndex = -1;
            PrNameTb.Text = "";

        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || PrAddTb.Text == "" || DepNameTb.Text == "" || DepIdCb.SelectedIndex == -1 || SalaryTb.Text == "" || QualificationCb.SelectedIndex == -1 || GenderCb.SelectedIndex == -1 || ExpTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FacultyTbl(PrName,PrDOB,PrGen,PrAdd,PrQual,PrExp,PrDepId,PrDepName,PrSalary)values(@PN,@PDO,@PG,@PA,@PQ,@PE,@PD,@PDN,@PS)", Con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PDO", PrDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PA", PrAddTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QualificationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PE", ExpTb.Text);
                    cmd.Parameters.AddWithValue("@PD", DepIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PDN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@PS", SalaryTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Faculty Added");
                    Con.Close();
                    ShowProfs();
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

        private void label3_Click(object sender, EventArgs e)
        {
            Department Obj = new Department();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }
        int Key = 0;



        private void ProfDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProfDGV.SelectedRows[0].Cells[1].Value.ToString();
            PrDOB.Text = ProfDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.SelectedItem = ProfDGV.SelectedRows[0].Cells[3].Value.ToString();
            PrAddTb.Text = ProfDGV.SelectedRows[0].Cells[4].Value.ToString();
            QualificationCb.SelectedItem = ProfDGV.SelectedRows[0].Cells[5].Value.ToString();
            ExpTb.Text = ProfDGV.SelectedRows[0].Cells[6].Value.ToString();
            DepIdCb.SelectedValue = ProfDGV.SelectedRows[0].Cells[7].Value.ToString();
            DepNameTb.Text = ProfDGV.SelectedRows[0].Cells[8].Value.ToString();
            SalaryTb.Text = ProfDGV.SelectedRows[0].Cells[9].Value.ToString();
            if (PrNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProfDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PrNameTb.Text == "" || PrAddTb.Text == "" || DepNameTb.Text == "" || DepIdCb.SelectedIndex == -1 || SalaryTb.Text == "" || QualificationCb.SelectedIndex == -1 || GenderCb.SelectedIndex == -1 || ExpTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update FacultyTbl set PrName=@PN,PrDOB=@PD,PrGen=@PG,PrAdd=@PA,PrQual=@PQ,PrExp=@PE,PrDepId=@PD,PrDepName=@PDN,PrSalary=@PS where PrNum=@PrKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTb.Text);
                    cmd.Parameters.AddWithValue("@PDO", PrDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PA", PrAddTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QualificationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PE", ExpTb.Text);
                    cmd.Parameters.AddWithValue("@PD", DepIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PDN", DepNameTb.Text);
                    cmd.Parameters.AddWithValue("@PS", SalaryTb.Text);
                    cmd.Parameters.AddWithValue("@PrKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Faculty Updated");
                    Con.Close();
                    ShowProfs();
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
                MessageBox.Show("Select the Faculty");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from FacultyTbl where PrNum=@PrKey", Con);

                    cmd.Parameters.AddWithValue("@Prkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Faculty Deleted");
                    Con.Close();
                    ShowProfs();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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
