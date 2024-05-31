namespace ControleVendas.model;
public class Venda
{
    public Venda() { }

    public Venda(
        int id,
        int clienteId,
        string codigoDeBarras,
        string nomeProduto,
        decimal quantidade,
        decimal valorUnitario,
        decimal valorTotal,
        DateTime dataVenda,
        string codigoDaVenda,
        int produtoId)
    {
        Id = id;
        ClienteId = clienteId;
        CodigoDeBarras = codigoDeBarras;
        NomeProduto = nomeProduto;
        Quantidade = quantidade;
        ValorUnitario = valorUnitario;
        ValorTotal = valorTotal;
        DataVenda = dataVenda;
        CodigoDaVenda = codigoDaVenda;
        ProdutoId = produtoId;
    }

    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int ProdutoId { get; set; }
    public string CodigoDeBarras { get; set; }
    public string CodigoDaVenda { get; set; }
    public string NomeProduto { get; set; }
    public decimal Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime DataVenda { get; set; }
}
