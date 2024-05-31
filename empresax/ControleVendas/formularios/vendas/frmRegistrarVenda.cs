using ControleVendas.formularios.pesquisas;
using ControleVendas.model;
using ControleVendas.repositorio;
using ControleVendas.utilitarios;
using Npgsql.Replication;
using System.Drawing;

namespace ControleVendas.formularios.vendas;
public partial class frmRegistrarVenda : Form
{
    private List<Venda> ProdutosGrid = new List<Venda>();
    private Cliente Cliente { get; set; }
    private decimal Quantidade { get; set; } = 1.000m;
    private string NumeroDaVenda { get; set; } = "Nº da venda";
    public frmRegistrarVenda()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
    }

    private void txtCPFConsulta_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCPFConsulta.Text) ||
            string.IsNullOrWhiteSpace(txtCPFConsulta.Text))
            return;

        AdicionaCliente();
    }

    private void btnPesquisarProduto_Click(object sender, EventArgs e)
    {
        frmPesquisarProduto frmPesquisarProduto = new frmPesquisarProduto();

        frmPesquisarProduto.ShowDialog();

        if (DataStore.Produto is null)
            return;

        if (txtCodigoDeBarrasPesquisa.Text.Contains("*"))
        {
            txtCodigoDeBarrasPesquisa.Text = DataStore.Produto.CodigoDeBarras;

            txtQuantidadeProduto.Visible = true;

            txtQuantidadeProduto.Focus();

            return;
        }

        AdicionarProdutoPesquisadoAoGrid();
    }

    private void txtQuantidadeProduto_Leave(object sender, EventArgs e)
    {
        txtQuantidadeProduto.Visible = false;

        Quantidade = decimal.TryParse(txtQuantidadeProduto.Text, out decimal qtde) ? qtde : 1.000m;

        if (!string.IsNullOrEmpty(txtCodigoDeBarrasPesquisa.Text) ||
            !string.IsNullOrWhiteSpace(txtCodigoDeBarrasPesquisa.Text))
            AdicionarProdutoPesquisadoAoGrid();

        txtQuantidadeProduto.Text = string.Empty;

        txtCodigoDeBarrasPesquisa.Text = string.Empty;

        txtCodigoDeBarrasPesquisa.Focus();
    }

    private void AdicionarProdutoPesquisadoAoGrid()
    {
        if (!string.IsNullOrEmpty(txtCodigoDeBarrasPesquisa.Text) ||
            !string.IsNullOrWhiteSpace(txtCodigoDeBarrasPesquisa.Text))
        {
            ProdutoRepositorio repositorio = new ProdutoRepositorio();

            DataStore.Produto = repositorio.BuscarProdutoPorCodigoDeBarras(txtCodigoDeBarrasPesquisa.Text.Replace("*", ""));
        }

        txtCodigoDeBarrasPesquisa.Text = string.Empty;
        txtCodigoDeBarrasPesquisa.Focus();

        if (DataStore.Produto is null)
        {
            MessageBox.Show("Produto não localizado!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return;
        }

        var produto = DataStore.Produto;

        lblNomeProdutoPesquisado.Text = produto.Nome;
        lblPrecoUnitario.Text = $"R$ {string.Format("{0:F3}", produto.Preco)}";

        Venda venda = new Venda()
        {
            ClienteId = DataStore.Cliente.Id,
            CodigoDeBarras = produto.CodigoDeBarras,
            Quantidade = Quantidade,
            ValorUnitario = produto.Preco,
            ValorTotal = (produto.Preco * Quantidade),
            DataVenda = DateTime.Now,
            NomeProduto = produto.Nome,
        };

        ProdutosGrid.Add(venda);

        dgVendas.DataSource = ProdutosGrid;

        dgVendas.Columns.Clear();

        Quantidade = 1.000m;

        #region Personalizacao-Celula-CODIGODEBARRAS
        DataGridViewTextBoxColumn codigoDeBarras = new()
        {
            DataPropertyName = "CODIGODEBARRAS",
            Name = "CODIGODEBARRAS",
            HeaderText = "Cod Barras",
            Width = 87,
            ReadOnly = true,
        };
        dgVendas.Columns.Add(codigoDeBarras);
        #endregion

        #region Personalizacao-Celula-NOME
        DataGridViewTextBoxColumn nome = new()
        {
            DataPropertyName = "NOMEPRODUTO",
            Name = "NOMEPRODUTO",
            HeaderText = "Nome",
            Width = 210,
            ReadOnly = true,
        };
        dgVendas.Columns.Add(nome);
        #endregion

        #region Personalizacao-Celula-QUANTIDADE
        DataGridViewTextBoxColumn quantidadeGrid = new()
        {
            DataPropertyName = "QUANTIDADE",
            Name = "QUANTIDADE",
            HeaderText = "Qtde",
            Width = 100,
            ReadOnly = true,
        };
        dgVendas.Columns.Add(quantidadeGrid);

        quantidadeGrid.DefaultCellStyle.Format = "F3";
        quantidadeGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        #endregion

        #region Personalizacao-Celula-PRECOUNITARIO
        DataGridViewTextBoxColumn precoUnitario = new()
        {
            DataPropertyName = "VALORUNITARIO",
            Name = "VALORUNITARIO",
            HeaderText = "Preço",
            Width = 100,
            ReadOnly = true,
        };
        dgVendas.Columns.Add(precoUnitario);

        precoUnitario.DefaultCellStyle.Format = "F3";
        precoUnitario.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        #endregion

        #region Personalizacao-Celula-PRECOTOTAL
        DataGridViewTextBoxColumn precoTotal = new()
        {
            DataPropertyName = "VALORTOTAL",
            Name = "VALORTOTAL",
            HeaderText = "Total",
            Width = 100,
            ReadOnly = true,
        };
        dgVendas.Columns.Add(precoTotal);

        precoTotal.DefaultCellStyle.Format = "F3";
        precoTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        #endregion

        Quantidade = 1.000m;
    }

    private void frmRegistrarVenda_Load(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void LimparCampos()
    {
        lblNomeCliente.Text = string.Empty;

        lblNomeProdutoPesquisado.Text = string.Empty;

        lblPrecoUnitario.Text = string.Empty;

        lblNumeroPedido.Text = string.Empty;

        lblNumeroDoPedidoCaption.Text = string.Empty;

        txtCPFConsulta.Text = string.Empty;
        txtCPFConsulta.Enabled = true;

        btnPesquisarCliente.Enabled = true;

        DataStore.Produto = null;

        DataStore.Cliente = null;

        ProdutosGrid.Clear();

        dgVendas.DataSource = null;
    }

    private void txtCodigoDeBarrasPesquisa_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCodigoDeBarrasPesquisa.Text) ||
            string.IsNullOrWhiteSpace(txtCodigoDeBarrasPesquisa.Text))
            return;

        if (txtCodigoDeBarrasPesquisa.Text.Contains("*"))
        {
            txtQuantidadeProduto.Visible = true;

            txtQuantidadeProduto.Focus();

            return;
        }

        AdicionarProdutoPesquisadoAoGrid();
    }

    private void btnPesquisarCliente_Click(object sender, EventArgs e)
    {
        frmPesquisarCliente frmPesquisarCliente = new frmPesquisarCliente();

        frmPesquisarCliente.ShowDialog();

        if (DataStore.Cliente is null)
        {
            txtCPFConsulta.Focus();
            return;
        }

        AdicionaCliente();
    }

    private void AdicionaCliente()
    {
        if (!string.IsNullOrEmpty(txtCPFConsulta.Text) ||
            !string.IsNullOrWhiteSpace(txtCPFConsulta.Text)) 
        { 
            ClienteRepositorio repositorio = new ClienteRepositorio();

            DataStore.Cliente = repositorio.BuscarClientePorCPF(txtCPFConsulta.Text);
        }

        if (DataStore.Cliente is null)
        {
            MessageBox.Show("Cliente não localizado!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            txtCPFConsulta.Text = string.Empty;
            txtCPFConsulta.Focus();
            return;
        }

        Cliente = DataStore.Cliente;

        lblNomeCliente.Text = DataStore.Cliente.Nome;

        txtCPFConsulta.Text = DataStore.Cliente.CPF;

        txtCodigoDeBarrasPesquisa.Text = string.Empty;
        txtCodigoDeBarrasPesquisa.Focus();

        txtCPFConsulta.Enabled = false;

        btnPesquisarCliente.Enabled = false;

        lblNumeroPedido.Text = Utilitarios.GerarCodigoVendas();
        lblNumeroDoPedidoCaption.Text = NumeroDaVenda;
    }

    private void txtCPFConsulta_TextChanged(object sender, EventArgs e)
    {
        Utilitarios.FormatarCPF(txtCPFConsulta);

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a venda?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (resultado == DialogResult.No)
            return;

        LimparCampos();

        txtCPFConsulta.Focus();
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
        RegistrarVenda();

        LimparCampos();

        txtCPFConsulta.Focus();
    }

    private void RegistrarVenda()
    {
        VendaRepositorio vendaRepositorio = new VendaRepositorio();
        
        var itensDaVenda = (List<Venda>) dgVendas.DataSource;

        var venda = new Venda()
        {
            Id = 0,
            ClienteId = itensDaVenda.Select(o => o.ClienteId).Distinct().FirstOrDefault(),
            CodigoDeBarras = string.Empty,
            NomeProduto = string.Empty,
            Quantidade = itensDaVenda.Sum(o => o.Quantidade),
            ValorUnitario = 0,
            ValorTotal = itensDaVenda.Sum(o => o.ValorTotal),
            DataVenda = DateTime.Now,
            CodigoDaVenda = lblNumeroPedido.Text,
        };

        vendaRepositorio.CadastrarVenda(venda);

        foreach (var itemDaVenda in itensDaVenda) 
        {
            var itemParaCadastro = new Venda()
            {
                Id = 0,
                ClienteId = 0,
                CodigoDeBarras = itemDaVenda.CodigoDeBarras,
                NomeProduto = string.Empty,
                Quantidade = itemDaVenda.Quantidade,
                ValorUnitario = itemDaVenda.ValorUnitario,
                ValorTotal = itemDaVenda.ValorTotal,
                DataVenda = DateTime.Now,
                CodigoDaVenda = lblNumeroPedido.Text,
            };

            vendaRepositorio.CadastrarItensDaVenda(itemParaCadastro);
        }

    }
}
