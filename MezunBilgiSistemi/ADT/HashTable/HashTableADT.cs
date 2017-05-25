using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MezunBilgiSistemi.Models;
using MezunBilgiSistemi.ADT.Heap;

namespace MezunBilgiSistemi.ADT.HashTable
{
    public class HashTableADT
    {
        Dictionary<string, HeapADT> bolumlerTablosu;
        public HashTableADT()
        {
            bolumlerTablosu = new Dictionary<string, HeapADT>();
        }
        public HeapADT BolumHeapiniGetir(string bolumAdi)
        {
            return bolumlerTablosu[bolumAdi];
        }
        public void BolumEkle(string bolumAdi, HeapADT bolumHeap)
        {
            this.bolumlerTablosu[bolumAdi] = bolumHeap;
        }
        public void BolumSil(string bolumAdi)
        {
            this.bolumlerTablosu.Remove(bolumAdi);
        }
    }
}
