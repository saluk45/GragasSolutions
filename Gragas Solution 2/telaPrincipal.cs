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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        public static int FonteAlimentacaoMetodo()                                                                      //Metodo de criação da variavel, e puxando do banco de dados
        {
            int FontedealimentaçãoQnt = 0;                                                                              // variavel que armazena a quantidade de itens no estoque
            FontedealimentaçãoQnt = Banco.PegarValorFonteDeAlimentacao(FontedealimentaçãoQnt);                          // metodo para pegar o valor do banco e atribuir a variavel
            return FontedealimentaçãoQnt;
        }

        public void RetornoTextoFonteAlimentacao()                                                                      //Metodo com a logica do alarme e implementação do texto no label
        {
            if (FonteAlimentacaoMetodo() >= 30)
            { this.labelFontedealimentação.Text = "Fonte de alimentação: " + FonteAlimentacaoMetodo(); }
            else { this.labelFontedealimentação.Text = "Fonte de alimentação: " + FonteAlimentacaoMetodo() + " ⚠"; }
            
        }



        public static int CristaisdeClockMetodo()
        {
            int CristaisdeclockQnt = 0;
            CristaisdeclockQnt = Banco.PegarValorCristaisDeClock(CristaisdeclockQnt);
            return CristaisdeclockQnt;
        }

        public void RetornoTextoCristaisdeClock()
        {
            if (CristaisdeClockMetodo() >= 30)
            { this.labelCristaisdeclock.Text = "Cristais de clock:" + CristaisdeClockMetodo(); }
            else { this.labelCristaisdeclock.Text = "Cristais de clock:" + CristaisdeClockMetodo() + " ⚠"; }

        }


        public static int ProcessadorMetodo()
        {
            int ProcessadorQnt = 0;
            ProcessadorQnt = Banco.PegarValorProcessador(ProcessadorQnt);
            return ProcessadorQnt;
        }

        public void ProcessadorRetornoTexto()
        {
            if (ProcessadorMetodo() >= 30)
            { this.labelProcessadores.Text = "Processadores: " + ProcessadorMetodo(); }
            else { this.labelProcessadores.Text = "Processadores: " + ProcessadorMetodo() + " ⚠"; }
        }


        public static int MemoriasflashMetodo()
        {
            int MemoriasflashQnt = 0;
            MemoriasflashQnt = Banco.PegarValorMemoriasFlash(MemoriasflashQnt);
            return MemoriasflashQnt;
        }

        public void MemoriasflashRetornoTexto()
        {
            if (MemoriasflashMetodo() >= 60)
            { this.labelMemóriasflash.Text = "Memórias flash: " + MemoriasflashMetodo(); }
            else { this.labelMemóriasflash.Text = "Memórias flash: " + MemoriasflashMetodo() + " ⚠"; }

        }


        public static int SoquetesdoprocessadorMetodo()
        {
            int SoquetesdoprocessadorQnt = 0;
            SoquetesdoprocessadorQnt = Banco.PegarValorSoquetesDoProcessador(SoquetesdoprocessadorQnt);
            return SoquetesdoprocessadorQnt;
        }

        public void RetornoTextoSoquetesdoprocessador()
        {
            if (SoquetesdoprocessadorMetodo() >= 30)
            { this.labelSoquetesdoprocessador.Text = "Soquetes do processador: " + SoquetesdoprocessadorMetodo(); }
            else { this.labelSoquetesdoprocessador.Text = "Soquetes do processador: " + SoquetesdoprocessadorMetodo() + " ⚠"; }

        }


        public static int DisplayparaIHMMetodo()
        {
            int DisplayparaIHMQnt = 0;
            DisplayparaIHMQnt = Banco.PegarValorDisplayParaIHM(DisplayparaIHMQnt);
            return DisplayparaIHMQnt;
        }

        public void RetornoTextoDisplayparaIHM()
        {
            if (DisplayparaIHMMetodo() >= 30) { this.labelDisplayparaIHM.Text = "Display para IHM: " + DisplayparaIHMMetodo(); }
            else { this.labelDisplayparaIHM.Text = "Display para IHM: " + DisplayparaIHMMetodo() + " ⚠"; }

        }


        public static int DissipadoresdecalorMetodo()
        {
            int DissipadoresdecalorQnt = 0;
            DissipadoresdecalorQnt = Banco.PegarValorDissipadoresDeCalor(DissipadoresdecalorQnt);
            return DissipadoresdecalorQnt;
        }

        public void RetornoTextoDissipadoresdecalor()
        {
            if (DissipadoresdecalorMetodo() >= 30)
            { this.labelDissipadoresdecalor.Text = "Dissipadores de calor: " + DissipadoresdecalorMetodo(); }
            else { this.labelDissipadoresdecalor.Text = "Dissipadores de calor: " + DissipadoresdecalorMetodo() + " ⚠"; }

        }
    }
}
