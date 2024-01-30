using System;

namespace tarefacsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numrandom = random.Next(1, 101);
            int numresposta;

            Console.WriteLine("Bem-vindo ao jogo de advinhação, indique um número entre 1-100");
            Console.WriteLine("Prime 0 para sair a qualquer altura do jogo");

            do
            {
                string respostaStr = Console.ReadLine();

                if (!int.TryParse(respostaStr, out numresposta))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    continue;
                }

                if (numresposta == 0)
                {
                    break;
                }

                if (numrandom < numresposta)
                {
                    Console.WriteLine("Muito Alto, tenta denovo");
                }
                else if (numrandom > numresposta)
                {
                    Console.WriteLine("Muito Baixo, tenta denovo");
                }
                else
                {
                    Console.WriteLine("Parabéns, Acertaste!");
                    break;
                }

            } while (true);
        }
    }
}