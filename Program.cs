using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        public static void Tabuada()
        {
            Console.WriteLine("===================================\n");
            Console.WriteLine("Digite um número intero: ");

            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num*i));
            }
            Console.WriteLine("===================================");
        }

        static private void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            if(File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    Console.WriteLine("===================================\n");
                    Console.WriteLine("File " + numeroArquivo + "\n");
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }

        }
        static void Main(string[] args)
        {
            Tabuada();
            LerArquivo(1);
            Console.Read();
        }
    }
}
