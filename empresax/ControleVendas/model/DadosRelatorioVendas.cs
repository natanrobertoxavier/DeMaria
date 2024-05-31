namespace ControleVendas.model;
public class DadosRelatorioVendas
{
    public DadosRelatorioVendas() { }

    public DadosRelatorioVendas(
        string codigoDaVenda, 
        string clienteCPF, 
        string nomeCliente, 
        decimal quantidadeDeProdutos, 
        decimal valorTotal, 
        DateTime dataDaVenda)
    {
        CodigoDaVenda = codigoDaVenda;
        ClienteCPF = clienteCPF;
        NomeCliente = nomeCliente;
        QuantidadeDeProdutos = quantidadeDeProdutos;
        ValorTotal = valorTotal;
        DataDaVenda = dataDaVenda;
    }

    public string CodigoDaVenda { get; set; }
    public string ClienteCPF { get; set; }
    public string NomeCliente { get; set; }
    public decimal QuantidadeDeProdutos { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime DataDaVenda { get; set; }
}
