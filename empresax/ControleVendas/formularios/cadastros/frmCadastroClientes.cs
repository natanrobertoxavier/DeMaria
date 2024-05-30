﻿using ControleVendas.model;
using ControleVendas.repositorio;
using ControleVendas.utilitarios;

namespace ControleVendas.formularios.cadastros;
public partial class frmCadastroClientes : Form
{
    public frmCadastroClientes()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
    }

    private void BuscarTodosClientes(ClienteRepositorio repositorio)
    {
        var clientes = repositorio.BuscarTodosClientes();

        dgClientes.DataSource = clientes.ToList();

        dgClientes.Columns.Clear();

        #region Personalizacao-Celula-ID
        DataGridViewTextBoxColumn id = new()
        {
            DataPropertyName = "ID",
            Name = "ID",
            HeaderText = "Cod",
            Width = 40,
            ReadOnly = true,
        };

        id.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        dgClientes.Columns.Add(id);
        #endregion

        #region Personalizacao-Celula-NOME
        DataGridViewTextBoxColumn nome = new()
        {
            DataPropertyName = "NOME",
            Name = "NOME",
            HeaderText = "Nome",
            Width = 255,
            ReadOnly = true,
        };
        dgClientes.Columns.Add(nome);
        #endregion

        #region Personalizacao-Celula-TELEFONE
        DataGridViewTextBoxColumn telefone = new()
        {
            DataPropertyName = "TELEFONE",
            Name = "TELEFONE",
            HeaderText = "Telefone",
            Width = 100,
            ReadOnly = true,
        };
        dgClientes.Columns.Add(telefone);
        #endregion
    }

    private void LimparCamposCadastro()
    {
        txtCodigo.Text = string.Empty;
        txtNome.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtEndereco.Text = string.Empty;
        txtTelefone.Text = string.Empty;
    }

    private void btnCadastroClienteEditar_Click(object sender, EventArgs e)
    {
        if (txtCodigo.Text == string.Empty)
        {
            MessageBox.Show("Selecione um cliente para editar!");
            return;
        }

        tabClientes.SelectedIndex = 1;
    }

    private void btnCadastroClienteSalvar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text.Trim()) ||
            string.IsNullOrEmpty(txtNome.Text.Trim()))
        {
            MessageBox.Show("O nome do cliente é obrigatório!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            txtNome.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtEndereco.Text.Trim()) ||
            string.IsNullOrEmpty(txtEndereco.Text.Trim()))
        {
            MessageBox.Show("O endereço do cliente é obrigatório!",
                "Operação inválida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            txtEndereco.Focus();
            return;
        }

        if (!Utilitarios.ValidarTelefone(txtTelefone.Text))
        {
            MessageBox.Show("O telefone deve conter 11 dígitos!");
            txtTelefone.Focus();
            return;
        }

        var cliente = new Cliente(
            0,
            txtNome.Text,
            txtEndereco.Text,
            txtTelefone.Text,
            txtEmail.Text
        );

        var repositorio = new ClienteRepositorio();

        if (string.IsNullOrWhiteSpace(txtCodigo.Text.Trim()) ||
            string.IsNullOrEmpty(txtCodigo.Text.Trim()))
        {
            repositorio.Cadastrar(cliente);
        }
        else
        {
            cliente.Id = int.TryParse(txtCodigo.Text, out int _id) ? _id : 0;
            repositorio.Atualizar(cliente);
            tabClientes.SelectedIndex = 0;
        }

        LimparCamposCadastro();

        BuscarTodosClientes(repositorio);
    }

    private void frmCadastroClientes_Load(object sender, EventArgs e)
    {
        var repositorio = new ClienteRepositorio();

        BuscarTodosClientes(repositorio);
    }

    private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridView gridCliente = sender as DataGridView;

        var repositorio = new ClienteRepositorio();


        if (gridCliente is null)
            return;

        LimparCamposCadastro();

        var id = gridCliente.CurrentRow.Cells["ID"]?.Value?.ToString();

        var cliente = repositorio.BuscarClientePorId(int.TryParse(id, out int _id) ? _id : 0);

        txtCodigo.Text = cliente.Id.ToString();
        txtNome.Text = cliente.Nome;
        txtEmail.Text = cliente.Email;
        txtEndereco.Text = cliente.Endereco;
        txtTelefone.Text = cliente.Telefone;
    }

    private void btnCadastroClienteCancelar_Click(object sender, EventArgs e)
    {
        LimparCamposCadastro();

        tabClientes.SelectedIndex = 0;
    }

    private void btnCadastroClienteNovo_Click(object sender, EventArgs e)
    {
        LimparCamposCadastro();

        tabClientes.SelectedIndex = 1;

        txtNome.Focus();
    }

    private void btnCadastroClienteExcluir_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) ||
            string.IsNullOrWhiteSpace(txtCodigo.Text.Trim()))
        {
            MessageBox.Show("Selecione um cliente para exluir!");
            return;
        }

        DialogResult resultado = MessageBox.Show("Deseja realmente excluir o cliente?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (resultado == DialogResult.Yes)
        {
            DataGridView gridCliente = sender as DataGridView;

            var id = int.TryParse(txtCodigo.Text, out int _id) ? _id : 0;

            var repositorio = new ClienteRepositorio();

            repositorio.Apagar(id);

            BuscarTodosClientes(repositorio);
            LimparCamposCadastro();
        }
    }

    private void btnCadastroClienteSair_Click(object sender, EventArgs e)
    {
        LimparCamposCadastro();
        this.Close();
    }

    private void txtTelefone_Leave(object sender, EventArgs e)
    {
        if (!Utilitarios.ValidarTelefone(txtTelefone.Text))
        {
            MessageBox.Show("O telefone deve conter 11 dígitos!");
            txtTelefone.Focus();
        }
    }

    private void txtNome_TextChanged(object sender, EventArgs e)
    {
        Utilitarios.ConverterParaMaiusculas(txtNome);
    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {
        Utilitarios.ConverterParaMaiusculas(txtEmail);
    }

    private void txtEndereco_TextChanged(object sender, EventArgs e)
    {
        Utilitarios.ConverterParaMaiusculas(txtEndereco);
    }
}
