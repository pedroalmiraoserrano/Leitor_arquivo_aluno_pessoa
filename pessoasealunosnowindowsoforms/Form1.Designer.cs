namespace pessoasealunosnowindowsoforms
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
            arquivo = new OpenFileDialog();
            botao = new Button();
            texto = new Label();
            SuspendLayout();
            // 
            // arquivo
            // 
            arquivo.FileName = "openFileDialog1";
            // 
            // botao
            // 
            botao.Location = new Point(44, 212);
            botao.Name = "botao";
            botao.Size = new Size(187, 23);
            botao.TabIndex = 0;
            botao.Text = "Inserir arquivo";
            botao.TextAlign = ContentAlignment.BottomCenter;
            botao.UseVisualStyleBackColor = true;
            botao.Click += botao_Click;
            // 
            // texto
            // 
            texto.AutoSize = true;
            texto.Location = new Point(114, 90);
            texto.Name = "texto";
            texto.Size = new Size(0, 15);
            texto.TabIndex = 1;
            texto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 271);
            Controls.Add(texto);
            Controls.Add(botao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog arquivo;
        private Button botao;
        private Label texto;
    }
}