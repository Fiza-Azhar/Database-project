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
    public partial class ManageProjects : Form
    {
        public ManageProjects()
        {
            InitializeComponent();
        }

        private void ManageProjects_Load(object sender, EventArgs e)
        {
            GetProjectData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Project values (@Description, @Title)", con);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);

                cmd.ExecuteNonQuery();
              

                MessageBox.Show("Successfully saved");
                GetProjectData();
                reset_options();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void GetProjectData()
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Project", con);
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dataGridViewProjects.DataSource = dt;
        }
        private void reset_options()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtTitle.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_options();
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            for (int i = 0; i <= dataGridViewProjects.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand("Update Project set Description = @Description, Title = @Title where Id= @Id", con);
                cmd.Parameters.AddWithValue("Id", dataGridViewProjects.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@Description", dataGridViewProjects.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@Title", dataGridViewProjects.Rows[i].Cells[2].Value);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Updated Successfully");
        }
    }
}
