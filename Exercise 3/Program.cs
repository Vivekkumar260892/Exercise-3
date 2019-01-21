using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A : ");
            
            String Number_1= Console.ReadLine();
            int a = int.Parse(Number_1);
            Console.WriteLine("Enter B : ");
            String Number_2 = Console.ReadLine();
            int b = int.Parse(Number_2);
            Console.WriteLine("Enter C : ");
            String Number_3 = Console.ReadLine();
            int c = int.Parse(Number_3);

            if (a > b && b > c)
            {
                Console.WriteLine("A is the greatest number ");
                if (b > a && b > c)
                {
                    Console.WriteLine("B is the greatest number ");
                }
            }
            else
            {
                Console.WriteLine("C is the greatest number ");
            }

        }
    }
}
