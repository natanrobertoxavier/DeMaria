﻿namespace ControleVendas;

partial class frmPrincipal
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new MenuStrip();
        cadastrosToolStripMenuItem = new ToolStripMenuItem();
        cadastrarToolStripMenuItem = new ToolStripMenuItem();
        clienteToolStripMenuItem = new ToolStripMenuItem();
        produtosToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(976, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // cadastrosToolStripMenuItem
        // 
        cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
        cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
        cadastrosToolStripMenuItem.Size = new Size(50, 20);
        cadastrosToolStripMenuItem.Text = "Menu";
        // 
        // cadastrarToolStripMenuItem
        // 
        cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtosToolStripMenuItem });
        cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
        cadastrarToolStripMenuItem.Size = new Size(180, 22);
        cadastrarToolStripMenuItem.Text = "Cadastrar";
        // 
        // clienteToolStripMenuItem
        // 
        clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
        clienteToolStripMenuItem.Size = new Size(180, 22);
        clienteToolStripMenuItem.Text = "Clientes";
        clienteToolStripMenuItem.Click += this.clienteToolStripMenuItem_Click;
        // 
        // produtosToolStripMenuItem
        // 
        produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
        produtosToolStripMenuItem.Size = new Size(180, 22);
        produtosToolStripMenuItem.Text = "Produtos";
        // 
        // frmPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(976, 576);
        Controls.Add(menuStrip1);
        Name = "frmPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Empresa X";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem cadastrosToolStripMenuItem;
    private ToolStripMenuItem cadastrarToolStripMenuItem;
    private ToolStripMenuItem clienteToolStripMenuItem;
    private ToolStripMenuItem produtosToolStripMenuItem;
}
