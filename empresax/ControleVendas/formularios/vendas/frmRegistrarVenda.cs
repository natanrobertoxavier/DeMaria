﻿using ControleVendas.formularios.pesquisas;
using ControleVendas.model;
using ControleVendas.repositorio;

namespace ControleVendas.formularios.vendas;
public partial class frmRegistrarVenda : Form
{
    private Cliente Cliente { get; set; }
    private decimal Quantidade { get; set; } = 1.000m;
    private List<Venda> ProdutosGrid = new List<Venda>();
    public frmRegistrarVenda()
    {
        InitializeComponent();
    }

    private void txtCPFConsulta_Leave(object sender, EventArgs e)
    {
        txtCPFConsulta.Enabled = (string.IsNullOrEmpty(txtCPFConsulta.Text.Trim()) &&
            string.IsNullOrWhiteSpace(txtCPFConsulta.Text.Trim()));
    }

    private void btnPesquisarProduto_Click(object sender, EventArgs e)
    {
        frmPesquisarProduto frmPesquisarProduto = new frmPesquisarProduto();

        frmPesquisarProduto.ShowDialog();

        if (DataStore.Produto is null)
            return;

        if (txtCodigoDeBarrasPesquisa.Text.Contains("*"))
        {
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

        txtCodigoDeBarrasPesquisa.Text = string.Empty;

        txtCodigoDeBarrasPesquisa.Focus();
    }

    private void txtCodigoDeBarrasPesquisa_Layout(object sender, LayoutEventArgs e)
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

        ProdutoRepositorio repositorio = new ProdutoRepositorio();

        DataStore.Produto = repositorio.BuscarProdutoPorCodigoDeBarras(txtCodigoDeBarrasPesquisa.Text);

        AdicionarProdutoPesquisadoAoGrid();
    }

    private void AdicionarProdutoPesquisadoAoGrid()
    {
        var quantidade = Quantidade;

        var produto = DataStore.Produto;

        Venda venda = new Venda()
        {
            ClienteId = 1,
            CodigoDeBarras = produto.CodigoDeBarras,
            Quantidade = quantidade,
            ValorUnitario = produto.Preco,
            ValorTotal = (produto.Preco * quantidade),
            DataVenda = DateTime.Now,
            NomeProduto = produto.Nome,
        };

        ProdutosGrid.Add(venda);

        dgVendas.DataSource = ProdutosGrid;

        dgVendas.Columns.Clear();

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

        #region Personalizacao-Celula-PRECOUNITARIO
        DataGridViewTextBoxColumn quantidadeGrid = new()
        {
            DataPropertyName = "QUANTIDADE",
            Name = "QUANTIDADE",
            HeaderText = "Qtde",
            Width = 100,
            ReadOnly = true,
        };
        dgVendas.Columns.Add(quantidadeGrid);

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

        precoTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        #endregion
    }

    private void frmRegistrarVenda_Load(object sender, EventArgs e)
    {
    }
}