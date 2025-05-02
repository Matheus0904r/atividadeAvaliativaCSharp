using System;

Console.WriteLine("Seja bem vindo :)");

while(true) {
    Console.WriteLine("[1] - Celsius para Fahrenheit");
    Console.WriteLine("[2] - Fahrenheit para Celsius");
    Console.WriteLine("[0] - Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch(opcao) {
        case 1:
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
            break;
        case 2:
            Console.Write("Digite a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5/9;
            Console.WriteLine($"A temperatura em Celsius é: {celsius}");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

}