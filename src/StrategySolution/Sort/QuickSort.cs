using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySolution.Sort
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
