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
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }
        public int studentID;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage f = new FirstPage();
            f.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)", con);
                SqlCommand cmd2 = new SqlCommand("Insert into Student(Id, RegistrationNo) values((Select Id from Person where FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email),@RegistrationNo)", con);
                cmd.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(txtDOB.Text));
                if(cbGender.Text == "Male")
                {
                    cmd.Parameters.AddWithValue("@Gender", 1);
                }
                else if(cbGender.Text == "Female")
                {
                    cmd.Parameters.AddWithValue("@Gender", 2);
                }

                cmd2.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmd2.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd2.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd2.Parameters.AddWithValue("@RegistrationNo", txtRoll.Text);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Successfully saved");
                GetStudentsData();
                reset_options();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            GetStudentsData();

        }
        private void GetStudentsData()
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Student", con);
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dataGridViewStudent.DataSource = dt;
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
            txtRoll.Clear();
            cbGender.Text = "";
            txtFname.Focus();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the registration number from the textbox
            string registrationNumber = txtRoll.Text;

            // Check if the registration number is not empty
            if (!string.IsNullOrEmpty(registrationNumber))
            {
                // Define a SQL query to get the student and person information
                string query = "SELECT s.Id, s.RegistrationNo, p.FirstName, p.LastName, p.Contact, p.Email, p.DateOfBirth, p.Gender " +
                    "FROM Student s " +
                    "INNER JOIN Person p ON s.Id = p.Id" +
                    "WHERE s.RegistrationNo = @registrationNumber";
                var con = Configuration.getInstance().getConnection();
                // Create a command object with the query and connection
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add the parameter for the registration number
                    command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                    // Execute the query and get the data reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // If there is data
                        if (reader.Read())
                        {
                            // Fill in the textboxes with the student and person information
                            txtFname.Text = reader["FirstName"].ToString();
                            txtLname.Text = reader["LastName"].ToString();
                            txtContact.Text = reader["Contact"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtDOB.Text = reader["DateOfBirth"].ToString();
                            cbGender.Text = reader["Gender"].ToString();
                        }
                        else
                        {
                            // If no data was found, show a message box
                            MessageBox.Show("No student found with that registration number.");
                        }
                    }
                }
            }
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


