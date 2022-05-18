using AdministrationPanel.Methods;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        GetItems getItems = new GetItems();
        ConnectToDatabase dbConn = new ConnectToDatabase();
        private void AddForm_Load(object sender, EventArgs e)
        {
            DataTable categoriesTable = dbConn.dbGet("select categoryname from category");
            for (int i = 0; i < categoriesTable.Rows.Count; i++)
            {
                categories.Items.Add(categoriesTable.Rows[i]["categoryname"].ToString());
            }
        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkIfReadyToAdd() == true)
            {
                createButton.Enabled = true;
            }
            if (categories.SelectedItem == "Add new...")
            {
                categories.DropDownStyle = ComboBoxStyle.DropDown;
                categories.Text = "";
            } else
            {
                categories.Text = "aaa";
                categories.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private bool checkIfReadyToAdd()
        {
            if (priceTB.Text != null && productNameTB.Text != null && quantityTB.Text
                != null && categories.Text != "")
            {
                return true;
            }
            return false;
        }

        private void productNameTB_TextChanged(object sender, EventArgs e)
        {
            if (checkIfReadyToAdd() == true)
            {
                createButton.Enabled = true;
            }
        }

        private void priceTB_TextChanged(object sender, EventArgs e)
        {
            if (checkIfReadyToAdd() == true)
            {
                createButton.Enabled = true;
            }
        }

        private void quantityTB_TextChanged(object sender, EventArgs e)
        {
            if (checkIfReadyToAdd() == true)
            {
                createButton.Enabled = true;
            }
        }

        private void categories_TextUpdate(object sender, EventArgs e)
        {
            if (checkIfReadyToAdd() == true)
            {
                createButton.Enabled = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string category;
            if (categories.SelectedItem != null)
            {
                category = categories.SelectedItem.ToString();
                label5.Text = categories.SelectedItem.ToString();
                if (dbConn.dbCheckCategoryExistence(category.ToLower()) == false)
                {
                    dbConn.dbAddCategory(category);
                };
                dbConn.dbAddProduct(productNameTB.Text, Convert.ToInt32(quantityTB.Text), float.Parse(priceTB.Text), categories.SelectedItem.ToString());
            } else
            {
                category = categories.Text;
                label5.Text = categories.Text;
                if (dbConn.dbCheckCategoryExistence(category.ToLower()) == false)
                {
                    dbConn.dbAddCategory(category);
                };
                dbConn.dbAddProduct(productNameTB.Text, Convert.ToInt32(quantityTB.Text), float.Parse(priceTB.Text), categories.Text);
            }
            productNameTB.Text = null;
            quantityTB.Text = null;
            priceTB.Text = null;
            categories.SelectedIndex = 2;
            createButton.Enabled = false;
        }

        private void priceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void quantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}


