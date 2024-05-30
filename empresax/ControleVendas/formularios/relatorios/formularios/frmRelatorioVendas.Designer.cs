namespace ControleVendas.formularios.relatorios;

partial class frmRelatorioVendas
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        reportRelatorioClientes = new Microsoft.Reporting.WinForms.ReportViewer();
        SuspendLayout();
        // 
        // reportRelatorioClientes
        // 
        reportRelatorioClientes.Dock = DockStyle.Fill;
        reportRelatorioClientes.Location = new Point(0, 0);
        reportRelatorioClientes.Name = "ReportViewer";
        reportRelatorioClientes.ServerReport.BearerToken = null;
        reportRelatorioClientes.Size = new Size(800, 450);
        reportRelatorioClientes.TabIndex = 0;
        // 
        // frmRelatorioVendas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(reportRelatorioClientes);
        Name = "frmRelatorioVendas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Relatório de Clientes";
        ResumeLayout(false);
    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportRelatorioClientes;
}