using ControleVendas.formularios.cadastros;
using ControleVendas.formularios.vendas;

namespace ControleVendas;

public partial class frmPrincipal : Form
{
    public frmPrincipal()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
    }

    private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmCadastroClientes frmCadastroClientes = new frmCadastroClientes();
        frmCadastroClientes.ShowDialog();
    }

    private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmCadastroProdutos frmCadastroProdutos = new frmCadastroProdutos();
        frmCadastroProdutos.ShowDialog();
    }

    private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmRegistrarVenda frmRegistrarVenda = new frmRegistrarVenda();
        frmRegistrarVenda.ShowDialog();
    }
}
