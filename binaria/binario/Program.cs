using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numerosOrdenados = { 2, 4, 6, 8, 10, 14, 24, 30, 43, 56, 67, 78};
            int numeroABuscar = 43;

            int indice = BuscarBinario(numerosOrdenados, numeroABuscar);

            if (indice != -1)
            {
                Console.WriteLine("El número {0} se encuentra en el índice {1}", numeroABuscar, indice);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El número {0} no se encontró en el arreglo", numeroABuscar);
                Console.ReadKey();
            }
        }

        static int BuscarBinario(int[] arreglo, int numero)
        {
            int inicio = 0;
            int fin = arreglo.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (arreglo[medio] == numero)
                {
                    return medio;
                    // Número encontrado
                }
                else if (arreglo[medio] < numero)
                {
                    inicio = medio + 1; // Buscar en la mitad derecha
                }
                else
                {
                    fin = medio - 1; // Buscar en la mitad izquierda
                }
            }

            return -1; // Número no encontrado
        }
    }





}
    
