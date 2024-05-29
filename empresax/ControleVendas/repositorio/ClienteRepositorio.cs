using ControleVendas.model;
using Dapper;
using Npgsql;
using System.Globalization;

namespace ControleVendas.repositorio;
public class ClienteRepositorio
{
    public void Cadastrar(Cliente cliente)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection) new DbContext().GetConnection();
        conexao.Execute(@"INSERT INTO CLIENTES (NOME,  ENDERECO,  TELEFONE,  EMAIL)
                                        VALUES (@nome, @endereco, @telefone, @email);",
                new
                {
                    nome = cliente.Nome,
                    endereco = cliente.Endereco,
                    telefone = cliente.Telefone,
                    email = cliente.Email,
                }
        );
    }

    public void Atualizar(Cliente cliente)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection) new DbContext().GetConnection();
        conexao.Execute(@"UPDATE CLIENTES SET NOME     = @nome,  
                                              ENDERECO = @endereco,  
                                              TELEFONE = @telefone,
                                              EMAIL    = @email
                          WHERE ID = @id;",
                new
                {
                    id = cliente.Id,
                    nome = cliente.Nome,
                    endereco = cliente.Endereco,
                    telefone = cliente.Telefone,
                    email = cliente.Email,
                }
        );
    }

    public void Apagar(int id)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection) new DbContext().GetConnection();
        conexao.Execute(@"DELETE FROM CLIENTES WHERE ID = @id;",
                new
                {
                    id,
                }
        );
    }

    public Cliente BuscarClientePorId(int id)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.QueryFirstOrDefault<Cliente>
            (@"SELECT ID, NOME, ENDERECO, TELEFONE, EMAIL FROM CLIENTES WHERE ID = @id;", new { id });
    }

    public IEnumerable<Cliente> BuscarTodosClientes()
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.Query<Cliente>
            (@"SELECT ID, NOME, ENDERECO, TELEFONE, EMAIL FROM CLIENTES ORDER BY ID ASC");
    }
}
