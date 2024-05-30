using System.Globalization;
using System.Text.RegularExpressions;

namespace ControleVendas.utilitarios;
public static class Utilitarios
{
    public static void ConverterParaMaiusculas(TextBox textBox)
    {
        string textoDigitado = textBox.Text;

        string textoEmMaiusculas = textoDigitado.ToUpper();

        textBox.Text = textoEmMaiusculas;

        textBox.SelectionStart = textBox.TextLength;
    }

    public static bool ValidarTelefone(string telefone)
    {
        return telefone.Replace(" ", "").Length == 14;
    }

    public static void FormatarCPF(TextBox txtCPF)
    {
        string cpf = txtCPF.Text;

        cpf = Regex.Replace(cpf, @"[^\d]", "");

        if (cpf.Length > 3)
        {
            cpf = cpf.Insert(3, ".");
        }
        if (cpf.Length > 7)
        {
            cpf = cpf.Insert(7, ".");
        }
        if (cpf.Length > 11)
        {
            cpf = cpf.Insert(11, "-");
        }

        txtCPF.Text = cpf;

        txtCPF.SelectionStart = cpf.Length;

        txtCPF.SelectionLength = 0;
    }
}
