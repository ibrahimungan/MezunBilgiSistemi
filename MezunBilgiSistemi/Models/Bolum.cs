using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi.Models
{
    public class Bolum
    {
        public string BolumAdi { get; set; }
        public DateTime BaslangicYili { get; set; }
        public DateTime BitisYili{ get; set; }
        public double NotOrtalamasi { get; set; }
        public bool BasariBelgesiAlmisMi { get; set; }
    }
}
