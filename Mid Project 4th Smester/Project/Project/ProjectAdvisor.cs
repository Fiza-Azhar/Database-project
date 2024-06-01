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
    public partial class ProjectAdvisor : Form
    {
        private string temp,temp2;
        private int value;
        public ProjectAdvisor(string newStr)
        {
            InitializeComponent();
            this.temp = newStr;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }
        private int checkValue(string s)
        {
            int i = 0;
            if (s == "Male")
            {
                i = 1;
            }
            else if (s == "Female")
            {
                i = 2;
            }
            else if (s == "Active")
            {
                i = 3;
            }
            else if (s == "InActive")
            {
                i = 4;
            }
            else if (s == "Professor")
            {
                i = 6;
            }
            else if (s == "Associate Professor")
            {
                i = 7;
            }
            else if (s == "Assistant Professor")
            {
                i = 8;
            }
            else if (s == "Lecturer")
            {
                i = 9;
            }
            else if (s == "Industry Professional")
            {
                i = 10;
            }
            else if (s == "Main Advisor")
            {
                i = 11;
            }
            else if (s == "Co-Advisror")
            {
                i = 12;
            }
            else if (s == "Industry Advisor")
            {
                i = 14;
            }
            return i;
        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
        }
        private void Advisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AssignAdvisor a = new AssignAdvisor();
            a.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            try
            {
                {
                    using (var cmd = new SqlCommand("Insert into ProjectAdvisor values(@AdvisorId,@ProjectId,@AdvisorRole,@AssignmentDate)", con))
                    {
                        temp2 = cbRole.Text;
                        value = checkValue(temp2);
                        cmd.Parameters.AddWithValue("@AdvisorId", int.Parse(cbID.Text));
                        cmd.Parameters.AddWithValue("@ProjectId", int.Parse(temp));
                        cmd.Parameters.AddWithValue("@AdvisorRole", value);
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@AssignmentDate", today);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }

                this.Close();
                MessageBox.Show("Successfully saved");
                AssignAdvisor p = new AssignAdvisor();
                p.Show();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void cbRole_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            try
            {
                {
                    using (var cmd = new SqlCommand("Select Lookup.Value from Lookup where Id > 10 except(select LookUp.Value from ProjectAdvisor join Lookup on Lookup.Id = ProjectAdvisor.AdvisorRole where ProjectId = @ProjectId)", con))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", int.Parse(temp));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Lookup");

                        cbRole.DisplayMember = "Value";
                        cbRole.ValueMember = "Value";
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void cbID_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            try
            {
                {
                    using (var cmd = new SqlCommand("Select Id from Advisor where Designation = @Designation", con))
                    {
                        temp2 = cbRole.Text;

                        value = checkValue(temp2);
                        cmd.Parameters.AddWithValue("@Designation", value);
                        SqlDataAdapter daa = new SqlDataAdapter(cmd);
                        DataSet dss = new DataSet();
                        daa.Fill(dss, "Advisor");

                        cbID.DisplayMember = "Id";
                        cbID.ValueMember = "Id";
                        cbID.DataSource = dss.Tables["Advisor"];
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
