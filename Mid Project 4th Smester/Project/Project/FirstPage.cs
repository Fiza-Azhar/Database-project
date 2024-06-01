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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void btnManageS_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent f = new ManageStudent();
            f.Show();
        }

        private void btnManageAdvisors_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAdvisors m = new ManageAdvisors();
            m.Show();
        }

        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProjects mp = new ManageProjects();
            mp.Show();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group g = new Group();
            g.Show();
        }

        private void btnManageEvaluation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluation fp = new Evaluation();
            fp.Show();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupEvaluation fp = new GroupEvaluation();
            fp.Show();
        }

        private void btnAssignProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupProject fp = new GroupProject();
            fp.Show();
        }

        private void btnAssignAdvisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignAdvisor fp = new AssignAdvisor();
            fp.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports fp = new Reports();
            fp.Show();
        }
    }
}
