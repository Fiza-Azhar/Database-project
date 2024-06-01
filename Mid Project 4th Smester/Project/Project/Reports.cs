using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnAdvisory(object sender, EventArgs e)
        {
            String connection = @"Data Source=DESKTOP-17G2SBI\MSSQLSERVER01;Initial Catalog=ProjectA;Integrated Security=True";
            string query = "select distinct gp.GroupId, gp.ProjectId, p.Title, ga.AdvisorId, ga.AdvisorRole, a.Salary from [GroupProject] gp left join Project p on p.Id = gp.ProjectId left join (select * from ProjectAdvisor) ga on gp.ProjectId = ga.ProjectId left join (select * from Advisor) a on ga.AdvisorId= a.Id where gp.ProjectId is not null";
            AdvisoryBoardViewer.GeneratePDF(connection, query);
            MessageBox.Show("Pdf Successfully Created!!!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=DESKTOP-17G2SBI\MSSQLSERVER01;Initial Catalog=ProjectA;Integrated Security=True";
            string query = "select S.Id,E.Id,P.Id,GE.ObtainedMarks,E.TotalMarks from Student S join GroupStudent GS on GS.StudentId = S.Id join [Group] G on G.Id = GS.GroupId join GroupProject GP On GP.GroupId = G.Id join Project P on P.Id = GP.ProjectId join GroupEvaluation GE on GE.GroupId=G.Id Join Evaluation E on E.Id = GE.EvaluationId";
            MarksEvaluation.GeneratePDF(connection, query);
            MessageBox.Show("Pdf Successfully Created!!!");
        }

        private void btnGroupStd_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=DESKTOP-17G2SBI\MSSQLSERVER01;Initial Catalog=ProjectA;Integrated Security=True";
            string query = "select g.EvaluationId, g.GroupId,g.ObtainedMarks,e.TotalMarks From GroupEvaluation g Inner Join Evaluation e on g.EvaluationId = e.Id where g.ObtainedMarks >= (0.8 * e.TotalMarks)";
            A_Grade.GeneratePDF(connection, query);
            MessageBox.Show("Pdf Successfully Created!!!");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=DESKTOP-17G2SBI\MSSQLSERVER01;Initial Catalog=ProjectA;Integrated Security=True";
            string query = "Select S.Id,S.RegistrationNo,P.FirstName,P.LastName,P.Email from Student S join Person P on P.Id = S.Id";
            ViewStudents.GeneratePDF(connection, query);
            MessageBox.Show("Pdf Successfully Created!!!");
        }

        private void btnGroupProject_Click(object sender, EventArgs e)
        {
            try
            {
                String connection = @"Data Source=DESKTOP-17G2SBI\MSSQLSERVER01;Initial Catalog=ProjectA;Integrated Security=True";
                string query = "Select gp.ProjectId, gp.GroupId, g.Created_On, gp.AssignmentDate from  gp Left Join [Group] g on g.Id = gp.GroupId where gp.AssignmentDate is not null";
                ProjectsGroups.GeneratePDF(connection, query);
                MessageBox.Show("Pdf Successfully Created!!!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage f = new FirstPage();
            f.Show();
        }
    }
}
