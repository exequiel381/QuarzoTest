using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuarzoTecnologiaTest
{
    public partial class NewCategory : System.Web.UI.Page
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void CreateCategory(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    _categoryRepository.CreateCategory(txtId.Text, txtName.Text, cbxActive.Checked);
                    Message.ForeColor = System.Drawing.Color.Green;
                    Message.Text = "The category was created correctly";
                }
            }
            catch (Exception ex)
            {
                Message.ForeColor = System.Drawing.Color.Red;
                Message.Text = "There was a problem creating the category";
            }

        }
    }
}