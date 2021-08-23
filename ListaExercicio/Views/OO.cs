using System;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class OO{
        public static void Renderizar( )
        {
            produto produto = new produto( ); 
            produto.Nome = "Bolacha";
            Console.WriteLine($"Nome do projeto: { produto.Nome }");
        }
    }
}