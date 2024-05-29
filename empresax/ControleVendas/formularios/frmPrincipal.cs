using ControleVendas.formularios.cadastros;

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
        // Instancia o formulário de cadastro e o exibe de forma modal
        frmCadastroClientes formCadastro = new frmCadastroClientes();
        formCadastro.ShowDialog();
    }
}
