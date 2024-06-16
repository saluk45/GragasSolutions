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
    public partial class telaRemover : Form
    {
        public telaRemover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaPrincipal mostrarTela = new telaPrincipal();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }

        private void botaoAdicionarEstoque_Click(object sender, EventArgs e)
        {

            int ValorRemover = int.Parse(textBox1.Text);                                                                 //Valor inserido na caixa transformado em int e depois na variavel

            if (listBox1.SelectedItem.ToString() == "Processadores")                                                     //testa se essa e a opcao escolhida
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";                         //passa o endereco para conectar ao banco
                using (MySqlConnection conexao = new MySqlConnection(connectionString))                                  //instancia a conexao
                {
                    conexao.Open();                                                                                      //abre a conexao
                    string query = "UPDATE quantidadeitens SET processador = processador - @ValorRemover WHERE id = 1;"; //subtrai o valor da variavel no item da tabela
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))                                      //using fecha a conexao ao final do bloco
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);                                  //transforma a variavel, em um parametro que o sql entenda
                        comando.ExecuteNonQuery();                                                                       //usado pra comando que nao retorna nada
                    }
                }

                MessageBox.Show("Itens removidos do estoque");
            }

            if (listBox1.SelectedItem.ToString() == "Memorias Flash")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET memoriasflash = memoriasflash - @ValorRemover WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens removidos do estoque");

            }

            if (listBox1.SelectedItem.ToString() == "Cristais de Clock")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET cristaisdeclock = cristaisdeclock - @ValorRemover WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens removidos do estoque");

            }

            if (listBox1.SelectedItem.ToString() == "Display para IHM")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Displayparaohm = Displayparaohm - @ValorRemover WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens removidos do estoque");

            }
            if (listBox1.SelectedItem.ToString() == "Soquetes de Processador")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Soquetesdoprocessador = Soquetesdoprocessador - @ValorRemover WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens removidos do estoque");

            }
            if (listBox1.SelectedItem.ToString() == "Dissipador de Calor")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Dissipadoresdecalor = Dissipadoresdecalor - @ValorRemover WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens removidos do estoque");

            }

            if (listBox1.SelectedItem.ToString() == "Fonte de Alimentação")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=itens";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Fontedealimentacao = Fontedealimentacao - @ValorRemover WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorRemover", ValorRemover);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens removidos do estoque");

            }
        }

        private void telaRemover_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
