using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationPanel.Forms
{
    public partial class AllItemsForm : Form
    {
        public AllItemsForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ProductDatabase;User Id=postgres;Password=1234");
        private void AllItemsForm_Load(object sender, EventArgs e)
        {
            getItems("All", 10000, "");
            getCategories();
            filterCategory.Text = "All";
        }
        private void getItems(string category, int quantity, string name)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from product";
            if (quantity != -1 || name != "" || category != "All")
            {
                comm.CommandText += " WHERE";
            }
            if (name != "")
            {
                comm.CommandText += " productname LIKE '" + name + "%'";
            }
            if (quantity != -1 && name != "")
            {
                comm.CommandText += " AND productquantity < " + quantity;
            }
            else if (quantity != -1 && name == "")
            {
                comm.CommandText += " productquantity < " + quantity;
            }
            if (category != "All" && (quantity != -1 || name != ""))
            {
                comm.CommandText += " AND productcategory ='" + category + "'";
            }
            else if (category != "All" && !(quantity != -1 || name != ""))
            {
                comm.CommandText += " productcategory='" + category +"'";
            }
            label1.Text = comm.CommandText;
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Quantity";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Category";
            comm.Dispose();
            conn.Close();
        }

        private void getCategories()
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select categoryname from category";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

                for (int i=0; i <dt.Rows.Count; i++)
                {
                    filterCategory.Items.Add(dt.Rows[i]["categoryname"].ToString());
                }
            }
            comm.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getItems(filterCategory.Text, trackBar1.Value, textBox1.Text);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getItems("All", 10000, "");
            filterCategory.Text = "All";
            trackBar1.Value = -1;
            textBox1.Text = "";
        }
    }
}
