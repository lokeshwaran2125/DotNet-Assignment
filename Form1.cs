using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Delete_StoredProcedure
{
    public partial class Form1 : Form
    {
        
         SqlConnection con=new SqlConnection  (@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentIDs();
        }

        private void LoadStudentIDs()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Student", con);

                SqlDataReader dr = cmd.ExecuteReader();
                cmbStudentID.Items.Clear();
                while (dr.Read())
                {
                    cmbStudentID.Items.Add(dr["StudentID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading IDs: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE StudentID=@StudentID", con);
                cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.SelectedItem.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TxtName.Text = reader["StudentName"].ToString();
                    TxtAge.Text = reader["Age"].ToString();
                    TxtGender.Text = reader["Gender"].ToString();
                    TxtCity.Text = reader["City"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Student Details:" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudentID.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Student ID first");
                    return;
                }
                con.Open();

                SqlCommand cmd = new SqlCommand("SPP_DeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentID", cmbStudentID.SelectedItem.ToString());

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Record deleted successfully");

                    TxtName.Clear();
                    TxtAge.Clear();
                    TxtGender.Clear();
                    TxtCity.Clear();

                    LoadStudentIDs();
                }
                else
                {
                    MessageBox.Show("No Record found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Handling  " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
