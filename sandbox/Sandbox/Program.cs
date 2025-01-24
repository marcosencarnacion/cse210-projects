// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference for the scripture
        var referencia = new Referencia("Juan 3:16");

        // Create a scripture with the reference and a sample text
        var escritura = new Escritura(referencia, "Porque de tal manera amó Dios al mundo que ha dado a su Hijo unigénito");

        // Display the full scripture initially
        escritura.Mostrar();

        // Keep prompting the user to press Enter or quit
        while (true)
        {
            Console.WriteLine("Presiona Enter para ocultar una palabra, o escribe 'quit' para salir.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                // Hide a word and show the updated scripture
                escritura.OcultarPalabra();
                escritura.Mostrar();

                // Check if all words are hidden
                if (escritura.TodasOcultas())
                {
                    Console.WriteLine("¡Felicidades! Has ocultado todas las palabras.");
                    break;
                }
            }
        }

        Console.WriteLine("Programa terminado.");
    }
}