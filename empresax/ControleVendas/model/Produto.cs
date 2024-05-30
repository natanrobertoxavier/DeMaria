namespace ControleVendas.model;
public class Produto
{
    public Produto() { }

    public Produto(
        int id, 
        string nome, 
        string descricao,
        string codigoDeBarras,
        decimal preco, 
        decimal estoqueAtual)
    {
        Id = id;
        Nome = nome;
        CodigoDeBarras = codigoDeBarras;
        Descricao = descricao;
        Preco = preco;
        EstoqueAtual = estoqueAtual;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string CodigoDeBarras { get; set; }
    public decimal Preco { get; set; }
    public decimal EstoqueAtual { get; set; }
}
