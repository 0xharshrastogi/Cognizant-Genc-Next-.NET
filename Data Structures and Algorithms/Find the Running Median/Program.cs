using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'runningMedian' function below.
     *
     * The function is expected to return a DOUBLE_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    private static Heap minHeap, maxHeap;
    private static int mid;
    public static List<double> runningMedian(List<int> a)
    {
        minHeap = new Heap(new MinHeap());
        maxHeap = new Heap(new MaxHeap());

        int len = a.Count;
        List<double> result = new List<double>();

        for (int i = 0; i < len; i++)
        {
            insertion(a[i], i);
            result.Add(getMid(i));
        }

        return result;
    }

    private static void insertion(int item, int pos)
    {
        if (pos == 0)
        {
            mid = item;
            return;
        }

        if (item < mid)
            maxHeap.addItem(item);
        else
            minHeap.addItem(item);
    }

    private static double getMid(int pos)
    {
        int minHeapSize = minHeap.getHeapSize();
        int maxHeapSize = maxHeap.getHeapSize();

        if (minHeapSize - maxHeapSize > 1)
        {
            //insert the mid into the Maxheap
            //Make the MinHeap first item the mid
            //heapify the MinHeap
            maxHeap.addItem(mid);
            mid = minHeap.reduceHeap();
        }
        else if (maxHeapSize - minHeapSize > 1)
        {
            minHeap.addItem(mid);
            mid = maxHeap.reduceHeap();
        }

        if ((pos != 0) && ((pos + 1) % 2 == 0))
        {
            int item = minHeapSize > maxHeapSize ? minHeap.getItemAt(0) : maxHeap.getItemAt(0);
            return Math.Round((mid + item) / 2.0, 1);
        }
        else
            return Math.Round(mid * 1.0, 1);
    }

    public class Heap
    {
        public List<int> items;
        IHeap heap;

        public Heap(IHeap heap)
        {
            items = new List<int>();
            this.heap = heap;
        }

        public void addItem(int item)
        {
            items.Add(item);
            insertItem(items.Count - 1);
        }

        public int getHeapSize() => items.Count();
        public int getItemAt(int index) => items[index];

        public List<int> heapSort()
        {
            List<int> lstNew = new List<int>();
            while (items.Count > 0)
            {
                lstNew.Add(items[0]);
                reduceHeap();
            }

            return lstNew;
        }

        public int reduceHeap()
        {
            int cnt = getHeapSize() - 1;
            int val = items[0];
            items[0] = items[cnt];
            items.RemoveAt(cnt);

            heapify(0);
            return val;
        }

        private void insertItem(int i)
        {
            if (i <= 0)
                return;

            int pIndex = getParentNode(i);
            if (heap.insertCompare(items[pIndex], items[i]))
            {
                swap(pIndex, i);
                insertItem(pIndex);
            }
        }

        private void swap(int pIndex, int i)
        {
            int temp = items[pIndex];
            items[pIndex] = items[i];
            items[i] = temp;
        }

        private int getParentNode(int i) => ((i - 1) / 2);

        private void heapify(int pos)
        {
            int leftIndex = pos;
            int rightIndex = pos;
            int index;

            bool boolLeft = getLeft(ref leftIndex);
            bool boolRight = getRight(ref rightIndex);

            if (!boolLeft && !boolRight)
                return;

            index = boolLeft ? (!boolRight ? leftIndex : getIndex(leftIndex, rightIndex)) : rightIndex;

            if (heap.insertCompare(items[pos], items[index]))
            {
                swap(index, pos);
                heapify(index);
            }
        }

        private int getIndex(int leftIndex, int rightIndex)
        {
            if (heap.insertCompare(items[rightIndex], items[leftIndex]))
                return leftIndex;
            else
                return rightIndex;
        }

        private bool getRight(ref int pos)
        {
            pos = pos * 2 + 2;
            return (pos <= (items.Count - 1));
        }

        private bool getLeft(ref int pos)
        {
            pos = pos * 2 + 1;
            return (pos <= (items.Count - 1));
        }
    }

    public interface IHeap
    {
        int getIndex(int left, int right);
        bool insertCompare(int parent, int child);
    }

    public class MaxHeap : IHeap
    {
        public List<int> items = new List<int>();
        public int getIndex(int left, int right)
        {
            throw new NotImplementedException();
        }

        public bool insertCompare(int parent, int child)
        {
            return parent < child;
        }
    }

    public class MinHeap : IHeap
    {
        public List<int> items = new List<int>();
        public int getIndex(int left, int right)
        {
            throw new NotImplementedException();
        }

        public bool insertCompare(int parent, int child)
        {
            return parent > child;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int aCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = new List<int>();

        for (int i = 0; i < aCount; i++)
        {
            int aItem = Convert.ToInt32(Console.ReadLine().Trim());
            a.Add(aItem);
        }

        List<double> result = Result.runningMedian(a);

        textWriter.WriteLine(String.Join("\n", result.Select(s => s.ToString("0.0"))));

        textWriter.Flush();
        textWriter.Close();
    }
}