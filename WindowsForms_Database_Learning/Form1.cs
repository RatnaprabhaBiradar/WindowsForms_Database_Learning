using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsForms_Database_Learning
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Server=DESKTOP-B6T5E9V;database=Prorigo;Integrated Security=True");
        }
        public void ClearAll()
        {
            textBox1_ProdID.Clear();
            textBox2_ProdName.Clear();
            textBox3_ProdPrice.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry= "select max(Id) from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if(obj==DBNull.Value)
                {
                    textBox1_ProdID.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    textBox1_ProdID.Text = id.ToString();
                }
                textBox1_ProdID.Enabled = false;
                textBox2_ProdName.Clear();
                textBox3_ProdPrice.Clear();
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
        {// while writing queary follow sequence
            try
            {
                string qry = "insert into Product values(@id,@name,@price)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_ProdID.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_ProdName.Text);
                cmd.Parameters.AddWithValue("@price", textBox3_ProdPrice.Text);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Record Inserted");
                    textBox1_ProdID.Enabled = true;
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
                string qry = "update Product set Name=@name,Price=@price where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_ProdID.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_ProdName.Text);
                cmd.Parameters.AddWithValue("@price", textBox3_ProdPrice.Text);
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

        private void button5_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from product where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1_ProdID.Text));
                cmd.Parameters.AddWithValue("@name", textBox2_ProdName.Text);
                cmd.Parameters.AddWithValue("@price", textBox3_ProdPrice.Text);
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

        private void button4_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product Where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(textBox1_ProdID.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2_ProdName.Text = dr["Name"].ToString();
                        textBox3_ProdPrice.Text = dr["Price"].ToString();
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

        private void button1_showProductAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Product";
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1_ProdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2_ProdName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3_ProdPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }
    }
}
