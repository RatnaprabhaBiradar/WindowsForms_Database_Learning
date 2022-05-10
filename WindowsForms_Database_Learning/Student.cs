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
    public partial class Student : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        public Student()
        {
            InitializeComponent();
            con= new SqlConnection("Server=DESKTOP-B6T5E9V;database=Prorigo;Integrated Security=True");
        }
        public void ClearAll()
        {
            textBox1_RollNo.Clear();
            textBox2_Name.Clear();
            textBox3_Branch.Clear();
            textBox4_Percentage.Clear();
        }
        private void button1_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select max(Roll_no) from Student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    textBox1_RollNo.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                 textBox1_RollNo.Text = id.ToString();
                }
                textBox1_RollNo.Enabled = false;
                textBox2_Name.Clear();
                textBox3_Branch.Clear();
                textBox4_Percentage.Clear();
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

        private void button2_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Student values(@roll_no,@name,@branch,@percentage)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(textBox1_RollNo.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_Name.Text);
                cmd.Parameters.AddWithValue("@Branch", textBox3_Branch.Text);
                cmd.Parameters.AddWithValue("@percentage", Convert.ToSingle(textBox4_Percentage.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Saved");
                    textBox1_RollNo.Enabled = true;
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

        private void button3_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Student set Name=@name,Branch=@branch,Percentage=@percentage where Roll_No=@roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(textBox1_RollNo.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_Name.Text);
                cmd.Parameters.AddWithValue("@Branch", textBox3_Branch.Text);
                cmd.Parameters.AddWithValue("@Percentage", Convert.ToSingle(textBox4_Percentage.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Updated");
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

        private void button4_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Student where Roll_No=@roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(textBox1_RollNo.Text));
                //cmd.Parameters.AddWithValue("@name", textBox2_Name.Text);
               // cmd.Parameters.AddWithValue("@branch", textBox3_Branch.Text);
               // cmd.Parameters.AddWithValue("@percentage", Convert.ToSingle(textBox4_Percentage.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Deleted");
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

        private void button5_Search_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "select * from Student where Roll_No=@roll_no";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@roll_no", Convert.ToInt32(textBox1_RollNo.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2_Name.Text = dr["Name"].ToString();
                        textBox3_Branch.Text = dr["Branch"].ToString();
                        textBox4_Percentage.Text = dr["Percentage"].ToString();
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

        private void button6_ShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from student";
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
