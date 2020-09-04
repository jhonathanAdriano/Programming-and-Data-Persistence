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
            
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "corretora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); 
                

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); 
                comandoMySql.CommandText = "INSERT INTO segurado (nomeSegurado,cidadeSegurado,anoNascimentoSegurado) " +
                    "VALUES('" + textBoxNome.Text + "', '" + textBoxCidade.Text + "', '" + textBoxAnoNascimento.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); 
                MessageBox.Show("Inserido com sucesso"); 
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "corretora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * from segurado WHERE ativoSegurado = 0"; 
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewSegurado.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewSegurado.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    dataGridViewSegurado.Rows.Add(row);
                }
                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }


        }

        private void dataGridViewSegurado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSegurado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewSegurado.CurrentRow.Selected = true;
                
                textBoxNome.Text = dataGridViewSegurado.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                textBoxCidade.Text = dataGridViewSegurado.Rows[e.RowIndex].Cells["ColumnCidade"].FormattedValue.ToString();
                textBoxAnoNascimento.Text = dataGridViewSegurado.Rows[e.RowIndex].Cells["ColumnAnoNascimento"].FormattedValue.ToString();
                textBoxId.Text = dataGridViewSegurado.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            textBoxId.Clear();
            textBoxNome.Clear();
            textBoxCidade.Clear();
            textBoxAnoNascimento.Clear();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "corretora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); 

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); 
                comandoMySql.CommandText = "UPDATE segurado SET ativoSegurado = 1 WHERE idSegurado = " + textBoxId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); 
                MessageBox.Show("Deletado com sucesso"); 
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "corretora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); 

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); 
                comandoMySql.CommandText = "UPDATE segurado SET nomeSegurado = '" + textBoxNome.Text + "', " +
                    "cidadeSegurado = '" + textBoxCidade.Text + "', " +
                    "AnoNascimentoSegurado = '" + textBoxAnoNascimento.Text + "' WHERE idSegurado = " + textBoxId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); 
                MessageBox.Show("Atualizado com sucesso"); 
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}