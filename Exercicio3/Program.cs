using System;
using System.Numerics;

Console.Write("Digite um número inteiro: ");
int numeroInt = int.Parse(Console.ReadLine());

if (numeroInt < 0) {
    Console.WriteLine("Número inválido. O número deve ser maior ou igual a zero.");
    return;
}

BigInteger fatorial = 1;
int i = 1;

while (i <= numeroInt) {
    fatorial *= i;
    Console.WriteLine($"!{i} = {fatorial}");
    i++;
}

Console.WriteLine($"O fatorial de {numeroInt} é {fatorial}.");
