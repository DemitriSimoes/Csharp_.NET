// See https://aka.ms/new-console-template for more information
using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]; // tem que definir a cuantidade de elementos
            int[] meuArray2 = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine(meuArray[0]);
            meuArray[0] = 12;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray2[0]);

            for (var item = 0; item < meuArray2.Length; item++)
            {
                Console.WriteLine(meuArray2[item]);
            }

            foreach (var item in meuArray2)
            {
                Console.WriteLine(item);
            }

            // Exception

            var arr = new int[3];

            try
            {
                Cadastrar("");
                Salvar("");
                for (var index = 0; index < 5; index++)
                {
                    // System.IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("El texto es nulo");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("No encontrado el indice del listado");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Alguna cosa va mal");
                Console.WriteLine("******");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);

            }
            finally
            {
                Console.WriteLine("El bloque finally se ejecuta siempre");
            }
        }

        private static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new Exception("El texto no puede ser nulo o vacio");
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new ArgumentNullException("El texto nulo");
        }

    }
}