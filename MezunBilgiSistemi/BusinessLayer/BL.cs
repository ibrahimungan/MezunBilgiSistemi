using MezunBilgiSistemi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MezunBilgiSistemi.ADT.HashTable;
using MezunBilgiSistemi.ADT.BinaryTree;
using MezunBilgiSistemi.ADT.Heap;



namespace MezunBilgiSistemi.BusinessLayer
{
    public static class BL
    {
        public static HashTableADT hashtable = new HashTableADT();
        public static HeapADT heapYZM = new HeapADT(100);
        public static HeapADT heapMAKINE = new HeapADT(100);

        public static void hashtableDoldur()
        {
            hashtable.BolumEkle("Yazılım", heapYZM);
            hashtable.BolumEkle("Makine", heapMAKINE);
        }

        public static BinarTreeAdt binaryMezunlar = new BinarTreeAdt();

        public static void MezunlariHeapeveAgacaEkle(List<Mezun> mezunListesi)
        {
            //JSON nesnemizde sadece yazılım var
            foreach (var mezun in mezunListesi)
            {
                heapYZM.Insert(mezun);
                binaryMezunlar.Insert(mezun);
            }
        }
        #region  JSON İŞLEMLERİ
        public static string PATH = @"../../mezunListesi.txt";
        public static void SerializeAndWrite(List<Mezun> mezunListesi)
        {
            string json = JsonConvert.SerializeObject(mezunListesi);
            // Write that JSON to txt file,  
            System.IO.File.WriteAllText(PATH , json);
        }
        public static List<Mezun> DeserializeFromFile(string path)
        {
            List<Mezun> mezunListesi = JsonConvert.DeserializeObject<List<Mezun>>(File.ReadAllText(PATH));
            return mezunListesi;
        }
        public static void createFakeJSON()
        {
            LinkedList<Bolum> BolumBilgileri = new LinkedList<Bolum>();
            BolumBilgileri.AddLast( new Bolum() { BasariBelgesiAlmisMi = false,
                                                  BaslangicYili = 2013,
                                                  BitisYili = 2017,
                                                  BolumAdi = "Yazılım Mühendisliği",
                                                  NotOrtalamasi = 70.15});

            LinkedList<Staj> StajBilgileri = new LinkedList<Staj>();
            StajBilgileri.AddLast(new Staj() { SirketAdi="ABC AŞ",
                                                StajDepartmani="Ar-Ge",
                                               StajTarihi = DateTime.Now});
            List<string> ilgiAlanlari = new List<string>();
            ilgiAlanlari.Add("Yazılım");
            ilgiAlanlari.Add("Satranç");


            Mezun m = new Mezun()
            {
                Ad = "Tuğrul",
                Adres = "Turgutlu Manisa",
                BolumBilgileri = BolumBilgileri,
                StajBilgileri = StajBilgileri,
                DogumTarihi = DateTime.Now,
                ePosta = "tugrulcansollu@gmail.com",
                OgrenciNo = 132802036,
                Telefon = "05304840000",
                Uyruk = "TC",
                YabanciDil = YabanciDilDuzeyi.Intermediate,
                IlgiAlanları = ilgiAlanlari
                
            };

            List<Mezun> mlist = new List<Mezun>();
            mlist.Add(m);

            m.Ad = "Muhammet";
            m.OgrenciNo = 13280237;
            m.BolumBilgileri.Last.Value.NotOrtalamasi = 75;
            mlist.Add(m);

            m.Ad = "Halil";
            m.OgrenciNo = 13280226;
            m.BolumBilgileri.Last.Value.NotOrtalamasi = 80;
            mlist.Add(m);

            SerializeAndWrite(mlist);
        }
        #endregion

        public static void olustur()
        {
            List<Mezun> okunanMezunlar = DeserializeFromFile(PATH);
            MezunlariHeapeveAgacaEkle(okunanMezunlar);
            hashtableDoldur();
        }
    }
}
