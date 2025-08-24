// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guid
            var id = Guid.NewGuid();
            //Console.WriteLine(id);
            id.ToString();

            id = new Guid("d365d83c-7809-488f-8c2e-6de2d726af7e");
            Console.WriteLine(id.ToString().Substring(0, 8));

            // Interpolated String
            var price = 19.80;
            //var texto = "O precio de el producto es " + price;
            //var texto = string.Format("O precio de el producto es {0}", price);
            var texto = $"O precio de el producto es {price}";

            Console.WriteLine(texto);

            // Compare
            var texto2 = "Testando";
            Console.WriteLine(texto2.CompareTo("Testando"));
            Console.WriteLine(texto2.Contains("testando"));
            Console.WriteLine(texto2.Contains("testando", StringComparison.OrdinalIgnoreCase));

            // StartsWith and EndsWith
            Console.WriteLine(texto2.StartsWith("Test"));
            Console.WriteLine(texto2.StartsWith("test"));
            Console.WriteLine(texto2.EndsWith("ando"));

            // Equals
            Console.WriteLine(texto2.Equals("Testando"));
            Console.WriteLine(texto2.Equals("testando"));

            // IndexOf and LastIndexOf
            Console.WriteLine(texto2.IndexOf("s"));
            Console.WriteLine(texto2.LastIndexOf("t"));

            // ToLower, ToUpper, Insert, Remove e Length
            Console.WriteLine(texto2.ToLower());
            Console.WriteLine(texto2.ToUpper());
            Console.WriteLine(texto2.Insert(4, "zzzz"));
            Console.WriteLine(texto2.Remove(4, 3));
            Console.WriteLine(texto2.Length);

            var texto3 = "Este texto é um teste";
            Console.WriteLine(texto3.Replace("e", "x"));

            var divisao = texto3.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            var resultado = texto3.Substring(5, 5);
            Console.WriteLine(resultado);
            var resultado2 = texto3.Substring(5, texto3.LastIndexOf("o"));
            Console.WriteLine(resultado2);

            var texto4 = "   Testando     ";
            Console.WriteLine(texto4.Trim());

            // StringBuilder

            var texto5 = new StringBuilder();
            texto5.Append("Testando");
            texto5.Append(" StringBuilder");
            texto5.AppendLine(" com várias linhas");
            texto5.AppendLine("Linha 1");

            Console.WriteLine(texto5.ToString());
            
        }
    }
}