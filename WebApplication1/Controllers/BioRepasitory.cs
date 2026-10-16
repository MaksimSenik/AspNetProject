using Microsoft.Data.SqlClient;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public static class BioRepasitory
    {
        public static List<Bio> bios = new List<Bio>();

        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Взрослая академия\\Desktop\\Новая папка (2)\\AspNetProject\\WebApplication1\\DataBase\\Database1.mdf\";Integrated Security=True";

        public static List<Bio> GetBios() 
        {
            bios.Clear();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("Select * from [dbo].[Bios]", conn);
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bios.Add(new Bio(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                    }
                }
            }
            return bios;
        }

    }
}
