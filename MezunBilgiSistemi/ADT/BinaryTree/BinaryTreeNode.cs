using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MezunBilgiSistemi.Models;

namespace MezunBilgiSistemi.ADT.BinaryTree
{
    public class BinaryTreeNode
    {
        public Mezun mezun;
        public BinaryTreeNode sol;
        public BinaryTreeNode sag;
        public BinaryTreeNode(Mezun mezun)
        {
            this.mezun = mezun;
            sol = null;
            sag = null;
        }
    }
}
