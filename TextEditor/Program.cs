// See https://aka.ms/new-console-template for more information
using System;

namespace TextEditor {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que desja hacer?");
            Console.WriteLine("1 - Abrir archivo");
            Console.WriteLine("2 - Crear archivo");
            Console.WriteLine("0 - Salir");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Cual es el camino del archivo que desja abrir");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite su texto abajo (ESC para salir)");
            Console.WriteLine("=============================");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Cual es el camino para salvar el archivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Archivo {path} salvo con éxito!, \n presione ENTER para volver el menú.");
            Console.ReadLine();
            Menu();
        }
    }
}

