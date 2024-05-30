using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ControleVendas.utilitarios;
public static class Utilitarios
{
    private static HashSet<string> GeradorDeCodigos = new HashSet<string>();
    private static readonly char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

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

    public static string GerarCodigoVendas(int length = 9)
    {
        string code;
        do
        {
            code = GerarCodigo(length);
        } while (GeradorDeCodigos.Contains(code));

        GeradorDeCodigos.Add(code);
        return code;
    }

    private static string GerarCodigo(int length)
    {
        byte[] buffer = Guid.NewGuid().ToByteArray();
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(buffer);
        }

        StringBuilder result = new StringBuilder(length);
        ulong number = BitConverter.ToUInt64(buffer, 0);

        for (int i = 0; i < length; i++)
        {
            result.Append(chars[number % (ulong)chars.Length]);
            number /= (ulong)chars.Length;
        }

        return result.ToString();
    }
}
