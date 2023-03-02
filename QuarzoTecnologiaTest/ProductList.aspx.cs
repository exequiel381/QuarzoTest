using DataAccess.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuarzoTecnologiaTest
{
    public partial class ProductList : System.Web.UI.Page
    {
        private ProductRepository _productRepository = new ProductRepository();
        private CategoryRepository _categoryRepository = new CategoryRepository();
        private List<Category> _categories;
        public IEnumerable<Product> _products { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _products = _productRepository.GetProductsByCategory();
                _categories = _categoryRepository.GetAllCategories();
                DropCategories.DataSource = _categories;
                DropCategories.DataTextField = "NombCateg";
                DropCategories.DataValueField = "IdCategori";
                DropCategories.DataBind();
                DropCategories.Items.Insert(0, "All");
            }
        }

        protected void DropCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId;
            if (int.TryParse(DropCategories.SelectedValue, out categoryId))
            {
                _products = _productRepository.GetProductsByCategory(categoryId);
            }
            else
            {
                _products = _productRepository.GetProductsByCategory();
            }
        }
    }
}