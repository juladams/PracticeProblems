using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Heap
    {
        public int[] heapSort(int[] arr)
        {
            if (arr.Length < 2)
                return new int[0];

            int n = arr.Length;

            //Build the heap
            for(int i = n/2-1; i>=0; i--)
                maxHeapify(arr, n, i);

            //Extract elements from the heap and pkace them at the end of the array sorted
            for(int i = n-1; i>0; i--)
            {
                //Swap the root with the last element of the array and call maxHeapify on the reduced heap
                int tmp = arr[0];
                arr[0] = arr[i];
                arr[i] = tmp;
                
                //Call maxHeapify(arrays, size, root)
                maxHeapify(arr, i, 0);
            }

            return arr;
        }

        //Method to maxheapify subtree arr = array, size = size, i = root node to start at.
        public int[] maxHeapify(int[] arr, int root, int i)
        {
            int largest = root;
            int leftChild = 2 * root + 1;
            int rightChild = 2 * root + 2;

            //If the left child is larger than the root, set the largest to the left child
            if(leftChild < root && arr[leftChild] > arr[largest])
                largest = leftChild;

            //If the right child is larger than the root, set the largest to the right child
            if(rightChild < root && arr[rightChild] > arr[largest])
                largest = rightChild;

            //If the largest is not the root, swap the root with the largest and call maxHeapify again
            if(largest != root)
            {
                int temp = arr[root];
                arr[root] = arr[largest];
                arr[largest] = temp;

                maxHeapify(arr, root, largest);
            }

            return arr;
        }
    }
}
