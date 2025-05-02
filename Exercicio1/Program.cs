using System;

Console.Write("Digite uma senha: ");
string senha = Console.ReadLine();

if (senha.Length < 8) {
    Console.WriteLine("A senha deve ter pelo menos 8 caracteres.");
    return;
}

bool letraMaiuscula = false;
bool numero = false;
string especiais = "!@#$%&*()-_=+[]{}|;:',.<>/?`~^";
bool caracterEspecial = false;

foreach (char c in senha) {
    if (char.IsUpper(c) && !letraMaiuscula) {
        letraMaiuscula = true;
    }
    if (char.IsDigit(c) && !numero) {
        numero = true;
    }
    if (especiais.Contains(c) && !caracterEspecial) {
        caracterEspecial = true;
    }
}

if (!letraMaiuscula) {
    Console.WriteLine("A senha deve conter pelo menos uma letra maiúscula.");
    return;
}

if (!numero) {
    Console.WriteLine("A senha deve conter pelo menos um número.");
    return;
}

if (!caracterEspecial) {
    Console.WriteLine("A senha deve conter pelo menos um caractere especial. Exemplos: @, #, $, %, &, *");
    return;
}

Console.WriteLine("Senha válida!");



