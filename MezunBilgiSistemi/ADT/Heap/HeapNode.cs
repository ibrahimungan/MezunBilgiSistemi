using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MezunBilgiSistemi.Models;

namespace MezunBilgiSistemi.ADT.Heap
{
    public class HeapNode
    {
        public Mezun Mezun { get; set; }
        public double BasariDerecesi { get; set; }

        public HeapNode(Mezun mezun)
        {
            this.Mezun = mezun;
            foreach (var bolum in this.Mezun.BolumBilgileri)
            {
                this.BasariDerecesi = bolum.NotOrtalamasi;
                if (bolum.BasariBelgesiAlmisMi == true)
                {
                    BasariDerecesi += 10;
                }
            }
            
        }
    }
}
