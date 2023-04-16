using lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    internal class Task2
    {
        public static void Run()
        {
            MyArray array = new MyArray(10);
            int choice;
            do
            {
                Console.Write("Enter what to do(1 - show, 2 - show even, 3 - show odd): ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        array.Show();
                        break;
                    case 2:
                        array.ShowEven();
                        break;
                    case 3:
                        array.ShowOdd();
                        break;
                }
            } while (choice != 0);
        }
    }
}
