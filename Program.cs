using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float angka1, angka2;
            string strangka1, strangka2;
            string oper;

            Console.WriteLine("Calculator");

            Console.WriteLine("masukan angka pertama: ");
            strangka1 = Console.ReadLine();

            while(!float.TryParse(strangka1, out angka1))
            {
                Console.WriteLine("masukan hanya angka!");
                Console.WriteLine("masukan angka pertama: ");
                strangka1 = Console.ReadLine();
            }

            Console.WriteLine("masukan angka kedua: ");
            strangka2 = Console.ReadLine();

            while(!float.TryParse(strangka2, out angka2))
            {
                Console.WriteLine("Masukan hanya angka!");
                Console.WriteLine("masukan angka kedua: ");
                strangka2 = Console.ReadLine();
            }

            string[] array = { "+", "-", "*", "/" };
            Console.WriteLine("masukan operator: [+, -, *, /]");
            oper = Console.ReadLine();

            while(Array.IndexOf(array, oper) < 0)
            {
                Console.WriteLine("operator salah!");
                Console.WriteLine("masukan operator: [+, -, *, /]");
                oper = Console.ReadLine();
            }

            switch (oper)
            {
                case "+":
                    Console.WriteLine("hasilnya = " + (angka1 + angka2));
                    Console.WriteLine();
                    break;
                case "-":
                    Console.WriteLine("hasilnya = " + (angka1 - angka2));
                    Console.WriteLine();
                    break;
                case "*":
                    Console.WriteLine("hasilnya = " + (angka1 * angka2));
                    Console.WriteLine();
                    break;
                case "/":
                    Console.WriteLine("hasilnya = " + (angka1 / angka2));
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("operator salah");
                    Console.WriteLine();
                    break;
            }
        }
    }
}