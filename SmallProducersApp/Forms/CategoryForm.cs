﻿using SmallProducersApp.Models;
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
                catch (Exception ex1)
                {

                    throw new Exception("Erro no campo do iva." + ex1.Message);
                }

                if (Category.Iva > 100)
                {
                    throw new Exception("O iva não o pode 100");
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
            categoryDataGrid.Columns["CategoryID"].HeaderText = "Código";
            categoryDataGrid.Columns["CategoryName"].HeaderText = "Nome da Categoria";
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            var listSelectedRows = new List<ProductCategory>();

            for (int index = 0; index < categoryDataGrid.SelectedRows.Count; index++)
            {
                var selectedRow = categoryDataGrid.SelectedRows[index];
                var prodCat = (ProductCategory)selectedRow.DataBoundItem;

                listSelectedRows.Add(prodCat);
            }

            foreach (ProductCategory cat in listSelectedRows)
            {
                ProductCategory.Delete(cat.CategoryID);
            }

            UpdateDataGrid();
        }
    }
}
