using System;

Console.WriteLine("Seja bem-vindo ao Jogo de adivinhação!");
Console.WriteLine("Tente adivinhar o número que estou pensando entre 1 e 100.");

Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int tentativas = 0;

while (true) {
    Console.Write("Digite seu palpite: ");
    int entrada = int.Parse(Console.ReadLine());

    tentativas++;

    if (entrada < numeroSecreto) {
        Console.WriteLine("Muito baixo! Tente novamente.");
    } 
    if (entrada > numeroSecreto) {
        Console.WriteLine("Muito alto! Tente novamente.");
    }
    if (entrada == numeroSecreto) {
        Console.WriteLine($"Parabéns! Você adivinhou o número {numeroSecreto} em {tentativas} tentativas.");
        break;
    }
}