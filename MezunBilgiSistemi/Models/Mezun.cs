using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi.Models
{
    public enum YabanciDilDuzeyi
    {
        PreIntermediate,
        Intermediate,
        UpperIntermediate,
        Advanced
    }
    public class Mezun
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string ePosta { get; set; }
        public string Uyruk { get; set; }
        public DateTime DogumTarihi { get; set; }
        public long OgrenciNo { get; set; }
        public YabanciDilDuzeyi YabanciDil { get; set; }
        public List<String> IlgiAlanları { get; set; }
        public LinkedList<Staj> StajBilgileri { get; set; }
        public LinkedList<Bolum> BolumBilgileri { get; set; }
    }
}
