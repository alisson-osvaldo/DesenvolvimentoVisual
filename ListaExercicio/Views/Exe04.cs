using System;

namespace ListaExercicio.Views
{
    public class Exe04
    {
        public static void Renderizar( )
        {
            const int TAMANHO_VETOR = 100;
            const int LIMITE_NUMEROS = 1001;
            Random random = new Random( );
            int[ ] numeros = new int[TAMANHO_VETOR];

            Console.WriteLine("for NORMAL");
            for (int i = 0; i < TAMANHO_VETOR; i++)
            {
                numeros[ i ] = random.Next(LIMITE_NUMEROS);
            }

            //Imprimir os valores do vetor 
            Console.WriteLine("Valores do vetor");
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }
           //Console.WriteLine(random.Next(500, 1001)); 500 até 1000
           Console.WriteLine("\n\n");

            //Ordenar o vetor utilizando o bubble sort
            Console.WriteLine("Ordenado usando bubble sort");
            bool troca = false;
            do
            {
                troca = false;
                for (int i = 0; i < TAMANHO_VETOR - 1 ; i++)
                {
                    if(numeros[ i ] > numeros[ i + 1 ]){
                        int aux = numeros[i];
                        numeros[i] = numeros [i + 1];
                        numeros[i + 1] = aux;
                        troca = true;
                    }
                }
            } while (troca) ;

            
            //Ordenação altomática do C#
           // Array.Sort( numeros ); //para não repetir a mesma ordem
            Console.WriteLine("\n\n");
            Console.WriteLine("mostrar usando foreach");
           //Imprimir os valores do vetor ordenado
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }

        }
    }
}