namespace ControleVendas.formularios.relatorios;
public partial class frmRelatorioVendas : Form
{
    public frmRelatorioVendas()
    {
        InitializeComponent();

        reportRelatorioClientes.LocalReport.ReportEmbeddedResource =
            "ControleVendas.formularios.relatorios.relatorios.RelatorioVendas.rdlc";

        reportRelatorioClientes.RefreshReport();
    }
}
