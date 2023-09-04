using System; 

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Calcular Costo de Llamada");
            Console.WriteLine("2. Salir");
            Console.Write("Elija una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularCostoLlamada();
                    break;
                case 2:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        } while (opcion != 2);
    }

    static void CalcularCostoLlamada()
    {
        Console.WriteLine("Ingrese la clave de la zona geográfica:");
        int claveZona = Convert.ToInt32(Console.ReadLine());

        double precioPorMinuto = 0;
        string nombreZona = "";

        switch (claveZona)
        {
            case 12:
                precioPorMinuto = 2;
                nombreZona = "América del norte";
                break;
            case 15:
                precioPorMinuto = 2.2;
                nombreZona = "América central";
                break;
            case 18:
                precioPorMinuto = 4.5;
                nombreZona = "América del sur";
                break;
            case 19:
                precioPorMinuto = 3.5;
                nombreZona = "Europa";
                break;
            case 23:
                precioPorMinuto = 6;
                nombreZona = "Asia";
                break;
            default:
                Console.WriteLine("Clave de zona no válida.");
                return;
        }

        Console.WriteLine($"Ingrese el número de minutos hablados en {nombreZona}:");
        double minutos = Convert.ToDouble(Console.ReadLine());

        double costoLlamada = precioPorMinuto * minutos;
        Console.WriteLine($"El costo de la llamada en {nombreZona} por {minutos} minutos es de ${costoLlamada:N2}");
    }
}
