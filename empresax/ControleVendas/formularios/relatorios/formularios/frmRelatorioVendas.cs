using ControleVendas.repositorio;

namespace ControleVendas.formularios.relatorios;
public partial class frmRelatorioVendas : Form
{
    public frmRelatorioVendas()
    {
        InitializeComponent();

        VendaRepositorio repositorio = new VendaRepositorio();

        var vendas = repositorio.BuscarTodasAsVendas();

        reportRelatorioClientes.LocalReport.ReportEmbeddedResource =
            "ControleVendas.formularios.relatorios.relatorios.RelatorioVendas.rdlc";

        reportRelatorioClientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRelatorioDeVendas", vendas));

        reportRelatorioClientes.RefreshReport();
    }
}
