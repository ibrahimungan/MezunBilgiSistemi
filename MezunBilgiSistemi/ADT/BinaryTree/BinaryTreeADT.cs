using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MezunBilgiSistemi.Models;

namespace MezunBilgiSistemi.ADT.BinaryTree
{
    public class BinarTreeAdt
    {
        public BinaryTreeNode kok;
        public string dugumler;
        public List<Mezun> liste = new List<Mezun>();
        public BinarTreeAdt()
        {
            kok = null;
        }
        //Kok private olduğu için overloaded DugumSayisi fonksiyonu
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }


        public void Insert(Mezun mezun)
        {
            insertRoot(mezun, ref kok);
        }
        private void insertRoot(Mezun mezun, ref BinaryTreeNode LastNode)
        {
            if (LastNode == null)
                LastNode = new BinaryTreeNode(mezun);
            else
            {
                if (mezun.OgrenciNo > LastNode.mezun.OgrenciNo)
                    insertRoot(mezun, ref LastNode.sag);
                else if (mezun.OgrenciNo < LastNode.mezun.OgrenciNo)
                    insertRoot(mezun, ref LastNode.sol);
                else
                    return;
            }
        }


        public BinaryTreeNode Search(long ogrenciNo)
        {
            BinaryTreeNode nextNode = kok;

            while (nextNode != null)
            {
                if (nextNode.mezun.OgrenciNo > ogrenciNo)
                    nextNode = nextNode.sol;
                else if (nextNode.mezun.OgrenciNo < ogrenciNo)
                    nextNode = nextNode.sag;
                else
                    return nextNode;
            }
            return null;
        }



        public int DugumSayisi(BinaryTreeNode dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }

        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }

        public int YaprakSayisi(BinaryTreeNode dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }

        public List<Mezun> MezunlariYazdir()
        {
            return liste;
        }

        public string DugumleriYazdir()
        {
            return dugumler;
        }

        public void PreOrder()
        {
            liste = new List<Mezun>();

            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(BinaryTreeNode dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            liste = new List<Mezun>();

            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(BinaryTreeNode dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(BinaryTreeNode dugum)
        {
            liste.Add(dugum.mezun);
            dugumler += "Ad: " + dugum.mezun.Ad + " Bölüm: " + dugum.mezun.BolumBilgileri.Last.Value.BolumAdi + " " + Environment.NewLine;
        }
        public void PostOrder()
        {
            liste = new List<Mezun>();
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(BinaryTreeNode dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public List<Mezun> Ortalama90UstuMezunlariGetir()
        {
            var list = from mezun in liste where mezun.BolumBilgileri.Last.Value.NotOrtalamasi > 90 select mezun;
            List<Mezun> me = list.ToList<Mezun>();

            return me;
        }

        public List<Mezun> IngilizcesiAdvancedOlanMezunlariGetir()
        {
            var list = from mezun in liste where mezun.YabanciDil == YabanciDilDuzeyi.Advanced select mezun;
            List<Mezun> me = list.ToList<Mezun>();

            return me;
        }

        public int Derinlik(BinaryTreeNode node)
        {
            if (node == null)
                return 0;
            else
            {
                int lDepth = Derinlik(node.sol);
                int rDepth = Derinlik(node.sag);

                if (lDepth > rDepth)
                    return (lDepth + 1);
                else return (rDepth + 1);
            }
        }

    }
}
