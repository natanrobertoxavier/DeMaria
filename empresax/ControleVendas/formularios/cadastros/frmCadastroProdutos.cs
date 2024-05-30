using ControleVendas.model;
using ControleVendas.repositorio;
using ControleVendas.utilitarios;

namespace ControleVendas.formularios.cadastros;
public partial class frmCadastroProdutos : Form
{
    public frmCadastroProdutos()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
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

    private void LimparCamposCadastro()
    {
        txtCodigo.Text = string.Empty;
        txtDescricao.Text = string.Empty;
        txtEstoque.Text = string.Empty;
        txtNome.Text = string.Empty;
        txtPreco.Text = string.Empty;
        txtCodigoDeBarras.Text = string.Empty;
    }

    private void frmCadastroProdutos_Load(object sender, EventArgs e)
    {
        ProdutoRepositorio repositorio = new ProdutoRepositorio();

        BuscarTodosProdutos(repositorio);
    }

    private void btnCadastroProdutoSair_Click(object sender, EventArgs e)
    {
        LimparCamposCadastro();
        this.Close();
    }

    private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBox textBox = sender as TextBox;

        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
        {
            e.Handled = true;
        }

        if ((e.KeyChar == ',') && (textBox.Text.IndexOf(',') > -1))
        {
            e.Handled = true;
        }

        if ((e.KeyChar == ',') && textBox.Text.Length == 0)
        {
            e.Handled = true;
        }
    }

    private void txtCadastroProdutoEditar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Text == string.Empty)
        {
            MessageBox.Show("Selecione um produto para editar!");
            return;
        }

        tabProdutos.SelectedIndex = 1;
    }

    private void btnCadastroProdutoSalvar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCodigoDeBarras.Text.Trim()) ||
            string.IsNullOrEmpty(txtCodigoDeBarras.Text.Trim()))
        {
            MessageBox.Show("O código de barras do produto é obrigatório!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            txtCodigoDeBarras.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtNome.Text.Trim()) ||
            string.IsNullOrEmpty(txtNome.Text.Trim()))
        {
            MessageBox.Show("O nome do produto é obrigatório!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            txtNome.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtPreco.Text.Trim()) ||
            string.IsNullOrEmpty(txtPreco.Text.Trim()))
        {
            MessageBox.Show("O preço do produto é obrigatório!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            txtPreco.Focus();
            return;
        }

        var repositorio = new ProdutoRepositorio();

        var produto = new Produto(
            0,
            txtNome.Text,
            txtDescricao.Text,
            txtCodigoDeBarras.Text,
            decimal.TryParse(txtPreco.Text, out decimal preco) ? preco : 0,
            0
        );

        if (string.IsNullOrWhiteSpace(txtCodigo.Text.Trim()) ||
            string.IsNullOrEmpty(txtCodigo.Text.Trim()))
        {
            var codigoDeBarrasJaCadastrado = repositorio.BuscarProdutoPorCodigoDeBarras(txtCodigoDeBarras.Text);

            if (codigoDeBarrasJaCadastrado is not null)
            {
                MessageBox.Show($"Código de barras {txtCodigoDeBarras.Text} já cadastrado!",
                    "Operação inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtCodigoDeBarras.Focus();
                return;
            };

            repositorio.Cadastrar(produto);
        }
        else
        {
            produto.Id = int.TryParse(txtCodigo.Text, out int _id) ? _id : 0;
            repositorio.Atualizar(produto);
            tabProdutos.SelectedIndex = 0;
        };

        LimparCamposCadastro();

        BuscarTodosProdutos(repositorio);
    }

    private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView gridroduto = sender as DataGridView;

        var repositorio = new ProdutoRepositorio();

        if (gridroduto is null)
            return;

        LimparCamposCadastro();

        var codigoBarras = gridroduto.CurrentRow.Cells["CODIGODEBARRAS"]?.Value?.ToString();

        var produto = repositorio.BuscarProdutoPorCodigoDeBarras(codigoBarras);

        txtCodigo.Text = produto.Id.ToString();
        txtNome.Text = produto.Nome;
        txtDescricao.Text = produto.Descricao;
        txtCodigoDeBarras.Text = produto.CodigoDeBarras;
        txtPreco.Text = produto.Preco.ToString();
        txtEstoque.Text = produto.EstoqueAtual.ToString();
    }

    private void btnCadastroProdutoCancelar_Click(object sender, EventArgs e)
    {
        LimparCamposCadastro();

        tabProdutos.SelectedIndex = 0;
    }

    private void btnCadastroProdutoNovo_Click(object sender, EventArgs e)
    {
        LimparCamposCadastro();

        tabProdutos.SelectedIndex = 1;

        txtCodigoDeBarras.Focus();
    }

    private void btnCadastroProdutoExcluir_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) ||
            string.IsNullOrWhiteSpace(txtCodigo.Text.Trim()))
        {
            MessageBox.Show("Selecione um produto para exluir!");
            return;
        }

        DialogResult resultado = MessageBox.Show("Deseja realmente excluir o produto?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (resultado == DialogResult.Yes)
        {
            DataGridView gridProduto = sender as DataGridView;

            var id = int.TryParse(txtCodigo.Text, out int _id) ? _id : 0;

            var repositorio = new ProdutoRepositorio();

            repositorio.Apagar(id);

            BuscarTodosProdutos(repositorio);
            LimparCamposCadastro();
        }
    }

    private void txtNome_TextChanged(object sender, EventArgs e)
    {
        Utilitarios.ConverterParaMaiusculas(txtNome);
    }

    private void txtDescricao_TextChanged(object sender, EventArgs e)
    {
        Utilitarios.ConverterParaMaiusculas(txtDescricao);
    }

    private void tabProdutos_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtCodigoDeBarras.Enabled = (string.IsNullOrEmpty(txtCodigo.Text.Trim()) &&
                                     string.IsNullOrWhiteSpace(txtCodigoDeBarras.Text.Trim()));
    }
}
