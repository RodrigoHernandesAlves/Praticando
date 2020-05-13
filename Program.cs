using System;

namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int horario = 5;

            Console.WriteLine("Qual horario voce acordou:");
            horario = int.Parse(Console.ReadLine());  // pode fazer com o case tambem 
            
            if (horario<5)
            {
              Console.WriteLine("Parabens voce acordou para a aula:");
            }else
            {   
                Console.WriteLine("Perdeu a aula o sono ganhou:");
                
            }

        }
    }
}
