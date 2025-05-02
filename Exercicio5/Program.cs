using System.Globalization;
using System.Text;
using System.Linq;

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();

frase = FormatarFrase(frase);
frase = RemoverAcentos(frase);

string fraseInvertida = new string(frase.Reverse().ToArray());


if (frase == fraseInvertida) {
    Console.WriteLine("A frase é um palíndromo.");
} else {
    Console.WriteLine("A frase não é um palíndromo.");
}


static string RemoverAcentos(string texto) {
    string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
    string resultado = "";

    foreach (char caractere in textoNormalizado) {
        string categoria = CharUnicodeInfo.GetUnicodeCategory(caractere).ToString();

        if (categoria != "NonSpacingMark") {
            resultado += caractere;
        }
    }

    return resultado.Normalize(NormalizationForm.FormC);
}


static string FormatarFrase(string frase) {
    frase = frase.Trim();

    string[] pontuacao = { ".", ",", "!", "?", "-", " " };
    foreach (string p in pontuacao) {
        frase = frase.Replace(p, "");
    }

    frase = frase.ToLower();

    return frase;
}