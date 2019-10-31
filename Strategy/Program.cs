using System;

namespace GoF.Stratefy
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Estratégias
            var icms = new ICMS();
            var iss = new ISS();

            var orcamento = new Orcamento(500);

            /// Orquestrador das Estratégias
            var calculadora = new CalculadorImposto();
            var valorICMS = calculadora.RealizarCalculo(orcamento, icms);
            var valorISS = calculadora.RealizarCalculo(orcamento, iss);

            Console.WriteLine("**** Strategy *****");
            Console.WriteLine($"Valor do Orçamento: {orcamento.Valor}");
            Console.WriteLine($"Valor do ICMS: {valorICMS}");
            Console.WriteLine($"Valor do ISS: {valorISS}");

        }
    }
}
