using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace WinFormsApp1
{
    class Banco
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;


        public static void conectar()

        {
            // Define a string de conexão
            string connectionString = "server=localhost;uid=root;pwd=123456;";

            // Conecta ao servidor MySQL
            Conexao = new MySqlConnection(connectionString);
            Conexao.Open();

            // Cria o banco de dados se não existir
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS gragas_solutions;", Conexao);
            Comando.ExecuteNonQuery();

            // Usa o banco de dados criado
            Comando = new MySqlCommand("USE gragas_solutions;", Conexao);
            Comando.ExecuteNonQuery();

            // Cria a tabela quantidadeitens se não existir
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS quantidadeitens (
            id INT PRIMARY KEY,
            processador INT NOT NULL DEFAULT 0,
            memoriasflash INT NOT NULL DEFAULT 0,
            cristaisdeclock INT NOT NULL DEFAULT 0,
            displayparaohm INT NOT NULL DEFAULT 0,
            soquetesdoprocessador INT NOT NULL DEFAULT 0,
            dissipadoresdecalor INT NOT NULL DEFAULT 0,
            fontedealimentacao INT NOT NULL DEFAULT 0
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";

            Comando = new MySqlCommand(createTableQuery, Conexao);
            Comando.ExecuteNonQuery();

            // Insere um registro na tabela quantidadeitens
            string insertQuery = "INSERT INTO quantidadeitens (id) VALUES (1) " +
                                 "ON DUPLICATE KEY UPDATE id=id;";
            Comando = new MySqlCommand(insertQuery, Conexao);
            Comando.ExecuteNonQuery();

            // Fecha a conexão
            Conexao.Close();
        }


            //metodos para pegar valores do banco de dados e armazenar em uma variavel
            public static int PegarValorProcessador(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Processador FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            Comando = new MySqlCommand("USE itens; UPDATE quantidadeitens SET processador = 25 WHERE id = 1;", Conexao);
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorMemoriasFlash(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT memoriasflash FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorCristaisDeClock(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT cristaisdeclock FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorDisplayParaIHM(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Displayparaohm FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorSoquetesDoProcessador(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Soquetesdoprocessador FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorDissipadoresDeCalor(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Dissipadoresdecalor FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorFonteDeAlimentacao(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=gragas_solutions");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Fontedealimentacao FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }





    }
}
