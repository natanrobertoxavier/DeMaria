namespace ControleVendas.formularios.pesquisas;

partial class frmPesquisarCliente
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
        panel4 = new Panel();
        btnPesquisarProdutoCancelar = new Button();
        btnPesquisarProdutoConfirmar = new Button();
        dgClientes = new DataGridView();
        panel2 = new Panel();
        cbbPesquisa = new ComboBox();
        txtPesquisarCliente = new TextBox();
        label2 = new Label();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel4
        // 
        panel4.Controls.Add(btnPesquisarProdutoCancelar);
        panel4.Controls.Add(btnPesquisarProdutoConfirmar);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 339);
        panel4.Name = "panel4";
        panel4.Size = new Size(476, 62);
        panel4.TabIndex = 8;
        // 
        // btnPesquisarProdutoCancelar
        // 
        btnPesquisarProdutoCancelar.Location = new Point(378, 8);
        btnPesquisarProdutoCancelar.Name = "btnPesquisarProdutoCancelar";
        btnPesquisarProdutoCancelar.Size = new Size(85, 45);
        btnPesquisarProdutoCancelar.TabIndex = 4;
        btnPesquisarProdutoCancelar.Text = "Cancelar";
        btnPesquisarProdutoCancelar.UseVisualStyleBackColor = true;
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
        // dgClientes
        // 
        dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgClientes.Dock = DockStyle.Fill;
        dgClientes.Location = new Point(0, 56);
        dgClientes.Name = "dgClientes";
        dgClientes.Size = new Size(476, 345);
        dgClientes.TabIndex = 6;
        dgClientes.CellClick += dgClientes_CellClick;
        // 
        // panel2
        // 
        panel2.Controls.Add(cbbPesquisa);
        panel2.Controls.Add(txtPesquisarCliente);
        panel2.Controls.Add(label2);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(476, 56);
        panel2.TabIndex = 7;
        // 
        // cbbPesquisa
        // 
        cbbPesquisa.FormattingEnabled = true;
        cbbPesquisa.Items.AddRange(new object[] { "CPF", "Nome" });
        cbbPesquisa.Location = new Point(338, 18);
        cbbPesquisa.Name = "cbbPesquisa";
        cbbPesquisa.Size = new Size(121, 23);
        cbbPesquisa.TabIndex = 2;
        // 
        // txtPesquisarCliente
        // 
        txtPesquisarCliente.Location = new Point(131, 18);
        txtPesquisarCliente.Name = "txtPesquisarCliente";
        txtPesquisarCliente.Size = new Size(193, 23);
        txtPesquisarCliente.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(72, 21);
        label2.Name = "label2";
        label2.Size = new Size(47, 15);
        label2.TabIndex = 3;
        label2.Text = "Cliente:";
        // 
        // frmPesquisarCliente
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 401);
        Controls.Add(panel4);
        Controls.Add(dgClientes);
        Controls.Add(panel2);
        Name = "frmPesquisarCliente";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pesquisar Cliente";
        Load += frmPesquisarCliente_Load;
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel4;
    private Button btnPesquisarProdutoCancelar;
    private Button btnPesquisarProdutoConfirmar;
    private DataGridView dgClientes;
    private Panel panel2;
    private ComboBox cbbPesquisa;
    private TextBox txtPesquisarCliente;
    private Label label2;
}