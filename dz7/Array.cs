using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class Array : IOutput, IMath, ISort
    {
        public int[] array { get; set; }

        public Array()
        {
            array = new int[5];
        }

        public Array(int n)
        {
            array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(9) + 1;
            }
        }

        public Array(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i];
            }
        }

        public void Show()
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Show();
            Console.WriteLine($"Input string: {info}");
        }

        public int Max()
        {
            if (array != null && array.Length == 0)
                return 0;
            int max = array[0];
            foreach (int i in array)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }

        public int Min()
        {
            if (array != null && array.Length == 0)
                return 0;
            int min = array[0];
            foreach (int i in array)
            {
                if (i < min)
                    min = i;
            }
            return min;
        }

        public float Avg()
        {
            if (array != null && array.Length == 0)
                return 0;
            int sum = 0;
            foreach (int i in array)
                sum += i;
            return (sum / (float)array.Length);
        }

        public bool Search(int valueToSearch)
        {
            foreach (int i in array)
                if (i == valueToSearch)
                    return true;
            return false;
        }

        public void SortAsc()
        {
            bool change;
            do
            {
                change = false;
                for (int i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        change = true;
                    }

            } while (change);
        }

        public void SortDesc()
        {
            bool change;
            do
            {
                change = false;
                for (int i = 0; i < array.Length - 1; i++)
                    if (array[i] < array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        change = true;
                    }

            } while (change);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
        }
    }
}
