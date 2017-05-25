using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MezunBilgiSistemi.Models;

namespace MezunBilgiSistemi.ADT.Heap
{
    public class HeapADT
    {
        private HeapNode[] heapArray;
        private int maxSize;
        private int currentSize;
        public HeapADT(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapNode[maxSize];
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Mezun value)
        {
            if (currentSize == maxSize)
                return false;
            HeapNode newHeapDugumu = new HeapNode(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = heapArray[index];
            while (index > 0 && heapArray[parent].BasariDerecesi < bottom.BasariDerecesi)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapNode RemoveMax()
        {
            HeapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && heapArray[leftChild].BasariDerecesi < heapArray[rightChild].BasariDerecesi)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.BasariDerecesi >= heapArray[largerChild].BasariDerecesi)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public List<Mezun> DisplayHeap()
        {
            List<Mezun> mezunlar = new List<Mezun>();
            for (int i = 0; i < currentSize; i++)
                mezunlar.Add(heapArray[i].Mezun);
            return mezunlar;
        }

    }
}
