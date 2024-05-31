using ControleVendas.model;
using Dapper;
using Npgsql;

namespace ControleVendas.repositorio;
public class ProdutoRepositorio
{
    public void Cadastrar(Produto produto)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"INSERT INTO PRODUTOS (NOME,  DESCRICAO,  PRECO,  CODIGODEBARRAS)
                                        VALUES (@nome, @descricao, @preco, @codigoDeBarras);",
                new
                {
                    nome = produto.Nome,
                    descricao = produto.Descricao,
                    preco = produto.Preco,
                    codigoDeBarras = produto.CodigoDeBarras,
                }
        );
    }

    public void Atualizar(Produto produto)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"UPDATE PRODUTOS SET NOME      = @nome,  
                                              DESCRICAO = @descricao,  
                                              PRECO     = @preco
                          WHERE ID = @id;",
                new
                {
                    id = produto.Id,
                    nome = produto.Nome,
                    descricao = produto.Descricao,
                    preco = produto.Preco,
                }
        );
    }
    
    public void DeduzirEstoque(int id, decimal quantidade)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"UPDATE PRODUTOS SET ESTOQUEATUAL = (SELECT ESTOQUEATUAL FROM PRODUTOS WHERE ID = @id) - @quantidade
                          WHERE ID = @id;",
                new
                {
                    id = id,
                    quantidade = quantidade,
                }
        );
    }

    public void Apagar(int id)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"DELETE FROM PRODUTOS WHERE ID = @id;",
                new
                {
                    id,
                }
        );
    }

    public Produto BuscarProdutoPorId(int id)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.QueryFirstOrDefault<Produto>
            (@"SELECT 
                      ID, 
                      NOME,  
                      DESCRICAO, 
                      CODIGODEBARRAS, 
                      PRECO, 
                      ESTOQUEATUAL 
                      FROM PRODUTOS 
               WHERE ID = @id;", new { id });
    }

    public Produto BuscarProdutoPorCodigoDeBarras(string codigoDeBarras)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.QueryFirstOrDefault<Produto>
            (@"SELECT 
                      ID, 
                      NOME,  
                      DESCRICAO, 
                      CODIGODEBARRAS, 
                      PRECO, 
                      ESTOQUEATUAL 
                      FROM PRODUTOS 
                WHERE CODIGODEBARRAS = @codigoDeBarras;", new { codigoDeBarras });
    }

    public IEnumerable<Produto> BuscarTodosProdutos()
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.Query<Produto>
            (@"SELECT 
                      ID, 
                      NOME,  
                      DESCRICAO, 
                      CODIGODEBARRAS, 
                      PRECO, 
                      ESTOQUEATUAL 
                      FROM PRODUTOS 
               ORDER BY NOME ASC");
    }
}
