using System;

namespace ListaExercicio.Views
{
    public class Exe01
    {
        public static void Renderizar( )
        {
            int largura, altura, area;
            Console.WriteLine("Informe a largura: ");
            largura = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine("Informe a altura: ");
             altura = Convert.ToInt32(Console.ReadLine( ));
             area = altura * largura;
             Console.WriteLine($"Área: { area }");

        }
    }
}