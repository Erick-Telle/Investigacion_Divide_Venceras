namespace Ordenar_Datos1
{
    internal class Program
    {
        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);  // Ordenar la mitad izquierda
                QuickSort(array, pivotIndex + 1, right); // Ordenar la mitad derecha
            }
        }

        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Main()
        {
            Console.Write("Ingrese el número de elementos del array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Array ordenado: " + string.Join(", ", array));
        }
    }
}

