using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public static class ProductRepasitory
    {
        public static List<Product> products = new List<Product>();

        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Взрослая академия\\Desktop\\Новая папка (2)\\AspNetProject\\WebApplication1\\DataBase\\Database1.mdf\";Integrated Security=True";

        public static List<Product> GetProducts()
        {
            products.Clear();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from [dbo].[Products]", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                    }
                }

            }
            return products;
        }
    }
}
