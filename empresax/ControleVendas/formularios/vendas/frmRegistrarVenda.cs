namespace ControleVendas.formularios.vendas;
public partial class frmRegistrarVenda : Form
{
    public frmRegistrarVenda()
    {
        InitializeComponent();
    }

    private void txtCPFConsulta_Leave(object sender, EventArgs e)
    {
        txtCPFConsulta.Enabled =  (string.IsNullOrEmpty(txtCPFConsulta.Text.Trim()) &&
            string.IsNullOrWhiteSpace(txtCPFConsulta.Text.Trim()));
    }
}
