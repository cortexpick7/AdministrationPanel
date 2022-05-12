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
       
        public string getItems(string category, int quantity, string name)
        {
            
            string commandText = "select * from product";
            if (quantity != -1 || name != "" || category != "All")
            {
                commandText += " WHERE";
            }
            if (name != "")
            {
                commandText += " productname LIKE '%" + name + "%'";
            }
            if (quantity != -1 && name != "")
            {
                commandText += " AND productquantity < " + quantity;
            }
            else if (quantity != -1 && name == "")
            {
                commandText += " productquantity < " + quantity;
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
