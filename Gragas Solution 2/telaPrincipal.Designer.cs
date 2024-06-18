using WinFormsApp1;

namespace Gragas_Solution_2
{
    partial class telaPrincipal
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
        /// 

       

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.labelFontedealimentação = new System.Windows.Forms.Label();
            this.labelCristaisdeclock = new System.Windows.Forms.Label();
            this.labelProcessadores = new System.Windows.Forms.Label();
            this.labelMemóriasflash = new System.Windows.Forms.Label();
            this.labelSoquetesdoprocessador = new System.Windows.Forms.Label();
            this.labelDisplayparaIHM = new System.Windows.Forms.Label();
            this.labelDissipadoresdecalor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto bem vindo
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo(a) ao Estoque";
            // 
            // Botao remover
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionar.Location = new System.Drawing.Point(266, 526);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(264, 65);
            this.botaoAdicionar.TabIndex = 1;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.button2_Click);




            //Os comandos abaixo exibem na tela principal a quantidade no estoque de cada item

            //labelFontedealimentação
            //int FontedealimentaçãoQnt = 0;                                                                     // variavel que armazena a quantidade de itens no estoque
            //FontedealimentaçãoQnt = Banco.PegarValorFonteDeAlimentacao(FontedealimentaçãoQnt);                 // metodo para pegar o valor do banco e atribuir a variavel
            this.labelFontedealimentação.AutoSize = true;
            this.labelFontedealimentação.Anchor = System.Windows.Forms.AnchorStyles.None;                      // faz com que o objeto fique centralizado quando em tela cheia
            this.labelFontedealimentação.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F,        // fonte e tamanho do label
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFontedealimentação.Location = new System.Drawing.Point(600, 279);                        // localização na pagina
            this.labelFontedealimentação.Name = "labelFontedealimentação";                                     // nome do objeto
            this.labelFontedealimentação.Size = new System.Drawing.Size(387, 42);                              //tamanho do texto
            this.labelFontedealimentação.TabIndex = 8;
            this.labelFontedealimentação.Click += new System.EventHandler(this.labelFontedealimentação_Click); // evento ao clicar

            //Logica do alarme,se a quantidade for menor que 10%, entao sera executado o alerta
            RetornoTextoFonteAlimentacao();


            // labelCristaisdeclock
            
            this.labelCristaisdeclock.AutoSize = true;
            this.labelCristaisdeclock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCristaisdeclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCristaisdeclock.Location = new System.Drawing.Point(187, 279);
            this.labelCristaisdeclock.Name = "labelCristaisdeclock";
            this.labelCristaisdeclock.Size = new System.Drawing.Size(300, 42);
            this.labelCristaisdeclock.TabIndex = 9;
            this.labelCristaisdeclock.Click += new System.EventHandler(this.labelCristaisdeclock_Click);
            RetornoTextoCristaisdeClock();


            // labelProcessadores
           
            this.labelProcessadores.AutoSize = true;
            this.labelProcessadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProcessadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessadores.Location = new System.Drawing.Point(187, 135);
            this.labelProcessadores.Name = "labelProcessadores";
            this.labelProcessadores.Size = new System.Drawing.Size(279, 42);
            this.labelProcessadores.TabIndex = 10;
            this.labelProcessadores.Click += new System.EventHandler(this.labelProcessadores_Click);
            ProcessadorRetornoTexto(); 


            // labelMemóriasflash
            this.labelMemóriasflash.AutoSize = true;
            this.labelMemóriasflash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMemóriasflash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemóriasflash.Location = new System.Drawing.Point(187, 205);
            this.labelMemóriasflash.Name = "labelMemóriasflash";
            this.labelMemóriasflash.Size = new System.Drawing.Size(280, 42);
            this.labelMemóriasflash.TabIndex = 11;
            this.labelMemóriasflash.Click += new System.EventHandler(this.labelMemóriasflash_Click);
            MemoriasflashRetornoTexto();



            // labelSoquetesdoprocessador
            
            this.labelSoquetesdoprocessador.AutoSize = true;
            this.labelSoquetesdoprocessador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSoquetesdoprocessador.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoquetesdoprocessador.Location = new System.Drawing.Point(587, 205);
            this.labelSoquetesdoprocessador.Name = "labelSoquetesdoprocessador";
            this.labelSoquetesdoprocessador.Size = new System.Drawing.Size(466, 42);
            this.labelSoquetesdoprocessador.TabIndex = 12;
            this.labelSoquetesdoprocessador.Click += new System.EventHandler(this.labelSoquetesdoprocessador_Click);
            RetornoTextoSoquetesdoprocessador();


            // labelDisplayparaIHM
           
            this.labelDisplayparaIHM.AutoSize = true;
            this.labelDisplayparaIHM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDisplayparaIHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayparaIHM.Location = new System.Drawing.Point(600, 135);
            this.labelDisplayparaIHM.Name = "labelDisplayparaIHM";
            this.labelDisplayparaIHM.Size = new System.Drawing.Size(311, 42);
            this.labelDisplayparaIHM.TabIndex = 13;
            RetornoTextoDisplayparaIHM();


            // labelDissipadoresdecalor
            
            this.labelDissipadoresdecalor.AutoSize = true;
            this.labelDissipadoresdecalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDissipadoresdecalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDissipadoresdecalor.Location = new System.Drawing.Point(187, 358);
            this.labelDissipadoresdecalor.Name = "labelDissipadoresdecalor";
            this.labelDissipadoresdecalor.Size = new System.Drawing.Size(388, 42);
            this.labelDissipadoresdecalor.TabIndex = 14;
            this.labelDissipadoresdecalor.Click += new System.EventHandler(this.labelDissipadoresdecalor_Click);
            RetornoTextoDissipadoresdecalor();

            // telaPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 648);
            this.Controls.Add(this.labelDissipadoresdecalor);
            this.Controls.Add(this.labelDisplayparaIHM);
            this.Controls.Add(this.labelSoquetesdoprocessador);
            this.Controls.Add(this.labelMemóriasflash);
            this.Controls.Add(this.labelProcessadores);
            this.Controls.Add(this.labelCristaisdeclock);
            this.Controls.Add(this.labelFontedealimentação);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Label labelFontedealimentação;
        private System.Windows.Forms.Label labelCristaisdeclock;
        private System.Windows.Forms.Label labelProcessadores;
        private System.Windows.Forms.Label labelMemóriasflash;
        private System.Windows.Forms.Label labelSoquetesdoprocessador;
        private System.Windows.Forms.Label labelDisplayparaIHM;
        private System.Windows.Forms.Label labelDissipadoresdecalor;
    }
}