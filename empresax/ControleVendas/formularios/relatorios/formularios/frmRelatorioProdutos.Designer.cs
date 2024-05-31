namespace ControleVendas.formularios.relatorios.formularios;

partial class frmRelatorioProdutos
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
        reportRelatorioProdutos = new Microsoft.Reporting.WinForms.ReportViewer();
        SuspendLayout();
        // 
        // reportRelatorioProdutos
        // 
        reportRelatorioProdutos.Dock = DockStyle.Fill;
        reportRelatorioProdutos.Location = new Point(0, 0);
        reportRelatorioProdutos.Name = "ReportViewer";
        reportRelatorioProdutos.ServerReport.BearerToken = null;
        reportRelatorioProdutos.Size = new Size(800, 450);
        reportRelatorioProdutos.TabIndex = 0;
        // 
        // frmRelatorioProdutos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(reportRelatorioProdutos);
        Name = "frmRelatorioProdutos";
        Text = "frmRelatorioProdutos";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportRelatorioProdutos;
}