using Npgsql;
using System.Data;


namespace AdministrationPanel.Methods
{
    internal class ConnectToDatabase
    {
        public DataTable dbGet(string command)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ProductDatabase;User Id=postgres;Password=1234");
            NpgsqlCommand comm = new NpgsqlCommand();
            conn.Open();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = command;
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                comm.Dispose();
                conn.Close();
                return dt;
            } else
            {
                comm.Dispose();
                conn.Close();
                return null;
            }
        }

        public void dbAddProduct(string productName, int quantity, float productPrice, string productCategory)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ProductDatabase;User Id=postgres;Password=1234");
            NpgsqlCommand comm = new NpgsqlCommand();
            conn.Open();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            string commandText = $"INSERT INTO products (productname, productquantity, productprice, productcategory) VALUES (@name, @quantity, @price, @category)";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("name", productName);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("price", productPrice);
                cmd.Parameters.AddWithValue("category", productCategory);

                cmd.ExecuteNonQuery();
            }
            comm.Dispose();
            conn.Close();
        }
        public bool dbCheckCategoryExistence(string category)
        {
            DataTable catNames = dbGet("select LOWER(categoryname) from category");
            for (int i = 0; i < catNames.Rows.Count; i++)
            {
                if ((catNames.Rows[i]["categoryname"].ToString().ToLower() == category.ToLower()))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
