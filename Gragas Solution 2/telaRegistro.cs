using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gragas_Solution_2
{
    public partial class telaRegistro : Form
    {
        public telaRegistro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void telaRegistro_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            // Exibe a Tela Adicionar
            telaLogin mostrarTela = new telaLogin();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }




        private void botaoRegistrar_Click(object sender, EventArgs e)
        {
            string nome = textoNome.Text;
            string login = textoLogin.Text;
            string senha = textoSenha.Text;


            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string connectionString = "server=localhost;database=gragas_solutions;user=root;password=123456";

            using (MySqlConnection Conexao = new MySqlConnection(connectionString))
            {
                Conexao.Open();
                string query = "INSERT INTO usuarios (nome,login,senha) VALUES (@nome,@login, @senha)";
                using (MySqlCommand command = new MySqlCommand(query, Conexao))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@senha", senha);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cadastro realizado com sucesso!");
        }
    }


}

        
    

