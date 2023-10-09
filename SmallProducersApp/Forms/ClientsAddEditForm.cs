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
    public partial class ClientsAddEditForm : Form
    {
        public ClientsAddEditForm()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client cli = new Client();

                cli.ClientName = tBoxClientName.Text;
                cli.Address = tBoxAddress.Text;
                cli.ZipCodePart1 = tBoxZipCode1.Text;
                cli.ZipCodePart2 = tBoxZipCode2.Text;
                cli.Location = tBoxLocation.Text;
                if (tBoxNIF.Text != null && tBoxNIF.Text != "")
                {
                    cli.NIF = int.Parse(tBoxNIF.Text);

                }
                if (tBoxPhoneNumber.Text != null && tBoxPhoneNumber.Text != "")
                {

                    cli.PhoneNumber = int.Parse(tBoxPhoneNumber.Text);
                }
                cli.Add();
                tBoxClientName.Text = "";
                tBoxAddress.Text = "";
                tBoxNIF.Text = "";
                tBoxPhoneNumber.Text = "";
                tBoxZipCode1.Text = "";
                tBoxZipCode2.Text = "";
                tBoxLocation.Text = "";
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
