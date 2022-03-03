using System;

namespace Exercicio.dois
{
    class Program
    {
        private static readonly decimal valorCambioStatic = 5.22m;

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em $: ");
            string valorDigitado = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 5.22m;

            decimal.TryParse(valorDigitado, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido = valorCambio;

            Console.WriteLine("$*valor em R$:  (valorConvertido)");
            Console.ReadLine();
        }
    }
}
