using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Capital: ");
            string Capital = Console.ReadLine();

            Console.WriteLine("Digite a Taxa de juros: ");
            string Taxa_Juros = Console.ReadLine();
            double Taxa_juros = Convert.ToDouble(Taxa_Juros) / 100;

            Console.WriteLine("Digite a quantidade de meses");
            string Meses = Console.ReadLine();
            

            double Juros = Convert.ToDouble(Capital) * Taxa_juros * Convert.ToDouble(Meses);
            double Montante = Convert.ToDouble(Capital) + Juros;
            
            Console.WriteLine($"Juros (R$) = {Juros}");
            Console.WriteLine($"Montante (R$)= {Montante}");


        }
    }
}
