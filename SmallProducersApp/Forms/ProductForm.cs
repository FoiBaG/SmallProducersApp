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

            foreach (ProductCategory item in c)
            {
                comboProductCategory.Items.Add(item.CategoryName);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                Product newProduct = new Product();
                newProduct.Name = tBoxProductName.Text;

                try
                {
                    newProduct.ProductNumber = int.Parse(tBoxProductNumber.Text);

                }
                catch (Exception)
                {

                    throw new Exception("O valor do campo Product Number " + tBoxProductNumber.Text + " não pode ser convertido para um numero.");

                }

                string comboBoxProductCategory = "";
                string comboBoxProductUnit = "";

                if (comboProductCategory.SelectedItem != null)
                {
                    comboBoxProductCategory = comboProductCategory.SelectedItem.ToString();
                }
                else
                {
                    throw new Exception("Selecione um valor no campo categoria.");
                }


                if (comboProductUnit.SelectedItem != null)
                {
                    comboBoxProductUnit = comboProductUnit.SelectedItem.ToString();
                }
                else
                {
                    throw new Exception("Selecione um valor no campo Unidade.");
                }


                List<ProductCategory> categorySearch = ProductCategory.Get(comboBoxProductCategory);

                if (categorySearch.Count == 0)
                {
                    throw new Exception("A categoria escolhida j;á nºãõ existe.");
                }
                else
                {

                    newProduct.CategoryID = categorySearch[0].CategoryID;
                }

                List<UnitType> unitSearch = UnitType.Get(comboBoxProductUnit);

                if (unitSearch.Count == 0)
                {
                    throw new Exception("A categoria escolhida j;á nºãõ existe.");
                }
                else
                {

                    newProduct.UnitTypeID = unitSearch[0].UnitTypeID;
                }

                newProduct.Add();
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

            dataGridProducts.Columns["Id"].HeaderText = "Código";
            dataGridProducts.Columns["ProductName"].HeaderText = "Nome do Produto";
            dataGridProducts.Columns["CategoryID"].HeaderText = "Categoria";
            dataGridProducts.Columns["UnitType"].HeaderText = "Unidade";
        }

        private void UpdateComboPoductUnit()
        {
            List<UnitType> units = UnitType.GetAll();

            foreach (UnitType unit in units)
            {
                comboProductUnit.Items.Add(unit.UnitTypeName);
            }
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

        private void btnUnitType_Click(object sender, EventArgs e)
        {
            UnitTypeForm unit = new UnitTypeForm();
            unit.ShowDialog();
        }
    }
}
