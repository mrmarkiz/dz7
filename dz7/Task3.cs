using lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    internal class Task3
    {
        public static void Run()
        {
            MyArray array = new MyArray(10);
            int choice;
            do
            {
                Console.Write("Enter what to do(1 - show, 2 - count distinct, 3 - count equal): ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        array.Show();
                        break;
                    case 2:
                        Console.WriteLine($"Result: {array.CountDistinct()}");
                        break;
                    case 3:
                        int num;
                        Console.Write("Enter number ot campare to: ");
                        if (int.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"Result: {array.EqualToValue(num)}");
                        }
                        break;
                }
            } while (choice != 0);
        }
    }
}
