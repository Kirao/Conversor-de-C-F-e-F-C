using System;

namespace Conversor_FC
{
    class Program
    {
        static void Main(string[] args)
        {   
            int escolha;
            double celsim, fairim, convCF, convFC;

            Console.WriteLine("Oque deseja tranformar? [1] °C para °F ou [2] °F para °C");
            escolha = int.Parse(Console.ReadLine());
            

            if (escolha == 1)
            {
                Console.Write("Insira o valor de °C para tranformar em °F: ");
                celsim = double.Parse(Console.ReadLine());

                convCF = (celsim * 9/5) + 32;

                Console.WriteLine($"{celsim}°C é = {convCF.ToString("F2")}°F ");

            }

            else
            {
                Console.Write("Insira o valor de °F para tranformar em °C: ");
                fairim = double.Parse(Console.ReadLine());

                convFC = (fairim -32 ) * 5/9;

                Console.WriteLine($"{fairim}°F é = {convFC.ToString("F2")}°C a ");
            }

            
        }

    }
}
