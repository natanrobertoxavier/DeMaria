using ControleVendas.formularios.cadastros;
using ControleVendas.formularios.relatorios;
using ControleVendas.formularios.relatorios.formularios;
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
        using (var frm = new frmCadastroClientes())
            frm.ShowDialog();
    }

    private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (var frm = new frmCadastroProdutos())
            frm.ShowDialog();
    }

    private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (var frm = new frmRegistrarVenda())
            frm.ShowDialog();
    }

    private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (var frm = new frmRelatorioVendas())
            frm.ShowDialog();
    }

    private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        using (var frm = new frmRelatorioClientes())
            frm.ShowDialog();
    }

    private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        using (var frm = new frmRelatorioProdutos())
            frm.ShowDialog();
    }
}
