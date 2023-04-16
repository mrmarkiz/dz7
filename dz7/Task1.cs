using lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    internal class Task1
    {
        public static void Run()
        {
            MyArray array = new MyArray(10);
            int choice;
            do
            {
                Console.Write("Enter what to do(1 - show, 2 - less, 3 - greater): ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        array.Show();
                        break;
                    case 2:
                        int less;
                        Console.Write("Enter number to be less than: ");
                        if (int.TryParse(Console.ReadLine(), out less))
                        {
                            Console.WriteLine($"Result: {array.Less(less)}");
                        }
                        break;
                    case 3:
                        int greater;
                        Console.Write("Enter number to be greater than: ");
                        if (int.TryParse(Console.ReadLine(), out greater))
                        {
                            Console.WriteLine($"Result: {array.Greater(greater)}");
                        }
                        break;
                }
            } while (choice != 0);
        }
    }
}
