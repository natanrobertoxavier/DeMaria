﻿namespace ControleVendas.formularios.cadastros;

partial class frmCadastroClientes
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
        tabClientes = new TabControl();
        tabConsulta = new TabPage();
        dgClientes = new DataGridView();
        panel1 = new Panel();
        btnCadastroClienteNovo = new Button();
        btnCadastroClienteSair = new Button();
        btnCadastroClienteExcluir = new Button();
        btnCadastroClienteEditar = new Button();
        tabCampos = new TabPage();
        txtTelefone = new MaskedTextBox();
        panel2 = new Panel();
        btnCadastroClienteCancelar = new Button();
        btnCadastroClienteSalvar = new Button();
        txtEmail = new TextBox();
        label5 = new Label();
        txtEndereco = new TextBox();
        label4 = new Label();
        label3 = new Label();
        txtNome = new TextBox();
        label2 = new Label();
        txtCodigo = new TextBox();
        label1 = new Label();
        tabClientes.SuspendLayout();
        tabConsulta.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
        panel1.SuspendLayout();
        tabCampos.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // tabClientes
        // 
        tabClientes.Controls.Add(tabConsulta);
        tabClientes.Controls.Add(tabCampos);
        tabClientes.Location = new Point(0, 0);
        tabClientes.Name = "tabClientes";
        tabClientes.SelectedIndex = 0;
        tabClientes.Size = new Size(472, 306);
        tabClientes.TabIndex = 0;
        // 
        // tabConsulta
        // 
        tabConsulta.AutoScroll = true;
        tabConsulta.Controls.Add(dgClientes);
        tabConsulta.Controls.Add(panel1);
        tabConsulta.Location = new Point(4, 24);
        tabConsulta.Name = "tabConsulta";
        tabConsulta.Padding = new Padding(3);
        tabConsulta.Size = new Size(464, 278);
        tabConsulta.TabIndex = 0;
        tabConsulta.Text = "Consulta";
        tabConsulta.UseVisualStyleBackColor = true;
        // 
        // dgClientes
        // 
        dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgClientes.Location = new Point(0, 0);
        dgClientes.Name = "dgClientes";
        dgClientes.Size = new Size(461, 211);
        dgClientes.TabIndex = 1;
        dgClientes.CellClick += dgClientes_CellClick;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Bottom;
        panel1.Controls.Add(btnCadastroClienteNovo);
        panel1.Controls.Add(btnCadastroClienteSair);
        panel1.Controls.Add(btnCadastroClienteExcluir);
        panel1.Controls.Add(btnCadastroClienteEditar);
        panel1.Location = new Point(2, 213);
        panel1.Name = "panel1";
        panel1.Size = new Size(459, 65);
        panel1.TabIndex = 0;
        // 
        // btnCadastroClienteNovo
        // 
        btnCadastroClienteNovo.Location = new Point(96, 10);
        btnCadastroClienteNovo.Name = "btnCadastroClienteNovo";
        btnCadastroClienteNovo.Size = new Size(85, 45);
        btnCadastroClienteNovo.TabIndex = 1;
        btnCadastroClienteNovo.Text = "Novo";
        btnCadastroClienteNovo.UseVisualStyleBackColor = true;
        btnCadastroClienteNovo.Click += btnCadastroClienteNovo_Click;
        // 
        // btnCadastroClienteSair
        // 
        btnCadastroClienteSair.Location = new Point(368, 10);
        btnCadastroClienteSair.Name = "btnCadastroClienteSair";
        btnCadastroClienteSair.Size = new Size(85, 45);
        btnCadastroClienteSair.TabIndex = 4;
        btnCadastroClienteSair.Text = "Sair";
        btnCadastroClienteSair.UseVisualStyleBackColor = true;
        btnCadastroClienteSair.Click += btnCadastroClienteSair_Click;
        // 
        // btnCadastroClienteExcluir
        // 
        btnCadastroClienteExcluir.Location = new Point(278, 10);
        btnCadastroClienteExcluir.Name = "btnCadastroClienteExcluir";
        btnCadastroClienteExcluir.Size = new Size(85, 45);
        btnCadastroClienteExcluir.TabIndex = 3;
        btnCadastroClienteExcluir.Text = "Excluir";
        btnCadastroClienteExcluir.UseVisualStyleBackColor = true;
        btnCadastroClienteExcluir.Click += btnCadastroClienteExcluir_Click;
        // 
        // btnCadastroClienteEditar
        // 
        btnCadastroClienteEditar.Location = new Point(187, 10);
        btnCadastroClienteEditar.Name = "btnCadastroClienteEditar";
        btnCadastroClienteEditar.Size = new Size(85, 45);
        btnCadastroClienteEditar.TabIndex = 2;
        btnCadastroClienteEditar.Text = "Editar";
        btnCadastroClienteEditar.UseVisualStyleBackColor = true;
        btnCadastroClienteEditar.Click += btnCadastroClienteEditar_Click;
        // 
        // tabCampos
        // 
        tabCampos.Controls.Add(txtTelefone);
        tabCampos.Controls.Add(panel2);
        tabCampos.Controls.Add(txtEmail);
        tabCampos.Controls.Add(label5);
        tabCampos.Controls.Add(txtEndereco);
        tabCampos.Controls.Add(label4);
        tabCampos.Controls.Add(label3);
        tabCampos.Controls.Add(txtNome);
        tabCampos.Controls.Add(label2);
        tabCampos.Controls.Add(txtCodigo);
        tabCampos.Controls.Add(label1);
        tabCampos.Location = new Point(4, 24);
        tabCampos.Name = "tabCampos";
        tabCampos.Padding = new Padding(3);
        tabCampos.Size = new Size(464, 278);
        tabCampos.TabIndex = 1;
        tabCampos.Text = "Dados";
        tabCampos.UseVisualStyleBackColor = true;
        // 
        // txtTelefone
        // 
        txtTelefone.Location = new Point(10, 118);
        txtTelefone.Mask = "(99) 0 0000-0000";
        txtTelefone.Name = "txtTelefone";
        txtTelefone.Size = new Size(110, 23);
        txtTelefone.TabIndex = 2;
        txtTelefone.Leave += txtTelefone_Leave;
        // 
        // panel2
        // 
        panel2.Anchor = AnchorStyles.Bottom;
        panel2.Controls.Add(btnCadastroClienteCancelar);
        panel2.Controls.Add(btnCadastroClienteSalvar);
        panel2.Location = new Point(1, 212);
        panel2.Name = "panel2";
        panel2.Size = new Size(460, 65);
        panel2.TabIndex = 10;
        // 
        // btnCadastroClienteCancelar
        // 
        btnCadastroClienteCancelar.Location = new Point(369, 10);
        btnCadastroClienteCancelar.Name = "btnCadastroClienteCancelar";
        btnCadastroClienteCancelar.Size = new Size(85, 45);
        btnCadastroClienteCancelar.TabIndex = 6;
        btnCadastroClienteCancelar.Text = "Cancelar";
        btnCadastroClienteCancelar.UseVisualStyleBackColor = true;
        btnCadastroClienteCancelar.Click += btnCadastroClienteCancelar_Click;
        // 
        // btnCadastroClienteSalvar
        // 
        btnCadastroClienteSalvar.Location = new Point(278, 10);
        btnCadastroClienteSalvar.Name = "btnCadastroClienteSalvar";
        btnCadastroClienteSalvar.Size = new Size(85, 45);
        btnCadastroClienteSalvar.TabIndex = 5;
        btnCadastroClienteSalvar.Text = "Salvar";
        btnCadastroClienteSalvar.UseVisualStyleBackColor = true;
        btnCadastroClienteSalvar.Click += btnCadastroClienteSalvar_Click;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(162, 118);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(247, 23);
        txtEmail.TabIndex = 3;
        txtEmail.TextChanged += txtEmail_TextChanged;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(162, 100);
        label5.Name = "label5";
        label5.Size = new Size(41, 15);
        label5.TabIndex = 8;
        label5.Text = "E-mail";
        // 
        // txtEndereco
        // 
        txtEndereco.Location = new Point(10, 166);
        txtEndereco.Name = "txtEndereco";
        txtEndereco.Size = new Size(399, 23);
        txtEndereco.TabIndex = 4;
        txtEndereco.TextChanged += txtEndereco_TextChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(10, 148);
        label4.Name = "label4";
        label4.Size = new Size(56, 15);
        label4.TabIndex = 6;
        label4.Text = "Endereço";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(10, 100);
        label3.Name = "label3";
        label3.Size = new Size(51, 15);
        label3.TabIndex = 4;
        label3.Text = "Telefone";
        // 
        // txtNome
        // 
        txtNome.Location = new Point(10, 69);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(399, 23);
        txtNome.TabIndex = 1;
        txtNome.TextChanged += txtNome_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(10, 51);
        label2.Name = "label2";
        label2.Size = new Size(40, 15);
        label2.TabIndex = 2;
        label2.Text = "Nome";
        // 
        // txtCodigo
        // 
        txtCodigo.Enabled = false;
        txtCodigo.Location = new Point(10, 26);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.Size = new Size(82, 23);
        txtCodigo.TabIndex = 1;
        txtCodigo.TextAlign = HorizontalAlignment.Right;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(10, 8);
        label1.Name = "label1";
        label1.Size = new Size(46, 15);
        label1.TabIndex = 0;
        label1.Text = "Código";
        // 
        // frmCadastroClientes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(471, 309);
        Controls.Add(tabClientes);
        Name = "frmCadastroClientes";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cadastro de Clientes";
        Load += frmCadastroClientes_Load;
        tabClientes.ResumeLayout(false);
        tabConsulta.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
        panel1.ResumeLayout(false);
        tabCampos.ResumeLayout(false);
        tabCampos.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabClientes;
    private TabPage tabConsulta;
    private TabPage tabCampos;
    private DataGridView dgClientes;
    private Panel panel1;
    private TextBox txtEmail;
    private Label label5;
    private TextBox txtEndereco;
    private Label label4;
    private Label label3;
    private TextBox txtNome;
    private Label label2;
    private TextBox txtCodigo;
    private Label label1;
    private Panel panel2;
    private Button btnCadastroClienteSalvar;
    private Button btnCadastroClienteCancelar;
    private Button btnCadastroClienteEditar;
    private Button btnCadastroClienteExcluir;
    private Button btnCadastroClienteSair;
    private Button btnCadastroClienteNovo;
    private MaskedTextBox txtTelefone;
}