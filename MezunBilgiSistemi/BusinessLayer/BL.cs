using MezunBilgiSistemi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunBilgiSistemi.BusinessLayer
{
    public static class BL
    {
        public static string PATH = @"mezunListesi.txt";
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
            mlist.Add(m);
            mlist.Add(m);
            mlist.Add(m);
            SerializeAndWrite(mlist);
        }
    }
}
