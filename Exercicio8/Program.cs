using System;

Console.Write("Digite o seu peso(kg): ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Digite a sua altura(m): ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5) {
    Console.WriteLine("Abaixo do peso");
    return;
}
if (imc > 18.5 && imc <= 24.9) {
    Console.WriteLine("Peso normal");
    return;
}
if (imc > 25 && imc < 29.9) {
    Console.WriteLine("Sobrepeso");
    return;
}
if (imc > 30) {
    Console.WriteLine("Obesidade");
    return;
}
