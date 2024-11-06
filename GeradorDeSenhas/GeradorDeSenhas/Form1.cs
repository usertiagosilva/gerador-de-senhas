namespace GeradorDeSenhas
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string GerarSenha(int comprimento, bool incluirMaiusculas, bool incluirMinusculas, bool incluirNumeros, bool incluirEspeciais)
        {
            const string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string numeros = "0123456789";
            const string especiais = "!@#$%^&*()_+[]{}|;:,.<>?";

            StringBuilder caracteresPermitidos = new StringBuilder();

            if (incluirMaiusculas) caracteresPermitidos.Append(letrasMaiusculas);
            if (incluirMinusculas) caracteresPermitidos.Append(letrasMinusculas);
            if (incluirNumeros) caracteresPermitidos.Append(numeros);
            if (incluirEspeciais) caracteresPermitidos.Append(especiais);

            if (caracteresPermitidos.Length == 0)
                throw new InvalidOperationException("Pelo menos um tipo de caractere deve ser selecionado.");

            Random random = new Random();
            char[] senha = new char[comprimento];

            for (int i = 0; i < comprimento; i++)
            {
                senha[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(senha);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int comprimento;
            if (int.TryParse(txtComprimento.Text, out comprimento) && comprimento > 0)
            {
                try
                {
                    string senhaGerada = GerarSenha(comprimento, checkMaiusculas.Checked, checkMinusculas.Checked, checkNumeros.Checked, checkEspeciais.Checked);
                    lblSenha.Text = senhaGerada;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um comprimento válido para a senha.");
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblSenha.Text))
            {
                Clipboard.SetText(lblSenha.Text);
                MessageBox.Show("Senha copiada para a área de transferência!");
            }
            else
            {
                MessageBox.Show("Nenhuma senha gerada para copiar.");
            }
        }
    }
}

