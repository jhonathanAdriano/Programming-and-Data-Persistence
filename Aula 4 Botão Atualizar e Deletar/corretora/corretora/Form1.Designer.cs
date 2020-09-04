namespace corretora
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnoNascimento = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewSegurado = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSegurado)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ano Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome:";
            // 
            // textBoxAnoNascimento
            // 
            this.textBoxAnoNascimento.Location = new System.Drawing.Point(650, 27);
            this.textBoxAnoNascimento.Name = "textBoxAnoNascimento";
            this.textBoxAnoNascimento.Size = new System.Drawing.Size(99, 20);
            this.textBoxAnoNascimento.TabIndex = 10;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(393, 27);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(251, 20);
            this.textBoxCidade.TabIndex = 9;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(58, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(327, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSalvar.Location = new System.Drawing.Point(650, 113);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(98, 45);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridViewSegurado
            // 
            this.dataGridViewSegurado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSegurado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSegurado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnCidade,
            this.ColumnAnoNascimento});
            this.dataGridViewSegurado.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewSegurado.Name = "dataGridViewSegurado";
            this.dataGridViewSegurado.Size = new System.Drawing.Size(629, 238);
            this.dataGridViewSegurado.TabIndex = 14;
            this.dataGridViewSegurado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSegurado_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 30;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 250;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.Width = 200;
            // 
            // ColumnAnoNascimento
            // 
            this.ColumnAnoNascimento.HeaderText = "Ano Nascimento";
            this.ColumnAnoNascimento.Name = "ColumnAnoNascimento";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.Red;
            this.buttonExcluir.Location = new System.Drawing.Point(650, 244);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 48);
            this.buttonExcluir.TabIndex = 16;
            this.buttonExcluir.Text = "EXCLUIR \r\nITEM\r\n";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonLimpar.Location = new System.Drawing.Point(650, 180);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(98, 42);
            this.buttonLimpar.TabIndex = 15;
            this.buttonLimpar.Text = "LIMPAR\r\nTABELA";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonNovo.Location = new System.Drawing.Point(650, 54);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(100, 43);
            this.buttonNovo.TabIndex = 17;
            this.buttonNovo.Text = "INSERIR \r\nNOVO\r\n";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(15, 27);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(35, 20);
            this.textBoxId.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(768, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.dataGridViewSegurado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnoNascimento);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Cadastro Segurado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSegurado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnoNascimento;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewSegurado;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnoNascimento;
    }
}

