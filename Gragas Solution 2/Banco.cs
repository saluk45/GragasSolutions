using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;");
            Conexao.Open();
            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS itens; use itens", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS quantidadeitens " +
            "( id INT AUTO_INCREMENT PRIMARY KEY, " +
            "processador INT NOT NULL DEFAULT 1," +
            "memoriasflash INT NOT NULL DEFAULT 0," +
            "cristaisdeclock INT NOT NULL DEFAULT 0," +
            "displayparaohm INT NOT NULL DEFAULT 0," +
            "soquetesdoprocessador INT NOT NULL DEFAULT 0," +
            "dissipadoresdecalor INT NOT NULL DEFAULT 0," +
            "fontedealimentacao INT NOT NULL DEFAULT 0)", Conexao);


            Comando.ExecuteNonQuery();


            Conexao.Close();
        }

        public static int PegarValorProcessador(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Processador FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            Comando = new MySqlCommand("USE itens; UPDATE quantidadeitens SET processador = 25 WHERE id = 1;", Conexao);
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorMemoriasFlash(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT memoriasflash FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorCristaisDeClock(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT cristaisdeclock FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorDisplayParaIHM(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Displayparaohm FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorSoquetesDoProcessador(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Soquetesdoprocessador FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorDissipadoresDeCalor(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Dissipadoresdecalor FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }

        public static int PegarValorFonteDeAlimentacao(int x)
        {

            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=itens");
            Conexao.Open();


            Comando = new MySqlCommand("SELECT Fontedealimentacao FROM quantidadeitens WHERE id = 1;", Conexao);
            x = Convert.ToInt32(Comando.ExecuteScalar()); // Obter e converter valor
            //MessageBox.Show("" + x);


            return x;
        }





    }
}
