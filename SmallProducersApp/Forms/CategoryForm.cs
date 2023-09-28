using SmallProducersApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallProducersApp
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            ProductCategory Category = new ProductCategory();

            try
            {

                Category.CategoryName = tBoxCategoryName.Text;

                try
                {
                    Category.Iva = float.Parse(tBoxIVA.Text);
                }
                catch (Exception)
                {

                    throw new Exception("Erro no campo do iva.");
                }


                Category.Add();
                UpdateDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }


        }

        private void UpdateDataGrid()
        {
            var allCategory = ProductCategory.GetAll();
            categoryDataGrid.DataSource = allCategory;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {

            //criar lista vazia de ProductCategory
            var listSelectedRows = new List<ProductCategory>();


            //encher a lista com os linhas selecionadas da DataGrid
            for (int index = 0; index < categoryDataGrid.SelectedRows.Count; index++)
            {
                var selectedRow = categoryDataGrid.SelectedRows[index];
                var prodCat = (ProductCategory)selectedRow.DataBoundItem;

                listSelectedRows.Add(prodCat);
            }

            //por cada elemento da lista, chamar o metedo Delete
            foreach (ProductCategory cat in listSelectedRows)
            {
                ProductCategory.Delete(cat.CategoryID);
            }

            //atualizar o datagrid
            UpdateDataGrid();
        }
    }
}
