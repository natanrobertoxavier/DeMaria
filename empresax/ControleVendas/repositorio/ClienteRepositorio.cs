using ControleVendas.model;
using Dapper;
using Npgsql;

namespace ControleVendas.repositorio;
public class ClienteRepositorio
{
    public void Cadastrar(Cliente cliente)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        conexao.Execute(@"INSERT INTO CLIENTES (NOME,  CPF,  ENDERECO,  TELEFONE,  EMAIL)
                                        VALUES (@nome, @cpf, @endereco, @telefone, @email);",
                new
                {
                    nome = cliente.Nome,
                    cpf = cliente.CPF,
                    endereco = cliente.Endereco,
                    telefone = cliente.Telefone,
                    email = cliente.Email,
                }
        );
    }

    public void Atualizar(Cliente cliente)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
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
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
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
            (@"SELECT ID, CPF, NOME, ENDERECO, TELEFONE, EMAIL FROM CLIENTES WHERE ID = @id;", new { id });
    }

    public IEnumerable<Cliente> BuscarTodosClientes()
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.Query<Cliente>
            (@"SELECT ID, CPF, NOME, ENDERECO, TELEFONE, EMAIL FROM CLIENTES ORDER BY ID ASC");
    }

    public Cliente BuscarClientePorCPF(string? cpf)
    {
        using NpgsqlConnection conexao = (NpgsqlConnection)new DbContext().GetConnection();
        return conexao.QueryFirstOrDefault<Cliente>
            (@"SELECT ID, CPF, NOME, ENDERECO, TELEFONE, EMAIL FROM CLIENTES WHERE CPF = @cpf;", new { cpf });
    }
}
