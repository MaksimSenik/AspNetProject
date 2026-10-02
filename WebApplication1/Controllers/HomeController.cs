using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Взрослая академия\\Desktop\\my site\\AspNetProject\\WebApplication1\\DataBase\\Database1.mdf\";Integrated Security=True";

        List<Customer> customers = new List<Customer>();
        public IActionResult Index()
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from [dbo].[Customers]")) 
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string email = reader.GetString(2);
                            customers.Add(new Customer(id, name, email));
                        }
                    }
                }

            }
            return View(customers);
        }

        public IActionResult AboutToxin()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bio()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
