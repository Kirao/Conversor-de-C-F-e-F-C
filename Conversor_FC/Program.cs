using System;

namespace Conversor_FC
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Área de declaração das Variaveis
            int escolha;
            double celsim, fairim, convCF, convFC;

            //Area de Escolha de conversão
            Console.WriteLine("\nEscolha oque deseja tranformar? ");
            Console.WriteLine("[1] °C para °F");
            Console.WriteLine("[2] °F para °C");

            escolha = int.Parse(Console.ReadLine());
            
             //Se a escolha for 1, executa essa area de comando
            if (escolha == 1)
            {
                Console.Write("Insira o valor de °C para tranformar em °F: ");       // Msg para inserir qual Valor de Graus Celsius que deseja tranformar em Grau Fahrenheit
                celsim = double.Parse(Console.ReadLine());                           // Vinculando o valor escolhido á variavel

                convCF = (celsim * 9/5) + 32;                                        //Formula de conversao de  °C  para  °F 

                Console.WriteLine($"{celsim}°C é = {convCF.ToString("F2")}°F ");     //Motra o valor escolhido em  °C e o resultado da conversao em  °F

            }
            // Se o resultado for 2, executa essa area de comando
            else if (escolha == 2)
            {
                Console.Write("Insira o valor de °F para tranformar em °C: ");       // Msg para inserir qual Valor de Graus Fahrenheint que deseja tranformar em Grau Celsius
                fairim = double.Parse(Console.ReadLine());                           // Vinculando o valor escolhido á variavel

                convFC = (fairim -32 ) * 5/9;                                        //Formula de conversao de  °F  para  °C

                Console.WriteLine($"{fairim}°F é = {convFC.ToString("F2")}°C ");   //Motra o valor escolhido em  °F e o resultado da conversao em  °C
            }
             
            //Se a escolha nao for 1 ou 2 ele executa essa area de comando
            else
            {
                Console.WriteLine("Nenhum dos modos escolhido!");       //msg que indica que nao foi escolhido umas das opçoes disponiveis
            }

            
        }

    }
}-
