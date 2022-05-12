using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationPanel.Methods
{
    internal class GetItems
    {
        //Method that build's string of SQL-query to get list of items in 'product' table.
        //Includes filtering, acording to name, quantity and category.
        //By default gets every item in table.
        public string getItems(string category, int quantity, string name)
        {
            
            string commandText = "select productname, productquantity, productprice, productcategory from product";
            if (quantity != -1 || name != "" || category != "All")
            {
                commandText += " WHERE";
            }
            if (name != "")
            {
                commandText += " LOWER(productname) LIKE LOWER('%" + name + "%')";
            }
            if (quantity != -1 && name != "")
            {
                commandText += " AND productquantity = " + quantity;
            }
            else if (quantity != -1 && name == "")
            {
                commandText += " productquantity = " + quantity;
            }
            if (category != "All" && (quantity != -1 || name != ""))
            {
                commandText += " AND productcategory LIKE '" + category + "'";
            }
            else if (category != "All" && !(quantity != -1 || name != ""))
            {
                commandText += " productcategory LIKE '" + category + "'";
            }
            return commandText;
        }
    }
}
