﻿namespace ControleVendas.formularios.relatorios;

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
        reportRelatorioVendas = new Microsoft.Reporting.WinForms.ReportViewer();
        SuspendLayout();
        // 
        // reportRelatorioVendas
        // 
        reportRelatorioVendas.Dock = DockStyle.Fill;
        reportRelatorioVendas.Location = new Point(0, 0);
        reportRelatorioVendas.Name = "ReportViewer";
        reportRelatorioVendas.ServerReport.BearerToken = null;
        reportRelatorioVendas.Size = new Size(800, 450);
        reportRelatorioVendas.TabIndex = 0;
        // 
        // frmRelatorioVendas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(reportRelatorioVendas);
        Name = "frmRelatorioVendas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Relatório de Vendas";
        WindowState = FormWindowState.Maximized;
        ResumeLayout(false);
    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportRelatorioVendas;
}