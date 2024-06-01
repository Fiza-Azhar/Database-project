using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class Group_Formation_And_Management : Form
    {
        private string str;
        public Group_Formation_And_Management(string newString)
        {
            InitializeComponent();
            this.str = newString;
        }

        private void Group_Formation_And_Management_Load(object sender, EventArgs e)
        {
            GetStudentsData();
            GetStudentsGroupData();
            lbGroupStd.Text = "Grouop" + " " + str  + " " + "Members";
           
        }
    private void GetStudentsData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select s.Id, s.RegistrationNo From Student s LEFT JOIN (SELECT * From GroupStudent) gs on S.Id = gs.StudentId WHERE gs.GroupId is NULL", con);
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dataGridViewStudents.DataSource = dt;
        }
        private void GetStudentsGroupData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From [GroupStudent] where GroupId = @GroupId", con);
            cmd.Parameters.AddWithValue("@GroupId", str);
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            GroupStudent.DataSource = dt;
        }
        private void GroupStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    var con = Configuration.getInstance().getConnection();
                    DataGridViewRow row = GroupStudent.Rows[e.RowIndex];
                    if (MessageBox.Show(string.Format("Remove this student from this group?", row.Cells["StudentId"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from GroupStudent where StudentId = @StudentId", con))
                        {
                            cmd.Parameters.AddWithValue("@StudentId", row.Cells["StudentId"].Value);

                            cmd.ExecuteNonQuery();
                            this.Hide();
                            MessageBox.Show("Successfully Deleted");
                            this.Show();
                            GetStudentsGroupData();
                            GetStudentsData();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void dataGridViewStudents_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = dataGridViewStudents.Rows[e.RowIndex];
                    DialogResult r = MessageBox.Show(String.Format("Are you sure to add this student", row.Cells["Id"].Value), "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert into [GroupStudent] (GroupId,StudentId,Status,AssignmentDate) values (@GroupId,@StudentId,@Status,@AssignmentDate)", con))
                        {
                            cmd.Parameters.AddWithValue("@StudentId", row.Cells["Id"].Value);
                            cmd.Parameters.AddWithValue("@GroupId", int.Parse(str));
                            cmd.Parameters.AddWithValue("@Status", 3);
                            cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Today);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully Added");
                            GetStudentsGroupData();
                            GetStudentsData();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Group fp = new Group();
            fp.Show();
        }
    }
}
