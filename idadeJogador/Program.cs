using System;

namespace idadeJogador
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;

            Console.WriteLine("Digite a idade do jogador:");
            idade = Convert.ToByte(Console.ReadLine());

            if (idade >= 12)
            {
                Console.WriteLine("Você pode jogar!");
            } else
            {
                Console.WriteLine("Você não possui a idade mínima!");
            }
        }
    }
}
