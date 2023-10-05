using SmallProducersApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProducersApp.Models
{
    public class UnitType
    {
        [Key]
        public int UnitTypeID { get; set; }
        [Required]
        public string UnitTypeNumber { get; set; }
        public string UnitTypeName { get; set; }

        public UnitType(string Number, string Name)
        {
            this.UnitTypeNumber = Number;
            this.UnitTypeName = Name;
        }

        public UnitType()
        {

        }

        public void Add()
        {
            try
            {
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.UnitType.Add(this);
                sp.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static List<UnitType> GetAll()
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.UnitType.ToList();
            return x;

        }
        public static UnitType Get(int id)
        {
            SmallProducersContext sp = new SmallProducersContext();
            UnitType x = sp.UnitType.First(c => c.UnitTypeID == id);
            return x;
        }
        public static List<UnitType> Get(string Name)
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.UnitType.Where(c => c.UnitTypeName == Name).ToList();
            return x;
        }
        public static void Delete(int id)
        {
            UnitType unit = Get(id);
            if (unit != null)
            {
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.UnitType.Remove(unit);
                sp.SaveChanges();
            }
        }
        public static void Edit(int id, UnitType newdata)
        {
            UnitType edit = Get(id);
            if (edit != null)
            {
                edit.UnitTypeName = newdata.UnitTypeName;

                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.UnitType.Update(edit);
                sp.SaveChanges();
            }
            else
            {
                throw new Exception("O produto com o id " + id.ToString() + " não foi encontrado na base de dados.");
            }
        }
    }
}
