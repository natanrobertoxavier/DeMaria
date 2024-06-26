﻿namespace ControleVendas.formularios.vendas;

partial class frmRegistrarVenda
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
        panel1 = new Panel();
        panel3 = new Panel();
        dgVendas = new DataGridView();
        panel4 = new Panel();
        btnCancelar = new Button();
        btnConfirmar = new Button();
        panel2 = new Panel();
        lblNumeroDoPedidoCaption = new Label();
        lblNumeroPedido = new Label();
        txtQuantidadeProduto = new TextBox();
        lblPrecoUnitario = new Label();
        lblNomeProdutoPesquisado = new Label();
        btnPesquisarCliente = new Button();
        btnPesquisarProduto = new Button();
        txtCodigoDeBarrasPesquisa = new TextBox();
        label2 = new Label();
        lblNomeCliente = new Label();
        txtCPFConsulta = new TextBox();
        label1 = new Label();
        btnSair = new Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgVendas).BeginInit();
        panel4.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(panel4);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(654, 466);
        panel1.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.Controls.Add(dgVendas);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 109);
        panel3.Name = "panel3";
        panel3.Size = new Size(654, 257);
        panel3.TabIndex = 3;
        // 
        // dgVendas
        // 
        dgVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgVendas.Dock = DockStyle.Fill;
        dgVendas.Location = new Point(0, 0);
        dgVendas.Name = "dgVendas";
        dgVendas.Size = new Size(654, 257);
        dgVendas.TabIndex = 3;
        // 
        // panel4
        // 
        panel4.Controls.Add(btnSair);
        panel4.Controls.Add(btnCancelar);
        panel4.Controls.Add(btnConfirmar);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 366);
        panel4.Name = "panel4";
        panel4.Size = new Size(654, 100);
        panel4.TabIndex = 2;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(460, 26);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(85, 45);
        btnCancelar.TabIndex = 7;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        btnCancelar.Click += btnCancelar_Click;
        // 
        // btnConfirmar
        // 
        btnConfirmar.Location = new Point(369, 26);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new Size(85, 45);
        btnConfirmar.TabIndex = 6;
        btnConfirmar.Text = "Confirmar";
        btnConfirmar.UseVisualStyleBackColor = true;
        btnConfirmar.Click += btnConfirmar_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(lblNumeroDoPedidoCaption);
        panel2.Controls.Add(lblNumeroPedido);
        panel2.Controls.Add(txtQuantidadeProduto);
        panel2.Controls.Add(lblPrecoUnitario);
        panel2.Controls.Add(lblNomeProdutoPesquisado);
        panel2.Controls.Add(btnPesquisarCliente);
        panel2.Controls.Add(btnPesquisarProduto);
        panel2.Controls.Add(txtCodigoDeBarrasPesquisa);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(lblNomeCliente);
        panel2.Controls.Add(txtCPFConsulta);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(654, 109);
        panel2.TabIndex = 0;
        // 
        // lblNumeroDoPedidoCaption
        // 
        lblNumeroDoPedidoCaption.AutoSize = true;
        lblNumeroDoPedidoCaption.Location = new Point(518, 47);
        lblNumeroDoPedidoCaption.Name = "lblNumeroDoPedidoCaption";
        lblNumeroDoPedidoCaption.Size = new Size(72, 15);
        lblNumeroDoPedidoCaption.TabIndex = 11;
        lblNumeroDoPedidoCaption.Text = "Nº da venda";
        // 
        // lblNumeroPedido
        // 
        lblNumeroPedido.AutoSize = true;
        lblNumeroPedido.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblNumeroPedido.Location = new Point(518, 71);
        lblNumeroPedido.Name = "lblNumeroPedido";
        lblNumeroPedido.Size = new Size(118, 28);
        lblNumeroPedido.TabIndex = 10;
        lblNumeroPedido.Text = "Nro Pedido";
        // 
        // txtQuantidadeProduto
        // 
        txtQuantidadeProduto.Location = new Point(281, 48);
        txtQuantidadeProduto.Name = "txtQuantidadeProduto";
        txtQuantidadeProduto.Size = new Size(61, 23);
        txtQuantidadeProduto.TabIndex = 5;
        txtQuantidadeProduto.TextAlign = HorizontalAlignment.Right;
        txtQuantidadeProduto.Visible = false;
        txtQuantidadeProduto.Leave += txtQuantidadeProduto_Leave;
        // 
        // lblPrecoUnitario
        // 
        lblPrecoUnitario.AutoSize = true;
        lblPrecoUnitario.Location = new Point(135, 82);
        lblPrecoUnitario.Name = "lblPrecoUnitario";
        lblPrecoUnitario.Size = new Size(115, 15);
        lblPrecoUnitario.TabIndex = 8;
        lblPrecoUnitario.Text = "R$ PRECO UNITARIO";
        // 
        // lblNomeProdutoPesquisado
        // 
        lblNomeProdutoPesquisado.AutoSize = true;
        lblNomeProdutoPesquisado.Location = new Point(12, 82);
        lblNomeProdutoPesquisado.Name = "lblNomeProdutoPesquisado";
        lblNomeProdutoPesquisado.Size = new Size(118, 15);
        lblNomeProdutoPesquisado.TabIndex = 7;
        lblNomeProdutoPesquisado.Text = "NOME DO PRODUTO";
        // 
        // btnPesquisarCliente
        // 
        btnPesquisarCliente.ImageAlign = ContentAlignment.MiddleLeft;
        btnPesquisarCliente.Location = new Point(196, 6);
        btnPesquisarCliente.Name = "btnPesquisarCliente";
        btnPesquisarCliente.Size = new Size(66, 23);
        btnPesquisarCliente.TabIndex = 2;
        btnPesquisarCliente.Text = "Pesquisar";
        btnPesquisarCliente.UseVisualStyleBackColor = true;
        btnPesquisarCliente.Click += btnPesquisarCliente_Click;
        // 
        // btnPesquisarProduto
        // 
        btnPesquisarProduto.ImageAlign = ContentAlignment.MiddleLeft;
        btnPesquisarProduto.Location = new Point(196, 47);
        btnPesquisarProduto.Name = "btnPesquisarProduto";
        btnPesquisarProduto.Size = new Size(66, 23);
        btnPesquisarProduto.TabIndex = 4;
        btnPesquisarProduto.Text = "Pesquisar";
        btnPesquisarProduto.UseVisualStyleBackColor = true;
        btnPesquisarProduto.Click += btnPesquisarProduto_Click;
        // 
        // txtCodigoDeBarrasPesquisa
        // 
        txtCodigoDeBarrasPesquisa.Location = new Point(69, 47);
        txtCodigoDeBarrasPesquisa.Name = "txtCodigoDeBarrasPesquisa";
        txtCodigoDeBarrasPesquisa.Size = new Size(121, 23);
        txtCodigoDeBarrasPesquisa.TabIndex = 3;
        txtCodigoDeBarrasPesquisa.Leave += txtCodigoDeBarrasPesquisa_Leave;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 50);
        label2.Name = "label2";
        label2.Size = new Size(53, 15);
        label2.TabIndex = 3;
        label2.Text = "Produto:";
        // 
        // lblNomeCliente
        // 
        lblNomeCliente.AutoSize = true;
        lblNomeCliente.Location = new Point(281, 9);
        lblNomeCliente.Name = "lblNomeCliente";
        lblNomeCliente.Size = new Size(109, 15);
        lblNomeCliente.TabIndex = 2;
        lblNomeCliente.Text = "NOME DO CLIENTE";
        // 
        // txtCPFConsulta
        // 
        txtCPFConsulta.Location = new Point(69, 6);
        txtCPFConsulta.MaxLength = 14;
        txtCPFConsulta.Name = "txtCPFConsulta";
        txtCPFConsulta.Size = new Size(121, 23);
        txtCPFConsulta.TabIndex = 1;
        txtCPFConsulta.TextAlign = HorizontalAlignment.Right;
        txtCPFConsulta.TextChanged += txtCPFConsulta_TextChanged;
        txtCPFConsulta.Leave += txtCPFConsulta_Leave;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(47, 15);
        label1.TabIndex = 0;
        label1.Text = "Cliente:";
        // 
        // btnSair
        // 
        btnSair.Location = new Point(551, 26);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(85, 45);
        btnSair.TabIndex = 8;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = true;
        btnSair.Click += btnSair_Click;
        // 
        // frmRegistrarVenda
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(654, 466);
        Controls.Add(panel1);
        Name = "frmRegistrarVenda";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registrar Venda";
        Load += frmRegistrarVenda_Load;
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgVendas).EndInit();
        panel4.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel4;
    private Panel panel2;
    private Panel panel3;
    private TextBox txtCPFConsulta;
    private Label label1;
    private TextBox txtCodigoDeBarrasPesquisa;
    private Label label2;
    private Label lblNomeCliente;
    private Button btnPesquisarProduto;
    private Button btnPesquisarCliente;
    private Label lblNomeProdutoPesquisado;
    private Label lblPrecoUnitario;
    private DataGridView dgVendas;
    private TextBox txtQuantidadeProduto;
    private Button btnCancelar;
    private Button btnConfirmar;
    private Label lblNumeroPedido;
    private Label lblNumeroDoPedidoCaption;
    private Button btnSair;
}