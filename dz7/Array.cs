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

    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class Array : IOutput, IMath, ISort, ICalc
    {
        public int[] array { get; set; }

        private void Init(uint n, int a, int b)
        {
            this.array = new int[n];
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            Random rand = new Random();
            for (int i = 0; i < this.array.Length; i++)
            {
                this.array[i] = rand.Next(a, b);
            }
        }
        private void Init(uint n)
        {
            this.array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < this.array.Length; i++)
            {
                this.array[i] = rand.Next(10);
            }
        }
        private void Init()
        {
            this.array = new int[5];
            Random rand = new Random();
            for (int i = 0; i < this.array.Length; i++)
            {
                this.array[i] = rand.Next(10);
            }
        }

        public Array()
        {
            Init();
        }
        public Array(uint n)
        {
            Init(n);
        }
        public Array(int[] arr)
        {
            this.array = new int[arr.Length];
            arr.CopyTo(this.array, 0);
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

        public int Less(int valueToCompare)
        {
            int res = 0;
            foreach (int i in array)
            {
                if (i < valueToCompare)
                    res++;
            }
            return res;
        }
        public int Greater(int valueToCompare)
        {
            int res = 0;
            foreach (int i in array)
            {
                if (i > valueToCompare)
                    res++;
            }
            return res;
        }
    }
}
