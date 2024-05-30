using ControleVendas.formularios.vendas;
using ControleVendas.model;
using ControleVendas.repositorio;
using System.Reflection.Metadata.Ecma335;

namespace ControleVendas.formularios.pesquisas;
public partial class frmPesquisarProduto : Form
{
    private string CodigoDeBarras { get; set; }
    public frmPesquisarProduto()
    {
        InitializeComponent();
    }
    private void BuscarTodosProdutos(ProdutoRepositorio repositorio)
    {
        var produtos = repositorio.BuscarTodosProdutos();

        dgProdutos.DataSource = produtos;

        dgProdutos.Columns.Clear();

        #region Personalizacao-Celula-CODIGODEBARRAS
        DataGridViewTextBoxColumn codigoDeBarras = new()
        {
            DataPropertyName = "CODIGODEBARRAS",
            Name = "CODIGODEBARRAS",
            HeaderText = "Cod Barras",
            Width = 87,
            ReadOnly = true,
        };
        dgProdutos.Columns.Add(codigoDeBarras);
        #endregion

        #region Personalizacao-Celula-NOME
        DataGridViewTextBoxColumn nome = new()
        {
            DataPropertyName = "NOME",
            Name = "NOME",
            HeaderText = "Nome",
            Width = 210,
            ReadOnly = true,
        };
        dgProdutos.Columns.Add(nome);
        #endregion

        #region Personalizacao-Celula-PRECO
        DataGridViewTextBoxColumn preco = new()
        {
            DataPropertyName = "PRECO",
            Name = "PRECO",
            HeaderText = "Preço",
            Width = 100,
            ReadOnly = true,
        };
        dgProdutos.Columns.Add(preco);

        preco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        #endregion
    }

    private void frmPesquisarProduto_Load(object sender, EventArgs e)
    {
        cbbPesquisa.SelectedIndex = 0;

        ProdutoRepositorio repositorio = new ProdutoRepositorio();

        BuscarTodosProdutos(repositorio);
    }

    private void btnPesquisarProdutoCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnPesquisarProdutoConfirmar_Click(object sender, EventArgs e)
    {
        var repositorio = new ProdutoRepositorio();

        var produto = repositorio.BuscarProdutoPorCodigoDeBarras(CodigoDeBarras);

        if (produto is null)
        {
            MessageBox.Show("Selecione um produto!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        DataStore.Produto = new Produto()
        {
            CodigoDeBarras = produto.CodigoDeBarras,
            Descricao = produto.Descricao,
            Id = produto.Id,
            Nome = produto.Nome,
            Preco = produto.Preco,
        };

        txtPesquisaProduto.Text = string.Empty;

        this.Close();
    }

    private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView gridroduto = sender as DataGridView;

        if (gridroduto is null)
            return;

        CodigoDeBarras = gridroduto.CurrentRow.Cells["CODIGODEBARRAS"]?.Value?.ToString();
    }
}
