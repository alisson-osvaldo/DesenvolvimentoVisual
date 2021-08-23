using System;

namespace ListaExercicio.Views
{
    public class Exe03 
    {
        public static void Renderizar( )
        {
           int numero1, numero2;
           Console.WriteLine("Informe o número 1: ");
           numero1 = Convert.ToInt32(Console.ReadLine( ));
           Console.WriteLine("Informe o número 2: ");
           numero2 = Convert.ToInt32(Console.ReadLine( ));

           if(numero1 >  numero2 ){
               Console.WriteLine("O primeiro numero lido é maio!");
           } else {
               Console.WriteLine("O segundo número lido é maior!");
           }
        }
    }
}