int Somar(int num1, int num2)
{
    return num1 + num2;
}

int Subtrair(int num1, int num2)
{
    return num1 - num2;
}

int Multiplicar(int num1, int num2)
{
    return num1 * num2;
}

int Dividir(int num1, int num2)
{
    if (num1 == 0 || num2 == 0)
    {
        Console.WriteLine("Erro: divisão por zero não é permitida.");
        return 0;
    }

    return num1 / num2;
}

Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");

int escolha = 0;

while (escolha != 5)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("Escolha as opções: 1- Somar, 2- Subtrair, 3- Multiplicar, 4- Dividir, 5- Sair");

    escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        Console.WriteLine("Escolha o numero 1 da soma:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o numero 2 da soma:");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Somar(num1, num2);

        Console.WriteLine($"O resultado da soma é {resultado}");
    }

    if (escolha == 2)
    {
        Console.WriteLine("Escolha o numero 1 da subtração:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o numero 2 da subtração:");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Subtrair(num1, num2);

        Console.WriteLine($"O resultado da subtração é {resultado}");
    }

    if (escolha == 3)
    {
        Console.WriteLine("Escolha o numero 1 da multiplicação:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o numero 2 da multiplicação:");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Multiplicar(num1, num2);

        Console.WriteLine($"O resultado da multiplicação é {resultado}");
    }

    if (escolha == 4)
    {
        Console.WriteLine("Escolha o numero 1 da divisão:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o numero 2 da divisão:");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = Dividir(num1, num2);

        Console.WriteLine($"O resultado da divisão é {resultado}");
    }
}

Console.WriteLine("Programa encerrado.");