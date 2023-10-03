using SmallProducersApp.Models;
using SmallProducersApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallProducersApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            UpdateDataGrid();
            UpdateComboPoductCategory();
            UpdateComboPoductUnit();
        }

        private void UpdateComboPoductCategory()
        {
            List<ProductCategory> c = ProductCategory.GetAll();

            //List<string> medidas = new List<string> { "one", "two", "three" };

            foreach (ProductCategory item in c)
            {
                comboProductCategory.Items.Add(item.CategoryName);
            }





        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                Product p = new Product();
                p.Name = tBoxProductName.Text;

                string valorDaCombo = "";
                string valorDaComboUnit = "";

                if (comboProductCategory.SelectedItem != null)
                {
                    valorDaCombo = comboProductCategory.SelectedItem.ToString();
                }
                else
                {
                    throw new Exception("Selecione um valor no campo categoria.");
                }

                if (comboProductUnit.SelectedItem != null)
                {
                    valorDaComboUnit = comboProductUnit.SelectedItem.ToString();
                    p.UnitType = valorDaComboUnit;
                }
                else
                {
                    throw new Exception("Selecione um valor no campo Unidade.");
                }

                var pesquisaCategorio = ProductCategory.Get(valorDaCombo);

                if (pesquisaCategorio.Count == 0)
                {
                    throw new Exception("A categoria escolhida j;á nºãõ existe.");
                }
                else
                {
                    p.CategoryID = pesquisaCategorio[0].CategoryID;
                }

                p.Add();
                UpdateDataGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void UpdateDataGrid()
        {
            var allProducts = Product.GetAll();
            dataGridProducts.DataSource = ViewProduct.GetViewFromList(allProducts);
        }

        private void UpdateComboPoductUnit()
        {
            List<string> units = new List<string> { "Unidade", "Caixa", "Litros" };
            comboProductUnit.DataSource = units;
            //comboProductUnit.SelectedItem = "Litros";
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            var listSelectedRows = new List<Product>(dataGridProducts.SelectedRows.Count);

            for (int index = 0; index < dataGridProducts.SelectedRows.Count; index++)
            {
                var selectedRow = dataGridProducts.SelectedRows[index];
                var prodCat = (Product)selectedRow.DataBoundItem;

                listSelectedRows.Add(prodCat);
            }
            foreach (Product cat in listSelectedRows)
            {
                Product.Delete(cat.ProductID);
            }
            UpdateDataGrid();
        }
    }
}
