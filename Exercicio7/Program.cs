using System;
int[] numeros = new int[10];

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

int total = 0;
foreach (int numero in numeros) {
    if (numero % 2 == 0) {
        total += numero;
    }
}

Console.WriteLine($"A soma dos números pares é: {total}");