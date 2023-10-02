using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SortingAlgorithms
    {
        /// <summary>
        ///     Bubble sort compares two consecutive elements, if unsorted, swap them.
        ///     
        ///     Time:  Θ(n^2)
        ///     space: Θ(1)
        /// </summary>
        /// <param name="lst">List to sort</param>
        public static void BubbleSort(List<int> lst)
        {
            // Repeat sort x times (x is the size of the list)
            for (int x = 0; x < lst.Count; x++) {
                // Compare every 2 elements of the list
                for (int y = 0; y < lst.Count - 1; y++)
                {
                    // Compare consecutive elements
                    if (lst[y] > lst[y + 1])
                    {
                        (lst[y + 1], lst[y]) = (lst[y], lst[y + 1]); // Tuple swap
                    }

                }
            }
        }

        /// <summary>
        ///     Insertion sort compares two consecutive elements, if unsorted, swap the element until it is sorted.
        ///     
        ///     Time:  Θ(n^2)
        ///     space: Θ(1)
        /// </summary>
        /// <param name="lst">List to sort</param>
        public static void InsertionSort(List<int> lst)
        {
            // Staring at the first element, reach every element
            for (int x = 1; x < lst.Count; x++)
            {
                var pos = x;
                // Compare the current element to the previous element (local max)
                while (pos >= 1 && lst[pos] < lst[pos - 1])
                {
                    // Swap elements until element is in place
                    (lst[pos - 1], lst[pos]) = (lst[pos], lst[pos - 1]);
                    pos--;
                }
                             
            }
        }

        /// <summary>
        ///     Merge sort is a recursive algorithm that splits a data set in half until every element is in a set by itself.
        ///      once split, the algorithm sorts consecutive sets until it becomes a single set again.
        ///      
        ///     Time:  Θ(n log(n))
        ///     space: Θ(n)
        /// </summary>
        /// <param name="lst">List to sort</param>
        /// <returns>Sorted list</returns>
        public static List<int> MergeSort(List<int> lst)
        {
            // Base case: Stop splitting at a list of a single element
            if (lst.Count <= 1)
            {
                return lst;
            }

            var middle = lst.Count / 2;

            // Split lists into two
            var left  = ListSplit(0, middle, lst);
            var right = ListSplit(middle, lst.Count, lst);

            // Further split the lists in two
            left  = MergeSort(left);
            right = MergeSort(right);

            // Merge the sorted halves
            return MergeSortHelper(left, right);
        }

        /// <summary>
        ///     Helper method to MergeSort. Sort and merge two sorted lists.
        /// </summary>
        /// <param name="left">First list, form the left side of the original set</param>
        /// <param name="right">Second list, form the right side of the original set</param>
        /// <returns>Combined sorted list of left and right</returns>
        private static List<int> MergeSortHelper(List<int> left, List<int> right)
        {
           var result = new List<int>();

            // Loop until both lists are empty
            while (left.Count > 0 || right.Count > 0)
            {
                // Compare left and right lists
                if (left.Count > 0 && right.Count > 0)
                {
                    // Compare first elements of both lists
                    if (left.First() <= right.First())
                    {
                        // Left side take
                        RemoveAndAdd(result, left);
                        continue;
                    }

                    // Right side take
                    RemoveAndAdd(result, right);
                }
                // Add remaining elements in the left list
                else if (left.Count > 0)
                {
                    RemoveAndAdd(result, left);
                }
                // Add remaining elements in the right list
                else if (right.Count > 0)
                {
                    RemoveAndAdd(result, right);
                }
            }

            return result;
        }

        /// <summary>
        ///     ADD first element from remove(list) into add(list). Then REMOVE that element from remove(list).
        /// </summary>
        /// <param name="add">List to add to</param>
        /// <param name="remove">List to remove from</param>
        private static void RemoveAndAdd(List<int> add, List<int> remove)
        {
            add.Add(remove.First());
            remove.Remove(remove.First());
        }

        /// <summary>
        ///     Split a list from start index up to end index
        /// </summary>
        /// <param name="start">Start index</param>
        /// <param name="end">End index (not including)</param>
        /// <param name="lst">List to split from</param>
        /// <returns>New split list</returns>
        public static List<int> ListSplit(int start, int end, List<int> lst)
        {
            var newArr = new List<int>();

            for(int x = start; x < end; x++)
            {
                newArr.Add(lst[x]);
            }

            return newArr;
        }
    }
}
