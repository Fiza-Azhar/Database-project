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
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            getEvaluationData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                if (txtName.Text != string.Empty && txtTotalMarks.Text != string.Empty && txtWeightage.Text != string.Empty)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Evaluation (Name,TotalMarks,TotalWeightage) values (@Name,@TotalMarks,@TotalWeightage)", con);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@TotalMarks", txtTotalMarks.Text);
                    cmd.Parameters.AddWithValue("@TotalWeightage", txtWeightage.Text);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    MessageBox.Show("Successfully Added");
                    getEvaluationData();
                    this.Show();
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
        private void getEvaluationData()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Evaluation", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dta = new DataTable();
                sd.Fill(dta);
                dataGridViewEvaluation.DataSource = dta;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void lbTotalMarks_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
