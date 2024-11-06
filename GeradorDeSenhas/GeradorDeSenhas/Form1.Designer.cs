namespace GeradorDeSenhas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtComprimento = new TextBox();
            checkMaiusculas = new CheckBox();
            checkMinusculas = new CheckBox();
            checkNumeros = new CheckBox();
            checkEspeciais = new CheckBox();
            btnGerar = new Button();
            lblSenha = new Label();
            btnCopiar = new Button();
            SuspendLayout();
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(40, 42);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.PlaceholderText = "Comprimento da Senha";
            txtComprimento.Size = new Size(259, 27);
            txtComprimento.TabIndex = 0;
            // 
            // checkMaiusculas
            // 
            checkMaiusculas.AutoSize = true;
            checkMaiusculas.Location = new Point(40, 88);
            checkMaiusculas.Name = "checkMaiusculas";
            checkMaiusculas.Size = new Size(190, 24);
            checkMaiusculas.TabIndex = 1;
            checkMaiusculas.Text = "Incluir Letras Maiúsculas";
            checkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // checkMinusculas
            // 
            checkMinusculas.AutoSize = true;
            checkMinusculas.Location = new Point(40, 130);
            checkMinusculas.Name = "checkMinusculas";
            checkMinusculas.Size = new Size(190, 24);
            checkMinusculas.TabIndex = 2;
            checkMinusculas.Text = "Incluir Letras Minúsculas";
            checkMinusculas.UseVisualStyleBackColor = true;
            // 
            // checkNumeros
            // 
            checkNumeros.AutoSize = true;
            checkNumeros.Location = new Point(40, 169);
            checkNumeros.Name = "checkNumeros";
            checkNumeros.Size = new Size(135, 24);
            checkNumeros.TabIndex = 3;
            checkNumeros.Text = "Incluir Números";
            checkNumeros.UseVisualStyleBackColor = true;
            // 
            // checkEspeciais
            // 
            checkEspeciais.AutoSize = true;
            checkEspeciais.Location = new Point(40, 208);
            checkEspeciais.Name = "checkEspeciais";
            checkEspeciais.Size = new Size(208, 24);
            checkEspeciais.TabIndex = 4;
            checkEspeciais.Text = "Incluir Caracteres Especiais";
            checkEspeciais.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(33, 316);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(120, 29);
            btnGerar.TabIndex = 5;
            btnGerar.Text = "Gerar Senha";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(33, 258);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(215, 20);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "\"Senha gerada aparecerá aqui\"";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(190, 316);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(94, 29);
            btnCopiar.TabIndex = 7;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 462);
            Controls.Add(btnCopiar);
            Controls.Add(lblSenha);
            Controls.Add(btnGerar);
            Controls.Add(checkEspeciais);
            Controls.Add(checkNumeros);
            Controls.Add(checkMinusculas);
            Controls.Add(checkMaiusculas);
            Controls.Add(txtComprimento);
            Name = "Form1";
            Text = "Gerador de Senhas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtComprimento;
        private CheckBox checkMaiusculas;
        private CheckBox checkMinusculas;
        private CheckBox checkNumeros;
        private CheckBox checkEspeciais;
        private Button btnGerar;
        private Label lblSenha;
        private Button btnCopiar;
    }
}
