namespace ControleVendas.model;
public class Cliente
{
    private Cliente() { }
    public Cliente(
        int id,
        string? cpf,
        string? nome,
        string? endereco,
        string? telefone,
        string? email)
    {
        Id = id;
        CPF = cpf;
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
    }

    public int Id { get; set; }
    public string CPF { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}
