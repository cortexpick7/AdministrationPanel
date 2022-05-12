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
            dataGridView1.DataSource = dbConn.dbCommunication("connect", getItems.getItems("All", -1, ""));
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Quantity";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Category";
            dbConn.dbCommunication("disconnect", null);


            DataTable categoriesTable = dbConn.dbCommunication("connect", "select categoryname from category");
            for (int i = 0; i < categoriesTable.Rows.Count; i++)
            {
                filterCategory.Items.Add(categoriesTable.Rows[i]["categoryname"].ToString());
            }
            dbConn.dbCommunication("disconnect", null);
            filterCategory.Text = "All";

        }
        

                        

    private void button1_Click(object sender, EventArgs e)
        {
            dbConn.dbCommunication("disconnect", null);
            dataGridView1.DataSource = dbConn.dbCommunication("connect", getItems.getItems(filterCategory.Text, quantity, textBox1.Text));
            dbConn.dbCommunication("disconnect", null);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // getItems("All", -1, "");
            filterCategory.Text = "All";
            trackBar1.Value = -1;
            textBox1.Text = "";
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
        }
    }
}
