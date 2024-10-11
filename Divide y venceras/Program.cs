using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario los dos números
        Console.Write("Ingrese el primer número (minuendo): ");
        int minuendo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número (sustraendo): ");
        int sustraendo = Convert.ToInt32(Console.ReadLine());

        // Realizar la resta utilizando la técnica de divide y vencerás
        int resultado = Resta(minuendo, sustraendo);

        // Mostrar el resultado
        Console.WriteLine("El resultado de la resta es: " + resultado);
    }

    // Función recursiva que implementa divide y vencerás
    static int Resta(int a, int b)
    {
        // Caso base: si el sustraendo es 0, devolver el minuendo
        if (b == 0)
        {
            return a;
        }

        // Dividir el problema: restamos de uno en uno recursivamente
        return Resta(a - 1, b - 1);
    }
}

