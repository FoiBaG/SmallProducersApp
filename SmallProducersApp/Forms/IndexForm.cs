using SmallProducersApp.Forms;
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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm products = new ProductForm();
            products.ShowDialog();
        }
    }
}
