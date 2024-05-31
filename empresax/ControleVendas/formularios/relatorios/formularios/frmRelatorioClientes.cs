using ControleVendas.repositorio;

namespace ControleVendas.formularios.relatorios.formularios;
public partial class frmRelatorioClientes : Form
{
    public frmRelatorioClientes()
    {
        InitializeComponent();

        ClienteRepositorio repositorio = new ClienteRepositorio();

        var clientes = repositorio.BuscarTodosClientes();

        reportRelatorioClientes.LocalReport.ReportEmbeddedResource =
            "ControleVendas.formularios.relatorios.relatorios.RelatorioClientes.rdlc";

        reportRelatorioClientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRelatorioDeClientes", clientes));

        reportRelatorioClientes.RefreshReport();
    }
}
