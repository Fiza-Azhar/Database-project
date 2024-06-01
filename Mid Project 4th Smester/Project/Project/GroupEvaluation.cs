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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                //SqlCommand cmd = new SqlCommand("Select distinct * from GroupStudent g left join (select distinct * from GroupEvaluation) gp on g.GroupId=gp.GroupId where gp.EvaluationId is null", con);
                SqlCommand cmd = new SqlCommand("SELECT g.GroupId FROM GroupStudent g LEFT JOIN GroupEvaluation gp ON g.GroupId = gp.GroupId WHERE gp.EvaluationId IS NULL", con);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                sd.Fill(dta);
                dataGridViewGroups.DataSource = dta;
                /*this.dataGridViewGroups.Columns["StudentId"].Visible = false;
                this.dataGridViewGroups.Columns["AssignmentDate"].Visible = false;
                this.dataGridViewGroups.Columns["Status"].Visible = false;*/
                SqlCommand cm = new SqlCommand("Select distinct * from Evaluation", con);
                SqlDataAdapter s = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                s.Fill(dt);
                dataGridViewEvaluation.DataSource = dt;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private int check(int marks)
        {
            if (marks <= int.Parse(txtOMarks.Text))
            {
                return marks;
            }
            else
            {
                MessageBox.Show("Obtained Marks cannot be greater than Total Marks");
                this.Show();
            }
            return -1;
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEID.Text != string.Empty && txtAID.Text != string.Empty && txtOMarks.Text != string.Empty)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cm = new SqlCommand("Insert into GroupEvaluation values(@GroupId,@EvaluationId,@ObtainedMarks,@EvaluationDate)", con);
                    cm.Parameters.AddWithValue("@GroupId", txtAID.Text);
                    cm.Parameters.AddWithValue("@EvaluationDate", DateTime.Today);
                    cm.Parameters.AddWithValue("@ObtainedMarks", check(int.Parse(txtOMarks.Text)));
                    cm.Parameters.AddWithValue("@EvaluationId", txtEID.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Plear Enter something in textbox");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void dataGridViewEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewEvaluation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = dataGridViewEvaluation.Rows[e.RowIndex];
                    txtEID.Text = row.Cells["Id"].Value.ToString();
                    txtTmarks.Text = row.Cells["TotalMarks"].Value.ToString();
                    txtEname.Text = row.Cells["Name"].Value.ToString();
                }

            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = dataGridViewGroups.Rows[e.RowIndex];
                    txtAID.Text = row.Cells["GroupId"].Value.ToString();
                }

            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
