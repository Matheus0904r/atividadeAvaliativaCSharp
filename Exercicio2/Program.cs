using System;

Console.Write("Digite um número inteiro: ");
int numeroInt = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"{numeroInt} x {i} = {numeroInt * i}");
}


