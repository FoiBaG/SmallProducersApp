using SmallProducersApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProducersApp.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        public int ClientNumber { get; set; }
        [Required]
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string ZipCodePart1 { get; set; }
        public string ZipCodePart2 { get; set; }
        public string Location { get; set; }
        [Required]
        public int NIF { get; set; }
        public int PhoneNumber { get; set; }

        public Client()
        {

        }

        public Client(int clientNumber, string name, string address, int nIF, int phoneNumber)
        {
            ClientNumber = clientNumber;
            ClientName = name;
            Address = address;
            NIF = nIF;
            PhoneNumber = phoneNumber;
        }

        public void Add()
        {
            SmallProducersContext sp = new SmallProducersContext();

            if(this.ClientName.Count() == 0)
            {
                throw new Exception("O campo obrigatório Nome do Cliente não pode estar vazio.");
            }

            if (this.NIF == 0)
            {
                throw new Exception("O campo obrigatório NIF não pode estar vazio.");
            }

            string stringNIF = this.NIF.ToString();

            if (stringNIF.Length < 9)
            {
                throw new Exception("O campo obrigatório NIF não ter menos de 9 digítos.");
            }

            string stringPhone = this.PhoneNumber.ToString();

            if (stringPhone.Length != 9 || stringPhone.StartsWith("9") == false)
            {
                throw new Exception("O campo obrigatório Telemóvel não ter menos de 9 digítos e tem de começar por 9.");
            }

            if (this.ClientName.Count() > 0)
            {
                this.ClientName = FilterCategoryName(this.ClientName);
            }

            var x = sp.Client.Add(this);
            sp.SaveChanges();
        }

        public static List<Client> GetAll()
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.Client.ToList();
            return x;
        }

        public static Client Get(int id)
        {
            SmallProducersContext sp = new SmallProducersContext();
            Client x = sp.Client.First(c => c.ClientID == id);
            return x;
        }
        public static List<Client> Get(string Name)
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.Client.Where(c => c.ClientName == Name).ToList();
            return x;
        }

        public static List<Client> GetLike(string Name)
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.Client.Where(c => c.ClientName.Contains(Name)).ToList();
            return x;
        }

        public static List<Client> GetStartWith(string Name)
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.Client.Where(c => c.ClientName.StartsWith(Name)).ToList();
            return x;
        }

        public static void Delete(int id)
        {
            Client cli = Get(id);
            if (cli != null)
            {
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.Client.Remove(cli);
                sp.SaveChanges();
            }
        }
        public static void Edit(int id, Client newdata)
        {
            Client edit = Get(id);
            if (edit != null)
            {
                edit.ClientName = newdata.ClientName;
                edit.Address = newdata.Address;
                edit.NIF = newdata.NIF;
                edit.PhoneNumber = newdata.PhoneNumber;
                edit.ZipCodePart1 = newdata.ZipCodePart1;
                edit.ZipCodePart2 = newdata.ZipCodePart2;
                edit.Location = newdata.Location;
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.Client.Update(edit);
                sp.SaveChanges();
            }
        }

        private static string FilterCategoryName(string clientName)
        {
            clientName = clientName.Trim();

            clientName = char.ToUpper(clientName[0]) + clientName.Substring(1).ToLower();

            return clientName;
        }
    }
}
