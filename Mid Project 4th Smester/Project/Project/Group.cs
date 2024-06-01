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
    public partial class Group : Form
    {
        
        public Group()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            SqlCommand c = new SqlCommand("Insert into [Group] values (@creatdate)", con);
            c.Parameters.AddWithValue("@creatdate", DateTime.Today);
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            GetGroupData();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            GetGroupData();
        }

        private void GetGroupData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From [Group]", con);
            DataTable dt = new DataTable();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dataGridViewGroups.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstPage fp = new FirstPage();
            fp.Show();
        }
        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewGroups.Rows[e.RowIndex];
                    Group_Formation_And_Management g = new Group_Formation_And_Management(row.Cells["Id"].Value.ToString());
                    g.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
