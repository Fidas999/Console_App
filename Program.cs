using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        public static void Tabuada()
        {
            Console.WriteLine("===================================\n\n");
            Console.WriteLine("Digite um número intero: ");

            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num*i));
            }
            Console.WriteLine("===================================");
        }
        static void Main(string[] args)
        {
            Tabuada();
            Console.Read();
        }
    }
}
