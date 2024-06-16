﻿using Gragas_Solution_2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gragas_Solution_2
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void telaLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            var strConexao = "server=localhost;uid=root;pwd=123456;database=gragas_solutions";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }



        private async void botaoLogin_Click(object sender, EventArgs e)
        {
            string login = textoLogin.Text;
            string senha = textoSenha.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string connectionString = "server=localhost;database=gragas_solutions;user=root;password=123456";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE login=@login AND senha=@senha";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {

                        MessageBox.Show("Login realizado com sucesso!");
                        // Lógica para liberar o acesso

                        // Exibe a Tela Adicionar
                        telaPrincipal mostrarTela = new telaPrincipal();
                        mostrarTela.Show();

                        // Esconde a Tela Atual
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Login ou senha incorretos.");
                    }
                }
            }
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            telaRegistro secondForm = new telaRegistro();
            secondForm.Show();



            // Esconde a LoginForm
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telaRegistro secondForm = new telaRegistro();
            secondForm.Show();



            // Esconde a LoginForm
            this.Hide();
        }




    }
}

    




        