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

namespace WindowsForms_Database_Learning
{
    public partial class EmployeeDB : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public EmployeeDB()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-B6T5E9V;database=Prorigo;Integrated Security=True");
        }

        private void EmployeeDB_Load(object sender, EventArgs e)
        {

        }
        public void ClearAll()
        {
            textBox1_EmpID.Clear();
            textBox2_EmpName.Clear();
            textBox3_EmpDesignation.Clear();
            textBox4_EmpSalary.Clear();
        }

        private void button5_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee values(@id,@name,@designation,@salary)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_EmpID.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_EmpName.Text);
                cmd.Parameters.AddWithValue("@Designation", textBox3_EmpDesignation.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(textBox4_EmpSalary.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Inserted");
                   textBox1_EmpID.Enabled = true;
                    ClearAll();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Employee set EmpName=@name,Designation=@designation,Salary=@salary where EmpId=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_EmpID.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_EmpName.Text);
                cmd.Parameters.AddWithValue("@Designation", textBox3_EmpDesignation.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(textBox4_EmpSalary.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record updated");
                    ClearAll();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee Where EmpId=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_EmpID.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2_EmpName.Text = dr["EmpName"].ToString();
                        textBox3_EmpDesignation.Text = dr["Designation"].ToString();
                        textBox4_EmpSalary.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from employee where EmpId=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_EmpID.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_EmpName.Text);
                cmd.Parameters.AddWithValue("@Designation", textBox3_EmpDesignation.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(textBox4_EmpSalary.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Deleted Inserted");
                    ClearAll();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select max(EmpId) from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    textBox1_EmpID.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    textBox1_EmpID.Text = id.ToString();
                }
               textBox1_EmpID.Enabled = false;
                textBox2_EmpName.Clear();
                textBox3_EmpDesignation.Clear();
                textBox4_EmpSalary.Clear();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_ShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
