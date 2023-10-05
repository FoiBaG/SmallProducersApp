using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallProducersApp.Models;

namespace SmallProducersApp.Forms
{
    public partial class ClientForm : Form
    {
        ClientsAddEditForm clientsAddEditForm = new ClientsAddEditForm();

        public ClientForm()
        {
            InitializeComponent();
            UpdateDataGridClients();
        }

        public void UpdateDataGridClients()
        {
            List<Client> client = Client.GetAll();
            dataGridClients.DataSource = client;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

            clientsAddEditForm.ShowDialog();
            UpdateDataGridClients();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tBoxProductName.Text.Count() == 1)
            {
                List<Client> searchClient = Client.GetStartWith(tBoxProductName.Text);
                dataGridClients.DataSource = searchClient;
            }
            else 
            {
                List<Client> searchClient = Client.GetLike(tBoxProductName.Text);
                dataGridClients.DataSource= searchClient;
            }

            
        }
    }
}
