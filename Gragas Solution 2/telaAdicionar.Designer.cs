namespace Gragas_Solution_2
{
    partial class telaAdicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botaoAdicionarEstoque = new System.Windows.Forms.Button();
            this.TextoCaixaItens = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // caixa do adicionar
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(483, 285);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // botaoAdicionarEstoque
            // 
            this.botaoAdicionarEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoAdicionarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionarEstoque.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionarEstoque.Location = new System.Drawing.Point(421, 377);
            this.botaoAdicionarEstoque.Name = "botaoAdicionarEstoque";
            this.botaoAdicionarEstoque.Size = new System.Drawing.Size(317, 76);
            this.botaoAdicionarEstoque.TabIndex = 6;
            this.botaoAdicionarEstoque.Text = "Adicionar ao Estoque";
            this.botaoAdicionarEstoque.UseVisualStyleBackColor = true;
            this.botaoAdicionarEstoque.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // TextoCaixaItens
            // 
            this.TextoCaixaItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextoCaixaItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCaixaItens.FormattingEnabled = true;
            this.TextoCaixaItens.ItemHeight = 24;
            this.TextoCaixaItens.Items.AddRange(new object[] {
            "Processadores",
            "Memorias Flash",
            "Cristais de Clock",
            "Display para IHM",
            "Soquetes de Processador",
            "Dissipador de Calor",
            "Fonte de Alimentação"});
            this.TextoCaixaItens.Location = new System.Drawing.Point(641, 114);
            this.TextoCaixaItens.Name = "TextoCaixaItens";
            this.TextoCaixaItens.Size = new System.Drawing.Size(227, 28);
            this.TextoCaixaItens.TabIndex = 7;
            this.TextoCaixaItens.SelectedIndexChanged += new System.EventHandler(this.TextoCaixaItens_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextoCaixaItens);
            this.Controls.Add(this.botaoAdicionarEstoque);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaAdicionar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botaoAdicionarEstoque;
        private System.Windows.Forms.ListBox TextoCaixaItens;
        private System.Windows.Forms.Button button1;
    }
}