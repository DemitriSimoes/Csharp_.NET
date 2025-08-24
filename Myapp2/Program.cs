// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

namespace Myapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data1 = new DateTime(2025, 8, 15, 10, 12, 30);
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data1);

            // Y, M, d, H, m, s
            var formato = String.Format("{0:dd/MM/yyyy z}", data);

            Console.WriteLine(formato);

            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var es = new CultureInfo("es-ES");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(atual);
            Console.WriteLine(data.ToString("D", pt));
            Console.WriteLine(data.ToString("D", en));
            Console.WriteLine(data.ToString("D", es));

            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(2);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            Console.WriteLine("***************");

            // precisão para moeda
            decimal valor = 10.25m;
            Console.WriteLine(valor);
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));


        }
    }
}