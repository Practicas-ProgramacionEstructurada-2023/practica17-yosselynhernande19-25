using System;
using System.IO;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opciones;

            do
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Buscar y Mostrar el contenido de un archivo de un archivo");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción (1-2): ");

                opciones = Convert.ToInt32(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        ShowFileContent();
                        break;

                    case 2:
                        Console.WriteLine("\nSalinedo del Programa.....");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Intente de nyevo");
                        break;
                }

            } while (opciones != 2);
        }

        static void ShowFileContent()
        {
            Console.Write("\nIngrese la ruta del archivo: ");
            string? filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string content = ReadFileContent(filePath);
                Console.WriteLine($"\nContenido del archivo:\n{content}");
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta proporcionada");
            }
        }

        static string ReadFileContent(string filePath)
        {
            try
            {
                //Leer todo el contenido del archivo
                string content = File.ReadAllText(filePath);
                return content;
            }
            catch (Exception ex)
            {
                 return $"Error al leer el archivo: {ex.Message}";
            }
        }
    }
}
