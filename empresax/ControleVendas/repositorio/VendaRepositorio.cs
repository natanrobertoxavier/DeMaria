using ControleVendas.model;
using Dapper;
using Npgsql;

namespace ControleVendas.repositorio;
public class VendaRepositorio
{
    public void CadastrarVenda(Venda venda)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"INSERT INTO VENDAS (CLIENTEID, 
                                              QUANTIDADE, 
                                              VALORTOTAL, 
                                              DATACADASTRO,
                                              CODIGODAVENDA)
                                 VALUES (@clienteId, 
                                         @quantidade, 
                                         @valorTotal, 
                                         @dataVenda, 
                                         @codigoDaVenda);",
                new
                {
                    clienteId = venda.ClienteId,
                    quantidade = venda.Quantidade,
                    valorTotal = venda.ValorTotal,
                    dataVenda = DateTime.Now,
                    codigoDaVenda = venda.CodigoDaVenda,
                }
        );
    }

    public void CadastrarItensDaVenda(Venda venda)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"INSERT INTO ITENSDAVENDA (CODIGODEBARRAS, 
                                                    QUANTIDADE, 
                                                    VALORUNITARIO, 
                                                    VALORTOTAL,
                                                    CODIGODAVENDA)
                                 VALUES (@codigoDeBarras, 
                                         @quantidade, 
                                         @valorUnitario, 
                                         @valorTotal,
                                         @codigoDaVenda);",
                new
                {
                    codigoDeBarras = venda.CodigoDeBarras,
                    quantidade = venda.Quantidade,
                    valorUnitario = venda.ValorUnitario,
                    valorTotal = venda.ValorTotal,
                    codigoDaVenda = venda.CodigoDaVenda,
                }
        );
    }

    private void Atualizar(Venda venda)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"UPDATE CLIENTES SET CLIENTEID      = @clienteId,  
                                              CODIGODEBARRAS = @codigoDeBarras,  
                                              QUANTIDADE     = @quantidade,
                                              VALORUNITARIO  = @valorUnitario,
                                              VALORTOTAL     = @valorTotal,
                                              DATAVENDA      = @dataVenda

                          WHERE ID = @id;",
                new
                {
                    clienteId = venda.ClienteId,
                    codigoDeBarras = venda.CodigoDeBarras,
                    quantidade = venda.Quantidade,
                    valorUnitario = venda.ValorUnitario,
                    valorTotal = venda.ValorTotal,
                    dataVenda = venda.DataVenda,
                }
        );
    }

    private void Apagar(int id)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"DELETE FROM VENDAS WHERE ID = @id;",
                new
                {
                    id,
                }
        );
    }

    public Venda BuscarClientePorId(int id)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.QueryFirstOrDefault<Venda>
            (@"SELECT ID,
                      CLIENTEID, 
                      CODIGODEBARRAS, 
                      QUANTIDADE, 
                      VALORUNITARIO, 
                      VALORTOTAL, 
                      DATAVENDA 
                FROM VENDAS 
                WHERE ID = @id;", new { id });
    }

    public IEnumerable<Venda> BuscarVendasPorCliente(int clienteId)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.Query<Venda>
            (@"SELECT ID,
                      CLIENTEID, 
                      CODIGODEBARRAS, 
                      QUANTIDADE, 
                      VALORUNITARIO, 
                      VALORTOTAL, 
                      DATAVENDA 
                FROM VENDAS 
                WHERE CLIENTEID = @clienteId;", new { clienteId });
    }

    public IEnumerable<Venda> BuscarVendasPorProduto(string codigoDeBarras)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.Query<Venda>
            (@"SELECT ID,
                      CLIENTEID, 
                      CODIGODEBARRAS, 
                      QUANTIDADE, 
                      VALORUNITARIO, 
                      VALORTOTAL, 
                      DATAVENDA 
                FROM VENDAS 
                WHERE CODIGODEBARRAS = @codigoDeBarras;", new { codigoDeBarras });
    }
}
