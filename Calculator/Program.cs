class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------");
        Console.Write("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
        Console.ReadKey();
    }
    static void Soma()
    {
        Console.Clear();
        Console.Write("Primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        double resultado = valor1 + valor2;

        Console.WriteLine("");
        Console.WriteLine($"O resultado é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.Write("Primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        double resultado = valor1 - valor2;
        Console.WriteLine("");
        Console.WriteLine($"O resultado é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.Write("Primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        double resultado = valor1 * valor2;
        Console.WriteLine("");
        Console.WriteLine($"O resultado é: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.Write("Primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());
        double resultado = valor1 / valor2;
        Console.WriteLine("");
        Console.WriteLine($"O resultado é: {resultado}");
        Console.ReadKey();
        Menu();
    }
}


