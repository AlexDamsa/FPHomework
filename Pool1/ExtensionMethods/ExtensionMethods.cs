using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static bool GetInt (this ref int instance)
        {
            if (int.TryParse(Console.ReadLine(), out instance))
            {
                return true;
            }

            Console.Write("try again: ");
            return instance.GetInt();
        }

        public static bool GetPositiveInt(this ref int instance)
        {
            if (int.TryParse(Console.ReadLine(), out instance) && instance > 0)
            {
                return true;
            }

            Console.Write("try again: ");
            return instance.GetInt();
        }

        public static bool GetNonNegativeInt(this ref int instance)
        {
            if (int.TryParse(Console.ReadLine(), out instance) && instance >= 0)
            {
                return true;
            }

            Console.Write("try again: ");
            return instance.GetInt();
        }

        public static int Lenght(this int instance)
        {
            if (instance != 0)
            {
                return 1 + (instance / 10).Lenght();
            }

            return 0;
        }

        
        public static int Sum(this int[] instance)
        {
            int sum = 0;
            foreach(int x in instance)
            {
                sum += x;
            }

            return sum;
        }

        public static void Write(this int[] instance)
        {
            foreach (int x in instance)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        

        public static void Reverse(this int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(i, array.Length - i - 1);
            }

            void Swap(int index1, int index2)
            {
                int aux = array[index1];
                array[index1] = array[index2];
                array[index2] = aux;
            }
        }

        public static void FillArray(this int[] instance)
        {
            for (int i = 0; i < instance.Length; i++)
            {
                Console.Write($"array[{i}]= ");
                instance[i].GetInt();
            }
        }

        public static void RotateLeft(this int[] instance)
        {
            int firstElement = instance[0];

            for (int i = 1; i < instance.Length; i++)
            {
                instance[i - 1] = instance[i];
            }

            instance[instance.Length - 1] = firstElement;
        }

        public static void RotateLeft(this int[] instance, int k)
        {
            for (int i = 0; i < k; i++)
            {
                instance.RotateLeft();
            }
        }

        public static int BinarySearch(this int[] instance, int element)
        {
            int left;
            int right;
            int mid;

            left = 0;
            right = instance.Length - 1;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (element < instance[mid])
                {
                    right = mid - 1;
                }
                else if (element > instance[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static void SelectionSort(this int[] instance)
        {
            for (int i = 0; i < instance.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < instance.Length; j++)
                {
                    if (instance[j] < instance[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = instance[minIndex];
                instance[minIndex] = instance[i];
                instance[i] = temp;
            }
        }


        public static void InsertionSort(this int[] instance)
        {
            for (int i = 1; i < instance.Length; ++i)
            {
                int key = instance[i];
                int j = i - 1;

                while (j >= 0 && instance[j] > key)
                {
                    instance[j + 1] = instance[j];
                    j--;
                }
                instance[j + 1] = key;
            }
        }

        public static int[] Sequence(this int[] instance, int startingIndex, int endingIndex)
        {
            if (instance == null && instance.Length == 0)
            {
                return null;
            }
            else if ((startingIndex < 0 || startingIndex >= instance.Length) || (endingIndex < 0 || endingIndex >= instance.Length))
            {
                return null;
            }

            List<int> newArray = new List<int>();
            for (int i = startingIndex; i < endingIndex; i++)
            {
                newArray.Add(instance[i]);
            }
            return newArray.ToArray();
        }

        public static void QuickSort(this int[] instance, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(instance, left, right);

                if (pivot > 1)
                {
                    QuickSort(instance, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(instance, pivot + 1, right);
                }
            }

            int Partition(int[] arr, int leftP, int rightP)
            {
                int pivot = arr[leftP];
                while (true)
                {

                    while (arr[leftP] < pivot)
                    {
                        leftP++;
                    }

                    while (arr[rightP] > pivot)
                    {
                        rightP--;
                    }

                    if (leftP < rightP)
                    {
                        if (arr[leftP] == arr[rightP]) return rightP;

                        int temp = arr[leftP];
                        arr[leftP] = arr[rightP];
                        arr[rightP] = temp;


                    }
                    else
                    {
                        return rightP;
                    }
                }
            }
        }

        public static void MergeSort(this int[] instance, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;

                MergeSort(instance, left, m);
                MergeSort(instance, m + 1, right);

                Merge(instance, left, m, right);
            }

            void Merge(int[] array, int l, int m, int r)
            {
                int n1 = m - l + 1;
                int n2 = r - m;

                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                for (i = 0; i < n1; ++i)
                    L[i] = array[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = array[m + 1 + j];

                i = 0;
                j = 0;

                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        array[k] = L[i];
                        i++;
                    }
                    else
                    {
                        array[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    array[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    array[k] = R[j];
                    j++;
                    k++;
                }
            }
        }
    }
}
