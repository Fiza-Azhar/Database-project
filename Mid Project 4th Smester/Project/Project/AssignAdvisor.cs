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
    public partial class AssignAdvisor : Form
    {
        public AssignAdvisor()
        {
            InitializeComponent();
        }
        private void Projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                if (e.ColumnIndex == 6)
                {
                    SqlCommand cmd2 = new SqlCommand("select distinct g.Id ,g.Created_On , gp.ProjectId, gp.AssignmentDate, p.Title, p.Description from [Group] g left join (select * from GroupProject) gp on g.Id = gp.GroupId left join (select * from Project) p on gp.ProjectId = p.Id", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Projects.DataSource = dt;
                    string temp = dt.Rows[e.RowIndex].ItemArray[2].ToString();
                    ProjectAdvisor ap = new ProjectAdvisor(temp);
                    ap.Show();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void AssignAdvisor_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("select distinct gp.GroupId, gp.ProjectId, p.Title, ga.AdvisorId, ga.AdvisorRole, a.Salary from [GroupProject] gp left join Project p on p.Id = gp.ProjectId left join (select * from ProjectAdvisor) ga on gp.ProjectId = ga.ProjectId left join (select * from Advisor) a on ga.AdvisorId= a.Id where gp.ProjectId is not null", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Projects.DataSource = dt;

            DataGridViewButtonColumn u = new DataGridViewButtonColumn();
            Projects.Columns.Insert(6, u);
            u.DefaultCellStyle.BackColor = Color.White;
            u.FlatStyle = FlatStyle.Popup;
            u.InheritedStyle.BackColor = System.Drawing.Color.White;
            u.Text = "Add Advisor";
            u.UseColumnTextForButtonValue = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage p = new FirstPage();
            p.Show();
        }
    }
}
