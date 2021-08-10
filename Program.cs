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
        public static void Tabuada(int num)
        {
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num*i));
            }
            Console.WriteLine("===================================");
        }

        static private void LerArquivo(int numeroArquivo)
        {
            string caminhoDoArquivo = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("============ Arquivo Lido ==================\n" + caminhoDoArquivo + "\n==================");
            if (File.Exists(caminhoDoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDoArquivo))
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

        private static void Menu()
        {
            while (true)
            {
                string message = "Olá, Bem-Vindo!" +
                    "\n\n  Digite uma das opções abaixo:" +
                    "\n    0 - Sair do programa" +
                    "\n    1 - Para Ler arquivos txt" +
                    "\n    2 - Mostra tabuada de um número";
                Console.WriteLine(message);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIR_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    LerArquivo(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("===================================\n");
                    Console.WriteLine("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());
                    Tabuada(num);
                    Console.WriteLine("===================================\n");
                }
            }
        }

        public const int SAIR_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
