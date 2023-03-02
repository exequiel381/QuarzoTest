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
    public class CategoryRepository
    {
        private DbConnection _dbConnection;

        public CategoryRepository()
        {
            _dbConnection = new DbConnection();
        }

        public List<Category> GetAllCategories()
        {
            _dbConnection.Connect();
            var categories = new List<Category>();
            try
            {
                var command = new SqlCommand("SELECT * FROM coCategoria", _dbConnection.connection);
                var rows = command.ExecuteReader();
                while (rows.Read())
                {
                    categories.Add(new Category()
                    {
                        IdCategori = int.Parse(rows[0].ToString()),
                        NombCateg = rows[1].ToString(),
                        EsActiva = rows[2].ToString() == "1" ? true : false,
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                _dbConnection.Disconnect();
            }
            return categories;
        }

        public void CreateCategory(string categoryId,string name, bool active)
        {
            _dbConnection.Connect();
            try
            {
                var command = new SqlCommand("Usp_Ins_Co_Categoria", _dbConnection.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pCategoryId", int.Parse(categoryId)));
                command.Parameters.Add(new SqlParameter("@pCategoryName", name));
                command.Parameters.Add(new SqlParameter("@pActive", active));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                _dbConnection.Disconnect();
            }
        }

        public void UpdateCategory(string categoryId, string name, bool active)
        {
            _dbConnection.Connect();
            try
            {
                var command = new SqlCommand("Usp_Upd_Co_Categoria", _dbConnection.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pCategoryId", int.Parse(categoryId)));
                command.Parameters.Add(new SqlParameter("@pCategoryName", name));
                command.Parameters.Add(new SqlParameter("@pActive", active));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                _dbConnection.Disconnect();
            }
        }
    }
}
