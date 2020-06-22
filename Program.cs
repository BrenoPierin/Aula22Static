using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor.CotacaoDolar = 5.29f;
            Conversor.CotacaoEuro = 5.88f;
            Console.WriteLine(Conversor.ConverterRealParaDolar(30f));
            Console.WriteLine(Conversor.ConverterRealParaDolar(499.99f));
            Console.WriteLine(Conversor.ConverterRealParaEuro(58f));
            Console.WriteLine(Conversor.ConverterEuroParaReal(55.50f));
            Console.WriteLine(Conversor.ConverterDolarParaEuro(28f));
        }
    }
}
