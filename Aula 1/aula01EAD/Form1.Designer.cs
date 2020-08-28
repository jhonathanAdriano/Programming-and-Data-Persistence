namespace aula01EAD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoma = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(22, 65);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(24, 26);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(22, 28);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(180, 20);
            this.tbTexto.TabIndex = 1;
            // 
            // tbResultado
            // 
            this.tbResultado.Enabled = false;
            this.tbResultado.Location = new System.Drawing.Point(86, 104);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(107, 20);
            this.tbResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(52, 65);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(24, 26);
            this.btnSubtracao.TabIndex = 5;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(82, 65);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(24, 26);
            this.btnDivisao.TabIndex = 6;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.btnSoma);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button button1;
    }
}

