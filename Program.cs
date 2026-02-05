class Program //Busqué en internet y según entendí, se usa Program por convención colectiva
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Comparador de Tres Números ===\n");

        int primerNumero = LeerNumero("Ingrese el primer número: ");
        int segundoNumero = LeerNumero("Ingrese el segundo número: ");
        int tercerNumero = LeerNumero("Ingrese el tercer número: ");

        int numeroMayor = ObtenerNumeroMayor(primerNumero, segundoNumero, tercerNumero);

        MostrarResultado(primerNumero, segundoNumero, tercerNumero, numeroMayor);

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    // Lee un número entero desde la consola
    static int LeerNumero(string mensaje)
    {
        Console.Write(mensaje);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Determina cuál de los tres números es el mayor
    static int ObtenerNumeroMayor(int numeroA, int numeroB, int numeroC)
    {
        int mayor = numeroA;

        if (numeroB > mayor)
            mayor = numeroB;

        if (numeroC > mayor)
            mayor = numeroC;

        return mayor;
    }

    // Muestra el resultado y considera si hay números iguales
    static void MostrarResultado(int numeroA, int numeroB, int numeroC, int mayor)
    {
        if (numeroA == numeroB && numeroB == numeroC)
        {
            Console.WriteLine("\nLos tres números son iguales: " + numeroA);
        }
        else if (numeroA == numeroB && numeroA == mayor)
        {
            Console.WriteLine($"\nEl número mayor es {mayor} (primer y segundo número son iguales)");
        }
        else if (numeroA == numeroC && numeroA == mayor)
        {
            Console.WriteLine($"\nEl número mayor es {mayor} (primer y tercer número son iguales)");
        }
        else if (numeroB == numeroC && numeroB == mayor)
        {
            Console.WriteLine($"\nEl número mayor es {mayor} (segundo y tercer número son iguales)");
        }
        else
        {
            Console.WriteLine($"\nEl número mayor es: {mayor}");
        }
    }
}
