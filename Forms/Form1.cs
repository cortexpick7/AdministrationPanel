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

namespace AdministrationPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ProductDatabase;User Id=postgres;Password=1234");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from product";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                //dataGridView1.DataSource = dt;
            }
            //dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns[1].HeaderText = "Name";
            //dataGridView1.Columns[2].HeaderText = "Quantity";
            //dataGridView1.Columns[3].HeaderText = "Price";
            //dataGridView1.Columns[4].HeaderText = "Category";
            comm.Dispose();
            conn.Close();
        }
        private Button currentButton;
        private Form activeForm;

        private void ActivateButton(object btnSender)
        {
            
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml("#255064");
                    currentButton.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    currentButton.Font = new System.Drawing.Font("Myriad Pro", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = ColorTranslator.FromHtml("#E6FAFC");
                    previousBtn.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildButton(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void shoppingButton_Click(object sender, EventArgs e)
        {
            OpenChildButton(new Forms.CartForm(), sender);
        }

        private void allProductsButton_Click(object sender, EventArgs e)
        {
            OpenChildButton(new Forms.AllItemsForm(), sender);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenChildButton(new Forms.AddForm(), sender);
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            OpenChildButton(new Forms.StatisticsForm(), sender);
        }
    }
}
