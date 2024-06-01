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
    public partial class GroupProject : Form
    {
        public GroupProject()
        {
            InitializeComponent();
        }

        private void GroupProject_Load(object sender, EventArgs e)
        {
            getGroupsData();
            getGroupsProjectData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }
        private void getGroupsData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                //SqlCommand cmd = new SqlCommand("Select distinct GS.GroupId from GroupStudent GS left join (select distinct * from GroupProject) GP on GS.GroupId = GP.GroupId where GP.ProjectId is null", con);
                SqlCommand cmd = new SqlCommand("SELECT g.Id as GroupId FROM [Group] g LEFT JOIN [GroupProject] gp ON g.Id = gp.GroupId WHERE gp.GroupId IS NULL", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                sd.Fill(dta);
                dataGridViewGroups.DataSource = dta;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void getGroupsProjectData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from GroupProject ", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                sd.Fill(dta);
                GroupWithProjects.DataSource = dta;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Hide();
                DataGridViewRow row = dataGridViewGroups.Rows[e.RowIndex];
                AssignProject g = new AssignProject(row.Cells["GroupId"].Value.ToString());
                g.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void GroupWithProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    var con = Configuration.getInstance().getConnection();
                    DataGridViewRow row = GroupWithProjects.Rows[e.RowIndex];
                    if (MessageBox.Show(string.Format("Remove this Project from this group?", row.Cells["ProjectId"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from GroupProject where ProjectId = @ProjectId", con))
                        {
                            cmd.Parameters.AddWithValue("@ProjectId", row.Cells["ProjectId"].Value);

                            cmd.ExecuteNonQuery();
                            this.Hide();
                            MessageBox.Show("Successfully Deleted");
                            this.Show();
                            getGroupsData();
                            getGroupsProjectData();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
