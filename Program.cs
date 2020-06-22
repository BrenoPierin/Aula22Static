using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor.CotacaoDolar = 5.29f;
            Conversor.CotacaoEuro = 5.88f;
            Console.WriteLine($"O valor em real é de $ {Conversor.ConverterRealParaDolar(30f)}");
            Console.WriteLine($"O valor em dolar é de R$ {Conversor.ConverterRealParaDolar(499.99f)}");
            Console.WriteLine($"O valor em real é de € {Conversor.ConverterRealParaEuro(58f)}");
            //O operador de euro não é aceito no terminal, então fica "?"
            Console.WriteLine($"O valor em euro é de $ {Conversor.ConverterEuroParaReal(55.50f)}");
            Console.WriteLine($"O valor em euro é de $ {Conversor.ConverterDolarParaEuro(28f)}");
        }
    }
}
