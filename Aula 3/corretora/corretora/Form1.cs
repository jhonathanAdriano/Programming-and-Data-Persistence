using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace corretora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Crio a estrutura da conexão com o banco e passa os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "corretora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco
                //MessageBox.Show("Conexão Aberta!");

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "INSERT INTO segurado (nomeSegurado,cidadeSegurado,anoNascimentoSegurado) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxCidade.Text + "', '" + textBoxAnoNascimento.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Inserido com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                textBoxNome.Text = "";
                textBoxCidade.Text = "";
                textBoxAnoNascimento.Text = "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }
            private void Form1_Load(object sender, EventArgs e)
            {
                atualizarGrid();
            }

            private void atualizarGrid()
            {
            //Crio a estrutura da conexão com o banco e passa os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "corretora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * from segurado"; //Traz todo mundo da tabela segurado
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewSegurado.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewSegurado.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//CIDADE
                    row.Cells[3].Value = reader.GetString(3);//ANO NASCIMENTO
                    dataGridViewSegurado.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }
                realizaConexacoBD.Close();
                //MessageBox.Show("Removido com sucesso"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

    }
}
