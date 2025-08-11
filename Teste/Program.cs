// See https://aka.ms/new-console-template for more information
using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int inteiro = 100;
            float real = 25.5f;

            //float realInteiro = inteiro;
            //string valorReal = real.ToString();
            // float valorFloat = float.Parse(valorReal);
            // inteiro = (int)valorFloat;
            //inteiro = int.Parse(valorReal);
            //int realInt = Convert.ToInt32(real);
            string relaNovo = Convert.ToString(real);

            //Console.WriteLine(realInteiro);
            Console.WriteLine(relaNovo + 1);
            
        }
    }   
}

//var teste = "Testando";
//Console.WriteLine("Hello, World!", teste);
