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

}
