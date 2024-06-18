using Google.Protobuf.WellKnownTypes;
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
    public partial class telaAdicionar : Form
    {
        public telaAdicionar()
        {
            InitializeComponent();
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            
            int ValorAdd = int.Parse(textBox1.Text);                                                                 //Valor inserido na caixa transformado em int e depois na variavel
        
            if (TextoCaixaItens.SelectedItem.ToString() == "Processadores")                                          //testa se essa e a opcao escolhida
            { string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";            //passa o endereco para conectar ao banco
                using (MySqlConnection conexao = new MySqlConnection(connectionString))                              //instancia a conexao
                {
                    conexao.Open();                                                                                  //abre a conexao
                    string query = "UPDATE quantidadeitens SET processador = processador + @ValorAdd WHERE id = 1;"; //Acrecenta o valor da variavel no item da tabela
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))                                  //using fecha a conexao ao final do bloco
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);                                      //transforma a variavel, em um parametro que o sql entenda
                        comando.ExecuteNonQuery();                                                                   //usado pra comando que nao retorna nada
                    }
                }

                MessageBox.Show("Itens adicionados ao estoque");
            } 

            if (TextoCaixaItens.SelectedItem.ToString() == "Memorias Flash")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET memoriasflash = memoriasflash + @ValorAdd WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens adicionados ao estoque");

            }

            if (TextoCaixaItens.SelectedItem.ToString() == "Cristais de Clock")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET cristaisdeclock = cristaisdeclock + @ValorAdd WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens adicionados ao estoque");

            }

            if (TextoCaixaItens.SelectedItem.ToString() == "Display para IHM")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Displayparaohm = Displayparaohm + @ValorAdd WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens adicionados ao estoque");

            }
            if (TextoCaixaItens.SelectedItem.ToString() == "Soquetes de Processador")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Soquetesdoprocessador = Soquetesdoprocessador + @ValorAdd WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens adicionados ao estoque");

            }
            if (TextoCaixaItens.SelectedItem.ToString() == "Dissipador de Calor")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Dissipadoresdecalor = Dissipadoresdecalor + @ValorAdd WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens adicionados ao estoque");

            }

            if (TextoCaixaItens.SelectedItem.ToString() == "Fonte de Alimentação")
            {
                string connectionString = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string query = "UPDATE quantidadeitens SET Fontedealimentacao = Fontedealimentacao + @ValorAdd WHERE id = 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@ValorAdd", ValorAdd);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Itens adicionados ao estoque");

            }
        }


        private void telaAdicionar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifica se a tecla pressionada não é um dígito (número) nem o backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Se a tecla pressionada não for um dígito, cancela o evento
                e.Handled = true;
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe a Tela Adicionar
            telaPrincipal mostrarTela = new telaPrincipal();
            mostrarTela.Show();

            // Esconde a Tela Atual
            this.Hide();
        }

        private void TextoCaixaItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
