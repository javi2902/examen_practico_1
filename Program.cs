using System;

class Program
{
    struct Libro
    {
        public string Codigo;
        public string Titulo;
        public string ISBN;
        public string Edicion;
        public string Autor;
    }

    static Libro[] biblioteca = new Libro[100]; // Arreglo para almacenar libros
    static int cantidadLibros = 0; // Contador de libros

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Mostrar Listado de Libros");
            Console.WriteLine("3. Buscar Libro por Código");
            Console.WriteLine("4. Editar Información de un Libro por Código");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarLibro();
                    break;
                case 2:
                    MostrarListadoLibros();
                    break;
                case 3:
                    BuscarLibroPorCodigo();
                    break;
                case 4:
                    EditarLibroPorCodigo();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        } while (opcion != 5);
    }

    static void AgregarLibro()
    {
        Console.WriteLine("Ingrese los datos del libro:");
        Console.Write("Código: ");
        string codigo = Console.ReadLine();
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Edición: ");
        string edicion = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        if (cantidadLibros < biblioteca.Length)
        {
            biblioteca[cantidadLibros].Codigo = codigo;
            biblioteca[cantidadLibros].Titulo = titulo;
            biblioteca[cantidadLibros].ISBN = isbn;
            biblioteca[cantidadLibros].Edicion = edicion;
            biblioteca[cantidadLibros].Autor = autor;
            cantidadLibros++;
            Console.WriteLine("Libro agregado con éxito.");
        }
        else
        {
            Console.WriteLine("La biblioteca está llena. No se pueden agregar más libros.");
        }
    }

    static void MostrarListadoLibros()
    {
        if (cantidadLibros == 0)
        {
            Console.WriteLine("No hay libros en la biblioteca.");
        }
        else
        {
            Console.WriteLine("Listado de Libros:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| Código |    Título    |     ISBN     |  Edición  |   Autor   |");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine($"| {biblioteca[i].Codigo,-7} | {biblioteca[i].Titulo,-12} | {biblioteca[i].ISBN,-13} | {biblioteca[i].Edicion,-10} | {biblioteca[i].Autor,-10} |");
            }
            Console.WriteLine("--------------------------------------------------------------");
        }
    }

    static void BuscarLibroPorCodigo()
    {
        Console.Write("Ingrese el código del libro a buscar: ");
        string codigoBuscado = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < cantidadLibros; i++)
        {
            if (biblioteca[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Libro encontrado:");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("| Código |    Título    |     ISBN     |  Edición  |   Autor   |");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"| {biblioteca[i].Codigo,-7} | {biblioteca[i].Titulo,-12} | {biblioteca[i].ISBN,-13} | {biblioteca[i].Edicion,-10} | {biblioteca[i].Autor,-10} |");
                Console.WriteLine("--------------------------------------------------------------");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void EditarLibroPorCodigo()
    {
        Console.Write("Ingrese el código del libro a editar: ");
        string codigoEditar = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < cantidadLibros; i++)
        {
            if (biblioteca[i].Codigo == codigoEditar)
            {
                Console.WriteLine("Libro encontrado. Ingrese los nuevos datos:");
                Console.Write("Título: ");
                string nuevoTitulo = Console.ReadLine();
                Console.Write("ISBN: ");
                string nuevoISBN = Console.ReadLine();
                Console.Write("Edición: ");
                string nuevaEdicion = Console.ReadLine();
                Console.Write("Autor: ");
                string nuevoAutor = Console.ReadLine();

                biblioteca[i].Titulo = nuevoTitulo;
                biblioteca[i].ISBN = nuevoISBN;
                biblioteca[i].Edicion = nuevaEdicion;
                biblioteca[i].Autor = nuevoAutor;
                Console.WriteLine("Libro editado con éxito.");
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }
}

