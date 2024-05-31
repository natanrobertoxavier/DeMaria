using ControleVendas.repositorio;

namespace ControleVendas.formularios.relatorios;
public partial class frmRelatorioVendas : Form
{
    public frmRelatorioVendas()
    {
        InitializeComponent();

        VendaRepositorio repositorio = new VendaRepositorio();

        var vendas = repositorio.BuscarTodasAsVendas();

        reportRelatorioVendas.LocalReport.ReportEmbeddedResource =
            "ControleVendas.formularios.relatorios.relatorios.RelatorioVendas.rdlc";

        reportRelatorioVendas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRelatorioDeVendas", vendas));

        reportRelatorioVendas.RefreshReport();
    }
}
