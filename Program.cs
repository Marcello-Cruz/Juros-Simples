using System;

namespace jurossimples
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorCapital,tempoMeses,totalJuros,valorMontante;
            double valorJuros = 0.02;
            Console.Write("Capital [c] (R$)...: ");
            valorCapital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tempo [t] (meses)..: ");
            tempoMeses = Convert.ToDouble(Console.ReadLine());

            totalJuros = valorCapital*valorJuros*tempoMeses;

            valorMontante = valorCapital+totalJuros;

            Console.WriteLine($"Juros (R$)......:  {totalJuros:N}");
            Console.WriteLine($"Montante (R$)....: {valorMontante:N}");
        }
    }
}
