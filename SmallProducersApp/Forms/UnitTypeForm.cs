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

namespace SmallProducersApp.Forms
{
    public partial class UnitTypeForm : Form
    {
        public UnitTypeForm()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            try
            {
                UnitType unit = new UnitType();

                string cod = tBoxUnitNumber.Text;
                string name = tBoxUnitName.Text;

                unit.UnitTypeNumber = cod;
                unit.UnitTypeName = name;

                unit.Add();
                tBoxUnitNumber.Text = "";
                tBoxUnitName.Text = "";
                UpdateDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateDataGrid()
        {
            var allUnits = UnitType.GetAll();
            unitDataGrid.DataSource = allUnits;
        }
    }
}
