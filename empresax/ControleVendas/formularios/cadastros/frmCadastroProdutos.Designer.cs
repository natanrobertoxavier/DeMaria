namespace ControleVendas.formularios.cadastros;

partial class frmCadastroProdutos
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
        tabProdutos = new TabControl();
        tabConsulta = new TabPage();
        panel3 = new Panel();
        btnCadastroProdutoNovo = new Button();
        btnCadastroProdutoSair = new Button();
        btnCadastroProdutoExcluir = new Button();
        txtCadastroProdutoEditar = new Button();
        dgProdutos = new DataGridView();
        panel1 = new Panel();
        btnNovo = new Button();
        btnSair = new Button();
        btnExcluir = new Button();
        btnEditar = new Button();
        tabCampos = new TabPage();
        txtCodigoDeBarras = new TextBox();
        label6 = new Label();
        txtPreco = new TextBox();
        label4 = new Label();
        txtDescricao = new TextBox();
        panel4 = new Panel();
        btnCadastroProdutoCancelar = new Button();
        btnCadastroProdutoSalvar = new Button();
        panel2 = new Panel();
        btnCancelar = new Button();
        btnSalvar = new Button();
        txtEstoque = new TextBox();
        label5 = new Label();
        label3 = new Label();
        txtNome = new TextBox();
        label2 = new Label();
        txtCodigo = new TextBox();
        label1 = new Label();
        tabProdutos.SuspendLayout();
        tabConsulta.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
        panel1.SuspendLayout();
        tabCampos.SuspendLayout();
        panel4.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // tabProdutos
        // 
        tabProdutos.Controls.Add(tabConsulta);
        tabProdutos.Controls.Add(tabCampos);
        tabProdutos.Location = new Point(0, 1);
        tabProdutos.Name = "tabProdutos";
        tabProdutos.SelectedIndex = 0;
        tabProdutos.Size = new Size(472, 306);
        tabProdutos.TabIndex = 1;
        tabProdutos.SelectedIndexChanged += tabProdutos_SelectedIndexChanged;
        // 
        // tabConsulta
        // 
        tabConsulta.AutoScroll = true;
        tabConsulta.Controls.Add(panel3);
        tabConsulta.Controls.Add(dgProdutos);
        tabConsulta.Controls.Add(panel1);
        tabConsulta.Location = new Point(4, 24);
        tabConsulta.Name = "tabConsulta";
        tabConsulta.Padding = new Padding(3);
        tabConsulta.Size = new Size(464, 278);
        tabConsulta.TabIndex = 0;
        tabConsulta.Text = "Consulta";
        tabConsulta.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Anchor = AnchorStyles.Bottom;
        panel3.Controls.Add(btnCadastroProdutoNovo);
        panel3.Controls.Add(btnCadastroProdutoSair);
        panel3.Controls.Add(btnCadastroProdutoExcluir);
        panel3.Controls.Add(txtCadastroProdutoEditar);
        panel3.Location = new Point(3, 210);
        panel3.Name = "panel3";
        panel3.Size = new Size(459, 65);
        panel3.TabIndex = 2;
        // 
        // btnCadastroProdutoNovo
        // 
        btnCadastroProdutoNovo.Location = new Point(96, 10);
        btnCadastroProdutoNovo.Name = "btnCadastroProdutoNovo";
        btnCadastroProdutoNovo.Size = new Size(85, 45);
        btnCadastroProdutoNovo.TabIndex = 1;
        btnCadastroProdutoNovo.Text = "Novo";
        btnCadastroProdutoNovo.UseVisualStyleBackColor = true;
        btnCadastroProdutoNovo.Click += btnCadastroProdutoNovo_Click;
        // 
        // btnCadastroProdutoSair
        // 
        btnCadastroProdutoSair.Location = new Point(368, 10);
        btnCadastroProdutoSair.Name = "btnCadastroProdutoSair";
        btnCadastroProdutoSair.Size = new Size(85, 45);
        btnCadastroProdutoSair.TabIndex = 4;
        btnCadastroProdutoSair.Text = "Sair";
        btnCadastroProdutoSair.UseVisualStyleBackColor = true;
        btnCadastroProdutoSair.Click += btnCadastroProdutoSair_Click;
        // 
        // btnCadastroProdutoExcluir
        // 
        btnCadastroProdutoExcluir.Location = new Point(278, 10);
        btnCadastroProdutoExcluir.Name = "btnCadastroProdutoExcluir";
        btnCadastroProdutoExcluir.Size = new Size(85, 45);
        btnCadastroProdutoExcluir.TabIndex = 3;
        btnCadastroProdutoExcluir.Text = "Excluir";
        btnCadastroProdutoExcluir.UseVisualStyleBackColor = true;
        btnCadastroProdutoExcluir.Click += btnCadastroProdutoExcluir_Click;
        // 
        // txtCadastroProdutoEditar
        // 
        txtCadastroProdutoEditar.Location = new Point(187, 10);
        txtCadastroProdutoEditar.Name = "txtCadastroProdutoEditar";
        txtCadastroProdutoEditar.Size = new Size(85, 45);
        txtCadastroProdutoEditar.TabIndex = 2;
        txtCadastroProdutoEditar.Text = "Editar";
        txtCadastroProdutoEditar.UseVisualStyleBackColor = true;
        txtCadastroProdutoEditar.Click += txtCadastroProdutoEditar_Click;
        // 
        // dgProdutos
        // 
        dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgProdutos.Location = new Point(0, 0);
        dgProdutos.Name = "dgProdutos";
        dgProdutos.Size = new Size(462, 204);
        dgProdutos.TabIndex = 1;
        dgProdutos.CellClick += dgProdutos_CellClick;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Bottom;
        panel1.Controls.Add(btnNovo);
        panel1.Controls.Add(btnSair);
        panel1.Controls.Add(btnExcluir);
        panel1.Controls.Add(btnEditar);
        panel1.Location = new Point(4, 277);
        panel1.Name = "panel1";
        panel1.Size = new Size(459, 65);
        panel1.TabIndex = 0;
        // 
        // btnNovo
        // 
        btnNovo.Location = new Point(96, 10);
        btnNovo.Name = "btnNovo";
        btnNovo.Size = new Size(85, 45);
        btnNovo.TabIndex = 1;
        btnNovo.Text = "Novo";
        btnNovo.UseVisualStyleBackColor = true;
        // 
        // btnSair
        // 
        btnSair.Location = new Point(368, 10);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(85, 45);
        btnSair.TabIndex = 4;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = true;
        // 
        // btnExcluir
        // 
        btnExcluir.Location = new Point(278, 10);
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(85, 45);
        btnExcluir.TabIndex = 3;
        btnExcluir.Text = "Excluir";
        btnExcluir.UseVisualStyleBackColor = true;
        // 
        // btnEditar
        // 
        btnEditar.Location = new Point(187, 10);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(85, 45);
        btnEditar.TabIndex = 2;
        btnEditar.Text = "Editar";
        btnEditar.UseVisualStyleBackColor = true;
        // 
        // tabCampos
        // 
        tabCampos.Controls.Add(txtCodigoDeBarras);
        tabCampos.Controls.Add(label6);
        tabCampos.Controls.Add(txtPreco);
        tabCampos.Controls.Add(label4);
        tabCampos.Controls.Add(txtDescricao);
        tabCampos.Controls.Add(panel4);
        tabCampos.Controls.Add(panel2);
        tabCampos.Controls.Add(txtEstoque);
        tabCampos.Controls.Add(label5);
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
        // txtCodigoDeBarras
        // 
        txtCodigoDeBarras.Location = new Point(98, 26);
        txtCodigoDeBarras.Name = "txtCodigoDeBarras";
        txtCodigoDeBarras.Size = new Size(139, 23);
        txtCodigoDeBarras.TabIndex = 1;
        txtCodigoDeBarras.TextAlign = HorizontalAlignment.Right;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(101, 11);
        label6.Name = "label6";
        label6.Size = new Size(97, 15);
        label6.TabIndex = 15;
        label6.Text = "Código de Barras";
        // 
        // txtPreco
        // 
        txtPreco.Location = new Point(10, 168);
        txtPreco.Name = "txtPreco";
        txtPreco.Size = new Size(138, 23);
        txtPreco.TabIndex = 4;
        txtPreco.KeyPress += txtPreco_KeyPress;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(178, 150);
        label4.Name = "label4";
        label4.Size = new Size(80, 15);
        label4.TabIndex = 13;
        label4.Text = "Estoque Atual";
        // 
        // txtDescricao
        // 
        txtDescricao.Location = new Point(10, 118);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(396, 23);
        txtDescricao.TabIndex = 3;
        txtDescricao.TextChanged += txtDescricao_TextChanged;
        // 
        // panel4
        // 
        panel4.Anchor = AnchorStyles.Bottom;
        panel4.Controls.Add(btnCadastroProdutoCancelar);
        panel4.Controls.Add(btnCadastroProdutoSalvar);
        panel4.Location = new Point(1, 210);
        panel4.Name = "panel4";
        panel4.Size = new Size(460, 65);
        panel4.TabIndex = 11;
        // 
        // btnCadastroProdutoCancelar
        // 
        btnCadastroProdutoCancelar.Location = new Point(369, 10);
        btnCadastroProdutoCancelar.Name = "btnCadastroProdutoCancelar";
        btnCadastroProdutoCancelar.Size = new Size(85, 45);
        btnCadastroProdutoCancelar.TabIndex = 7;
        btnCadastroProdutoCancelar.Text = "Cancelar";
        btnCadastroProdutoCancelar.UseVisualStyleBackColor = true;
        btnCadastroProdutoCancelar.Click += btnCadastroProdutoCancelar_Click;
        // 
        // btnCadastroProdutoSalvar
        // 
        btnCadastroProdutoSalvar.Location = new Point(278, 10);
        btnCadastroProdutoSalvar.Name = "btnCadastroProdutoSalvar";
        btnCadastroProdutoSalvar.Size = new Size(85, 45);
        btnCadastroProdutoSalvar.TabIndex = 6;
        btnCadastroProdutoSalvar.Text = "Salvar";
        btnCadastroProdutoSalvar.UseVisualStyleBackColor = true;
        btnCadastroProdutoSalvar.Click += btnCadastroProdutoSalvar_Click;
        // 
        // panel2
        // 
        panel2.Anchor = AnchorStyles.Bottom;
        panel2.Controls.Add(btnCancelar);
        panel2.Controls.Add(btnSalvar);
        panel2.Location = new Point(133, 387);
        panel2.Name = "panel2";
        panel2.Size = new Size(460, 65);
        panel2.TabIndex = 10;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(369, 10);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(85, 45);
        btnCancelar.TabIndex = 6;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // btnSalvar
        // 
        btnSalvar.Location = new Point(278, 10);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(85, 45);
        btnSalvar.TabIndex = 5;
        btnSalvar.Text = "Salvar";
        btnSalvar.UseVisualStyleBackColor = true;
        // 
        // txtEstoque
        // 
        txtEstoque.Enabled = false;
        txtEstoque.Location = new Point(178, 168);
        txtEstoque.Name = "txtEstoque";
        txtEstoque.Size = new Size(138, 23);
        txtEstoque.TabIndex = 5;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(10, 150);
        label5.Name = "label5";
        label5.Size = new Size(37, 15);
        label5.TabIndex = 8;
        label5.Text = "Preço";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(10, 103);
        label3.Name = "label3";
        label3.Size = new Size(58, 15);
        label3.TabIndex = 4;
        label3.Text = "Descrição";
        // 
        // txtNome
        // 
        txtNome.Location = new Point(10, 69);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(399, 23);
        txtNome.TabIndex = 2;
        txtNome.TextChanged += txtNome_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(10, 54);
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
        label1.Location = new Point(10, 11);
        label1.Name = "label1";
        label1.Size = new Size(46, 15);
        label1.TabIndex = 0;
        label1.Text = "Código";
        // 
        // frmCadastroProdutos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 308);
        Controls.Add(tabProdutos);
        Name = "frmCadastroProdutos";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cadastro de Produtos";
        Load += frmCadastroProdutos_Load;
        tabProdutos.ResumeLayout(false);
        tabConsulta.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
        panel1.ResumeLayout(false);
        tabCampos.ResumeLayout(false);
        tabCampos.PerformLayout();
        panel4.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabProdutos;
    private TabPage tabConsulta;
    private DataGridView dgProdutos;
    private Panel panel1;
    private Button btnNovo;
    private Button btnSair;
    private Button btnExcluir;
    private Button btnEditar;
    private TabPage tabCampos;
    private Panel panel2;
    private Button btnCancelar;
    private Button btnSalvar;
    private TextBox txtEstoque;
    private Label label5;
    private Label label3;
    private TextBox txtNome;
    private Label label2;
    private TextBox txtCodigo;
    private Label label1;
    private Panel panel3;
    private Button btnCadastroProdutoNovo;
    private Button btnCadastroProdutoSair;
    private Button btnCadastroProdutoExcluir;
    private Button txtCadastroProdutoEditar;
    private Panel panel4;
    private Button btnCadastroProdutoCancelar;
    private Button btnCadastroProdutoSalvar;
    private TextBox txtDescricao;
    private Label label4;
    private TextBox txtPreco;
    private TextBox txtCodigoDeBarras;
    private Label label6;
}