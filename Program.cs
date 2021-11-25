using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat = 1;

            Console.WriteLine("Cálculo de Fatorial");
            Console.Write("Informe um valor inteiro:");
            int entrada = Convert.ToInt32(Console.ReadLine());

            if(entrada == 0)
            {
                Console.WriteLine($"\n{entrada}! = {fat+1}");
                return;
            }

            for (int i = 2; i <= entrada; i++)
            {
                fat *= i;
            }

            Console.WriteLine($"\n{entrada}! = {fat}");
        }
    }
}
