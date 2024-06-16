using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Gragas_Solution_2
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exibe a Tela Adicionar
            telaAdicionar mostrarTela = new telaAdicionar();
            //funcao que conecta ao banco de dados itens
            Banco.conectar(); 

            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaRemover mostrarTela = new telaRemover();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private void labelProcessadores_Click(object sender, EventArgs e)
        {

        }

        private void labelMemóriasflash_Click(object sender, EventArgs e)
        {

        }

        private void labelCristaisdeclock_Click(object sender, EventArgs e)
        {

        }

        private void labelSoquetesdoprocessador_Click(object sender, EventArgs e)
        {

        }

        private void labelDissipadoresdecalor_Click(object sender, EventArgs e)
        {

        }
        private void labelFontedealimentação_Click(object sender, EventArgs e)
        {

        }
    }
}
