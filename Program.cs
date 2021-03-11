using System;

namespace M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mode:");
            string M = Console.ReadLine();
            if(M == "time")
            {
                Console.Write("input A :");
                double T = double.Parse(Console.ReadLine());
                Console.Write("input B :");
                double P = double.Parse(Console.ReadLine());
                if (T < 0)
                {
                    Console.Write("Invalida mouse position");
                }
                else
                {
                    P = Math.Pow((T - 1), 2);
                    Console.Write("Output TT:" + T);
                    Console.Write("Output TP:" + P);
                }
            }
            else if(M == "price")
            {
                Console.Write("input A :");
                double T = double.Parse(Console.ReadLine());
                Console.Write("input B :");
                double P = double.Parse(Console.ReadLine());
                T = Math.Sqrt(P) + 1;
                Console.Write("Output TT:" + T);
                Console.Write("Output TP:" + P);
            }
            else
            {
                Console.WriteLine("Invalida mouse mode");
            }
            Console.ReadLine();
           
        }
    }
}
