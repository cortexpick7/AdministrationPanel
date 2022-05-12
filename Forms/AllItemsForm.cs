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
using AdministrationPanel.Methods;

namespace AdministrationPanel.Forms
{
    public partial class AllItemsForm : Form
    {
        GetItems getItems = new GetItems();
        ConnectToDatabase dbConn = new ConnectToDatabase();
        int quantity = 0;
        string name = "";

        public AllItemsForm()
        {
            InitializeComponent();
        }

        private void AllItemsForm_Load(object sender, EventArgs e)
        {
            
            if (isZero.Checked == true)
            {
                quantity = 0;
            }
            else
            {
                quantity = -1;
            }

            dataGridView1.DataSource = dbConn.dbGet(getItems.getItems("All", -1, ""));
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Quantity";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Category";
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            if (dataGridView1.Rows.Count == 0)
            {
                label1.Visible = true;
            } else
            {
                label1.Visible = false;
            }
            DataTable categoriesTable = dbConn.dbGet("select categoryname from category");
            for (int i = 0; i < categoriesTable.Rows.Count; i++)
            {
                filterCategory.Items.Add(categoriesTable.Rows[i]["categoryname"].ToString());
            }
            filterCategory.Text = "All";

        }
        

                        

    private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dbConn.dbGet(getItems.getItems(filterCategory.Text, quantity, textBox1.Text));
            if (dataGridView1.Rows.Count == 0)
            {
                label1.Visible = true;

            }
            else
            {
                label1.Visible = false;
                dataGridView1.Columns[0].HeaderText = "Name";
                dataGridView1.Columns[1].HeaderText = "Quantity";
                dataGridView1.Columns[2].HeaderText = "Price";
                dataGridView1.Columns[3].HeaderText = "Category";
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbConn.dbGet(getItems.getItems("All", -1, ""));
            filterCategory.Text = "All";
            trackBar1.Value = -1;
            textBox1.Text = "";
            isZero.Checked = false;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Quantity";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Category";
            if (dataGridView1.Rows.Count == 0)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void isZero_CheckedChanged(object sender, EventArgs e)
        {
            if (isZero.Checked == true)
            {
                quantity = 0;
            } else
            {
                quantity = -1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            dataGridView1.DataSource = dbConn.dbGet(getItems.getItems(filterCategory.Text, quantity, textBox1.Text));
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Quantity";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Category";
        }
    }
}
