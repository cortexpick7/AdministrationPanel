using Npgsql;
using System.Data;


namespace AdministrationPanel.Methods
{
    internal class ConnectToDatabase
    {
        public DataTable dbCommunication(string operation, string command)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ProductDatabase;User Id=postgres;Password=1234");
            NpgsqlCommand comm = new NpgsqlCommand();
            if (operation == "connect")
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = command;
                NpgsqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                } else
                {
                    return null;
                }
               
            } else if (operation == "disconnect")
            {
                comm.Dispose();
                conn.Close();
                return null;
            } else
            {
                return null;
            }

        }
    }
}
