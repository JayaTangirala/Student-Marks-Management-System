using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksManagementSystem
{
    internal class IntegerArray
    {
        private int[] A;
        private int maxLength;
        private int length;
        public IntegerArray(int n)
        {
            maxLength = n;
            A = new int[maxLength];
            length = 0;
        }

        public void traverse()
        {
            if (length == 0)
                Console.WriteLine("Array is empty");
            else
            {
                Console.WriteLine("Elements in Array are: ");
                foreach (int element in A)
                    Console.Write(element + "\t");
                Console.WriteLine();
            }
        }

        public void insert(int index, int element)
        {
            if (length >= maxLength)
                Console.WriteLine("Cant insert the element, No space available in the array");
            else
            {
                for (int i = length; i >= index; i--)
                    A[i + 1] = A[i];
                A[index] = element;
                length++;
                Console.WriteLine(element +" is inserted successfully");
            }
        }
        public int search(int element)
        {
            return (Array.IndexOf(A, element));
        }
        public void delete(int element)
        {
            int index = Array.IndexOf(A, element);
            if (index == -1)
            {
                Console.WriteLine(element +" not found!");
                return;
            }
            for (int i = index; i < length; i++)
                A[i] = A[i + 1];
            length--;
            Console.WriteLine(element + " deleted successfully!");
        }

        //Method to compute maximum value in Array A. If Array is empty, return -1.
        public int getMax()
        {
            if (length > 0)
            {
                int max = A[0];
                for (int i = 1; i < length; i++)
                    if (A[i] > max)
                        max = A[i];
                return max;
            }
            return -1;
        }
        //Method to compute minimum value in Array A. If Array is empty, return -1.
        public int getMin()
        {
            if (length > 0)
            {
                int min = A[0];
                for(int i= 1; i < length; i++)
                    if (A[i] < min)
                        min = A[i];
                return min;
            }
            return -1;
        }

        //Method to compute average of all elements in Array A. If Array is empty, return -1.
        public double computeAverage()
        {
            if (length > 0)
            {
                int sum = 0; double avg;
                for (int i = 0; i < length; i++)
                    sum += A[i];
                avg = sum/length;
                return avg;
            }
            return -1;
        }

        //Method to compute number of elements greater than average. If Array is empty, return -1.
        public double countAboveAverage()
        {
            if (length > 0)
            {
                int count = 0; 
                double avg=computeAverage();
                for (int i = 0; i < length; i++)
                    if(A[i] > avg)
                        count++;                
                return count;
            }
            return -1;
        }
    }
}
