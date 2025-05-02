public class Produto {
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, decimal preco, int quantidade) {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
    }

    public decimal ValorTotalEmEstoque() {
        return this.Preco * this.Quantidade;
    }
}