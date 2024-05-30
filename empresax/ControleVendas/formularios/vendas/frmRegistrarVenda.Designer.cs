namespace ControleVendas.formularios.vendas;

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
        panel4 = new Panel();
        panel2 = new Panel();
        btnPesquisarProduto = new Button();
        textBox1 = new TextBox();
        label2 = new Label();
        lblNomeCliente = new Label();
        txtCPFConsulta = new TextBox();
        label1 = new Label();
        panel1.SuspendLayout();
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
        panel1.Size = new Size(534, 324);
        panel1.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 85);
        panel3.Name = "panel3";
        panel3.Size = new Size(534, 139);
        panel3.TabIndex = 3;
        // 
        // panel4
        // 
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 224);
        panel4.Name = "panel4";
        panel4.Size = new Size(534, 100);
        panel4.TabIndex = 2;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnPesquisarProduto);
        panel2.Controls.Add(textBox1);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(lblNomeCliente);
        panel2.Controls.Add(txtCPFConsulta);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(534, 85);
        panel2.TabIndex = 0;
        // 
        // btnPesquisarProduto
        // 
        btnPesquisarProduto.ImageAlign = ContentAlignment.MiddleLeft;
        btnPesquisarProduto.Location = new Point(196, 50);
        btnPesquisarProduto.Name = "btnPesquisarProduto";
        btnPesquisarProduto.Size = new Size(66, 23);
        btnPesquisarProduto.TabIndex = 5;
        btnPesquisarProduto.Text = "Pesquisar";
        btnPesquisarProduto.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(69, 47);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(121, 23);
        textBox1.TabIndex = 4;
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
        lblNomeCliente.Location = new Point(196, 9);
        lblNomeCliente.Name = "lblNomeCliente";
        lblNomeCliente.Size = new Size(137, 15);
        lblNomeCliente.TabIndex = 2;
        lblNomeCliente.Text = "NATAN ROBERTO XAVIER";
        // 
        // txtCPFConsulta
        // 
        txtCPFConsulta.Location = new Point(69, 6);
        txtCPFConsulta.Name = "txtCPFConsulta";
        txtCPFConsulta.Size = new Size(121, 23);
        txtCPFConsulta.TabIndex = 1;
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
        // frmRegistrarVenda
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(534, 324);
        Controls.Add(panel1);
        Name = "frmRegistrarVenda";
        Text = "Registrar Venda";
        panel1.ResumeLayout(false);
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
    private TextBox textBox1;
    private Label label2;
    private Label lblNomeCliente;
    private Button btnPesquisarProduto;
}