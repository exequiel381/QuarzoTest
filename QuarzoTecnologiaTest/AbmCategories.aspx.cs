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
    public partial class AbmCategories : System.Web.UI.Page
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropCategories.DataSource = _categoryRepository.GetAllCategories();
                DropCategories.DataTextField = "NombCateg";
                DropCategories.DataValueField = "IdCategori";
                DropCategories.DataBind();
                DropCategories.Items.Insert(0, "Select a category");
            }
        }
        public void CategoryIndexChangue(object sender, EventArgs e)
        {
            int categoryId;
            if (int.TryParse(DropCategories.SelectedValue, out categoryId))
            {
                var category = _categoryRepository.GetAllCategories().Where(c => c.IdCategori == categoryId).FirstOrDefault();
                txtId.Text = category.IdCategori.ToString();
                txtName.Text = category.NombCateg;
                cbxActive.Checked = category.EsActiva;
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                cbxActive.Checked = false;
            }
        }

        public void UpdateCategory(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtId.Text != "")
                {
                    _categoryRepository.UpdateCategory(txtId.Text, txtName.Text, cbxActive.Checked);
                    Message.ForeColor = System.Drawing.Color.Green;
                    Message.Text = "The category was updated correctly";
                }
                else
                {
                    Message.ForeColor = System.Drawing.Color.Red;
                    Message.Text = "You must select a category and place a name";
                }
            }
            catch (Exception ex)
            {
                Message.ForeColor = System.Drawing.Color.Red;
                Message.Text = "There was a problem updating the category";
            }
        }

        public void goToNewCategory(object sender, EventArgs e)
        {
            Response.Redirect("NewCategory.aspx");
        }

        public void DeleteCategory(object sender, EventArgs e)
        {
            try
            {
                int categoryId;
                if (int.TryParse(DropCategories.SelectedValue, out categoryId))
                {
                    _categoryRepository.DeleteCategory(categoryId);
                    Message.ForeColor = System.Drawing.Color.Green;
                    Message.Text = "The category was deleted correctly";
                }
                else
                {
                    txtId.Text = "";
                    txtName.Text = "";
                    cbxActive.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Message.ForeColor = System.Drawing.Color.Red;
                Message.Text = "There was a problem deleting the category";
            }
        }
    }


}
