using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProductRepository
    {
        private DbConnection _dbConnection;

        public ProductRepository()
        {
            _dbConnection = new DbConnection();
        }

        public List<Product> GetProductsByCategory(int categoryId = 0)
        {
            _dbConnection.Connect();
            var products = new List<Product>();
            try
            {
                var command = new SqlCommand("Usp_Sel_Co_Productos", _dbConnection.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pCategoryId", categoryId));
                var rows = command.ExecuteReader();
                while (rows.Read())
                {
                    products.Add(new Product()
                    {
                        IdProduct = int.Parse(rows[0].ToString()),
                        NombProduct = rows[1].ToString(),
                        PrecioProd = decimal.Parse(rows[2].ToString()),
                        Category = rows[3].ToString(),
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _dbConnection.Disconnect();
            }
            return products;
        }

    }
}
