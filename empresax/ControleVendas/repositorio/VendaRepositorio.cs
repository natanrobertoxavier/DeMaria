using ControleVendas.model;
using Dapper;
using Npgsql;

namespace ControleVendas.repositorio;
public class VendaRepositorio
{
    public void Cadastrar(Venda venda)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"INSERT INTO VENDAS (CLIENTEID, 
                                              CODIGODEBARRAS, 
                                              QUANTIDADE, 
                                              VALORUNITARIO, 
                                              VALORTOTAL, 
                                              DATAVENDA)
                                 VALUES (@clienteId, 
                                         @codigoDeBarras, 
                                         @quantidade, 
                                         @valorUnitario, 
                                         @valorTotal, 
                                         @dataVenda);",
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
