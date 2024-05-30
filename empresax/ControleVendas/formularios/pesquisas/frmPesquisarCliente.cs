using ControleVendas.model;
using ControleVendas.repositorio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleVendas.formularios.pesquisas;
public partial class frmPesquisarCliente : Form
{
    private string CPF { get; set; }
    public frmPesquisarCliente()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
    }

    private void BuscarTodosClientes(ClienteRepositorio repositorio)
    {
        var clientes = repositorio.BuscarTodosClientes();

        dgClientes.DataSource = clientes.ToList();

        dgClientes.Columns.Clear();

        #region Personalizacao-Celula-ID
        DataGridViewTextBoxColumn cpf = new()
        {
            DataPropertyName = "CPF",
            Name = "CPF",
            HeaderText = "CPF",
            Width = 87,
            ReadOnly = true,
        };

        dgClientes.Columns.Add(cpf);
        #endregion

        #region Personalizacao-Celula-NOME
        DataGridViewTextBoxColumn nome = new()
        {
            DataPropertyName = "NOME",
            Name = "NOME",
            HeaderText = "Nome",
            Width = 230,
            ReadOnly = true,
        };
        dgClientes.Columns.Add(nome);
        #endregion

        #region Personalizacao-Celula-TELEFONE
        DataGridViewTextBoxColumn telefone = new()
        {
            DataPropertyName = "TELEFONE",
            Name = "TELEFONE",
            HeaderText = "Telefone",
            Width = 100,
            ReadOnly = true,
        };
        dgClientes.Columns.Add(telefone);
        #endregion
    }

    private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView gridCliente = sender as DataGridView;

        if (gridCliente is null)
            return;

        CPF = gridCliente.CurrentRow.Cells["CPF"]?.Value?.ToString();
    }

    private void btnPesquisarProdutoConfirmar_Click(object sender, EventArgs e)
    {
        var repositorio = new ClienteRepositorio();

        var cliente = repositorio.BuscarClientePorCPF(CPF);

        if (cliente is null)
        {
            MessageBox.Show("Selecione um cliente!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        DataStore.Cliente = new Cliente(
            cliente.Id,
            cliente.CPF,
            cliente.Nome,
            cliente.Endereco,
            cliente.Telefone,
            cliente.Email
        );

        txtPesquisarCliente.Text = string.Empty;

        this.Close();
    }

    private void frmPesquisarCliente_Load(object sender, EventArgs e)
    {
        var repositorio = new ClienteRepositorio();

        BuscarTodosClientes(repositorio);
    }

    private void btnPesquisarProdutoCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
