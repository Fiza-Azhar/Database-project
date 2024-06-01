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
    public partial class AssignProject : Form
    {
        private string str;
        public AssignProject(string temp)
        {
            InitializeComponent();
            this.str = temp;
        }

        private void AssignProject_Load(object sender, EventArgs e)
        {
            getProjects();
        }
        private void getProjects()
        {
            var conection = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Project ", conection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            sd.Fill(dta);
            Projects.DataSource = dta;
        }
        private void Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = Projects.Rows[e.RowIndex];
                    DialogResult r = MessageBox.Show(String.Format("Are you sure to assign this project", row.Cells["Id"].Value), "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert into GroupProject (ProjectId,GroupId,AssignmentDate) values (@ProjectId,@GroupId,@AssignmentDate)", con))
                        {
                                cmd.Parameters.AddWithValue("@ProjectId", row.Cells["Id"].Value);
                                cmd.Parameters.AddWithValue("@GroupId", int.Parse(str));
                                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Today);
                                cmd.ExecuteNonQuery();
                                this.Hide();
                                MessageBox.Show("Successfully Added");
                                getProjects();
                                GroupProject g = new GroupProject();
                                g.Show();    
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupProject p = new GroupProject();
            p.Show();
        }
    }
}
