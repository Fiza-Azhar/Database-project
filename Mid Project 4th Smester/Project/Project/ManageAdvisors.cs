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

namespace Project
{
    public partial class ManageAdvisors : Form
    {
        int designation;
        public ManageAdvisors()
        {
            InitializeComponent();
        }
        SqlConnection con = Configuration.getInstance().getConnection();
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage f = new FirstPage();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)", con);
                SqlCommand cmd2 = new SqlCommand("Insert into Advisor(Id,Designation, Salary) values((Select Id from Person where FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email),@Designation,@Salary)", con);
                cmd.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(txtDOB.Text));
                if (cbGender.Text == "Male")
                {
                    cmd.Parameters.AddWithValue("@Gender", 1);
                }
                else if (cbGender.Text == "Female")
                {
                    cmd.Parameters.AddWithValue("@Gender", 2);
                }

                cmd2.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmd2.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd2.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
                if (cbDesignation.SelectedIndex == 0)
                {
                    designation = 11;
                }
                else if (cbDesignation.SelectedIndex == 1)
                {
                    designation = 12;
                }
                else if (cbDesignation.SelectedIndex == 2)
                {
                    designation = 14;
                }
                cmd2.Parameters.AddWithValue("@Designation", designation);
                /*if (cbDesignation.Text == "Main Advisor")
                {
                    cmd2.Parameters.AddWithValue("@Designation", 11);
                }
                else if (cbDesignation.Text == "Co-Advisor")
                {
                    cmd2.Parameters.AddWithValue("@Designation", 12);
                }
                else if (cbDesignation.Text == "Industry Advisor")
                {
                    cmd2.Parameters.AddWithValue("@Designation", 14);
                }*/
                cmd2.Parameters.AddWithValue("@Salary", Decimal.Parse(txtSalary.Text));
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
                GetAdvisorsData();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ManageAdvisors_Load(object sender, EventArgs e)
        {
            GetAdvisorsData();
        }
        private void GetAdvisorsData()
        {
            SqlCommand cmd = new SqlCommand("Select * From Advisor", con);
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dataGridViewAdvisors.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_options();
        }
        private void reset_options()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtDOB.Clear();
            cbDesignation.Text = "";
            txtSalary.Clear();
            cbGender.Text = "";
            txtFname.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Advisor set Designation = @Designation, Salary = @Salary where Id=@Id", con);
                for(int i = 0; i <= dataGridViewAdvisors.Rows.Count - 1; i++)
                {
                    cmd.Parameters.AddWithValue("Id", dataGridViewAdvisors.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@Designation", dataGridViewAdvisors.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@Salary", dataGridViewAdvisors.Rows[i].Cells[2].Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
