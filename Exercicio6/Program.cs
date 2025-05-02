using System;

List<Produto> produtos = new List<Produto>();

for (int i = 1; i <= 3; i++) {
    Console.WriteLine($"Cadastro do Produto {i}:");

    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o preço do produto: ");
    decimal preco = decimal.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade do produto: ");
    int quantidade = int.Parse(Console.ReadLine());

    Produto produto = new Produto(nome, preco, quantidade);
    produtos.Add(produto);
    Console.WriteLine();
}

Console.WriteLine("Lista de Produtos Cadastrados:");
Console.WriteLine();

foreach (var produto in produtos) {
    Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}, Valor Total: {produto.ValorTotalEmEstoque()}");
}
