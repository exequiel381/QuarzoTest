using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbConnection
    {
        public SqlConnection connection { get; set; }

        public void Connect()
        {
            try
            {
                connection = new SqlConnection(@"Server=localhost;Database=BDCrudTest;Trusted_Connection=True;");
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
                connection.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
