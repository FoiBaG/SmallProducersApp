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

            List<Client> searchClient = Client.GetAll();
            
            if (tBoxSearchClientName.Text != null)
            {

                List<Client> searchClientName;

                if (tBoxSearchClientName.Text.Count() == 1)
                {
                    searchClientName = searchClient.FindAll(Client => Client.ClientName.ToLower().First().Equals(tBoxSearchClientName.Text.ToLower()));
                }
                else
                {
                    searchClientName = searchClient.FindAll(Client => Client.ClientName.ToLower().Contains(tBoxSearchClientName.Text.ToLower()));
                }
                searchClient = searchClientName;
            }

            if (tBoxSearchLocation.Text != null)
            {

                List<Client> searchClientLocation;

                if (tBoxSearchLocation.Text.Count() == 1)
                {
                    searchClientLocation = searchClient.FindAll(Client => Client.Location.ToLower().First().Equals(tBoxSearchLocation.Text.ToLower()));
                }
                else
                {
                    searchClientLocation = searchClient.FindAll(Client => Client.Location.ToLower().Contains(tBoxSearchLocation.Text.ToLower()));
                }
                searchClient = searchClientLocation;
            }

            if (tBoxSearchNIF.Text != null)
            {

                List<Client> searchClientNIF;

                if (tBoxSearchNIF.Text.Count() == 1)
                {
                    searchClientNIF = searchClient.FindAll(Client => Client.NIF.ToString().First().Equals(tBoxSearchNIF.Text));
                }
                else
                {
                    searchClientNIF = searchClient.FindAll(Client => Client.NIF.ToString().Contains(tBoxSearchNIF.Text));
                }
                searchClient = searchClientNIF;
            }

            if (tBoxSearchPhoneNumber.Text != null)
            {

                List<Client> searchClientPhoneNumber;

                if (tBoxSearchPhoneNumber.Text.Count() == 1)
                {
                    searchClientPhoneNumber = searchClient.FindAll(Client => Client.PhoneNumber.ToString().First().Equals(tBoxSearchPhoneNumber.Text));
                }
                else
                {
                    searchClientPhoneNumber = searchClient.FindAll(Client => Client.PhoneNumber.ToString().Contains(tBoxSearchPhoneNumber.Text));
                }
                searchClient = searchClientPhoneNumber;
            }

            dataGridClients.DataSource = searchClient;

        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            var listSelectedRows = new List<Client>();

            for (int index = 0; index < dataGridClients.SelectedRows.Count; index++)
            {
                var selectedRow = dataGridClients.SelectedRows[index];
                var cli = (Client)selectedRow.DataBoundItem;

                listSelectedRows.Add(cli);
            }

            foreach (Client client in listSelectedRows)
            {
                Client.Delete(client.ClientID);
            }

            UpdateDataGridClients();
        }
    }
}
