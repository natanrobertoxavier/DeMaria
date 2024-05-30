namespace ControleVendas.formularios.pesquisas;

partial class frmPesquisarProduto
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
        panel3 = new Panel();
        dgProdutos = new DataGridView();
        panel4 = new Panel();
        btnPesquisarProdutoCancelar = new Button();
        btnPesquisarProdutoConfirmar = new Button();
        panel2 = new Panel();
        cbbPesquisa = new ComboBox();
        txtPesquisaProduto = new TextBox();
        label2 = new Label();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
        panel4.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel3
        // 
        panel3.Controls.Add(dgProdutos);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 56);
        panel3.Name = "panel3";
        panel3.Size = new Size(476, 283);
        panel3.TabIndex = 6;
        // 
        // dgProdutos
        // 
        dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgProdutos.Dock = DockStyle.Fill;
        dgProdutos.Location = new Point(0, 0);
        dgProdutos.Name = "dgProdutos";
        dgProdutos.Size = new Size(476, 283);
        dgProdutos.TabIndex = 2;
        dgProdutos.CellClick += dgProdutos_CellClick;
        // 
        // panel4
        // 
        panel4.Controls.Add(btnPesquisarProdutoCancelar);
        panel4.Controls.Add(btnPesquisarProdutoConfirmar);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 339);
        panel4.Name = "panel4";
        panel4.Size = new Size(476, 62);
        panel4.TabIndex = 5;
        // 
        // btnPesquisarProdutoCancelar
        // 
        btnPesquisarProdutoCancelar.Location = new Point(378, 8);
        btnPesquisarProdutoCancelar.Name = "btnPesquisarProdutoCancelar";
        btnPesquisarProdutoCancelar.Size = new Size(85, 45);
        btnPesquisarProdutoCancelar.TabIndex = 4;
        btnPesquisarProdutoCancelar.Text = "Cancelar";
        btnPesquisarProdutoCancelar.UseVisualStyleBackColor = true;
        btnPesquisarProdutoCancelar.Click += btnPesquisarProdutoCancelar_Click;
        // 
        // btnPesquisarProdutoConfirmar
        // 
        btnPesquisarProdutoConfirmar.Location = new Point(287, 8);
        btnPesquisarProdutoConfirmar.Name = "btnPesquisarProdutoConfirmar";
        btnPesquisarProdutoConfirmar.Size = new Size(85, 45);
        btnPesquisarProdutoConfirmar.TabIndex = 3;
        btnPesquisarProdutoConfirmar.Text = "Confirmar";
        btnPesquisarProdutoConfirmar.UseVisualStyleBackColor = true;
        btnPesquisarProdutoConfirmar.Click += btnPesquisarProdutoConfirmar_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(cbbPesquisa);
        panel2.Controls.Add(txtPesquisaProduto);
        panel2.Controls.Add(label2);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(476, 56);
        panel2.TabIndex = 4;
        // 
        // cbbPesquisa
        // 
        cbbPesquisa.FormattingEnabled = true;
        cbbPesquisa.Items.AddRange(new object[] { "Cod. Barras", "Nome" });
        cbbPesquisa.Location = new Point(338, 18);
        cbbPesquisa.Name = "cbbPesquisa";
        cbbPesquisa.Size = new Size(121, 23);
        cbbPesquisa.TabIndex = 2;
        // 
        // txtPesquisaProduto
        // 
        txtPesquisaProduto.Location = new Point(131, 18);
        txtPesquisaProduto.Name = "txtPesquisaProduto";
        txtPesquisaProduto.Size = new Size(193, 23);
        txtPesquisaProduto.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(72, 21);
        label2.Name = "label2";
        label2.Size = new Size(53, 15);
        label2.TabIndex = 3;
        label2.Text = "Produto:";
        // 
        // frmPesquisarProduto
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 401);
        Controls.Add(panel3);
        Controls.Add(panel4);
        Controls.Add(panel2);
        Name = "frmPesquisarProduto";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pesquisar Produto";
        Load += frmPesquisarProduto_Load;
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
        panel4.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel3;
    private Panel panel4;
    private Panel panel2;
    private TextBox txtPesquisaProduto;
    private Label label2;
    private DataGridView dgProdutos;
    private Button btnPesquisarProdutoCancelar;
    private Button btnPesquisarProdutoConfirmar;
    private ComboBox cbbPesquisa;
}