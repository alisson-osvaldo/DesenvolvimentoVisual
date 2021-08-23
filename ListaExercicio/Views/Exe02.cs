using System;

namespace ListaExercicio.Views
{
    public class Exe02 
    {
        public static void Renderizar( )
        {
            double real, dolar, euro, pesoArgentino;
            Console.WriteLine("Informe o valor em R$: ");
            real = Convert.ToDouble(Console.ReadLine( ));
            dolar = real / 5.17;
            euro = real / 6.14;
            pesoArgentino = real / 0.04;

            Console.WriteLine($"Dolar: { dolar.ToString("F2") } "); //(C2") formata para Real 
            Console.WriteLine($"Euro: { euro.ToString("F2") } ");
            Console.WriteLine($"Peso Argentino: { pesoArgentino.ToString("F2") } ");
        }
    }
}