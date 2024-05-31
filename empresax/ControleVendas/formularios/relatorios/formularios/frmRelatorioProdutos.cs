using ControleVendas.repositorio;

namespace ControleVendas.formularios.relatorios.formularios;
public partial class frmRelatorioProdutos : Form
{
    public frmRelatorioProdutos()
    {
        InitializeComponent();

        ProdutoRepositorio repositorio = new ProdutoRepositorio();

        var produtos = repositorio.BuscarTodosProdutos();

        reportRelatorioProdutos.LocalReport.ReportEmbeddedResource =
            "ControleVendas.formularios.relatorios.relatorios.RelatorioProdutos.rdlc";

        reportRelatorioProdutos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRelatorioDeProdutos", produtos));

        reportRelatorioProdutos.RefreshReport();
    }
}
