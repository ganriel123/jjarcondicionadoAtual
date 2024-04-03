using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace JJ_ArCondicionado_Jailton
{


    public partial class Agendamentos : Window
    {
        public MySqlConnection conexao;
        public MySqlConnection GetConexao;
        

        public Agendamentos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            // Cria uma nova instância da janela Gerenciamento
            Gerenciamento gerenciamentoWindow = new Gerenciamento();

            // Mostra a janela Gerenciamento
            gerenciamentoWindow.Show();

            // Fecha a janela atual (Agendamentos)
            this.Close();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            // String de conexão com o banco de dados
            string connectionString = "Server=localhost;Database=dbJJArcondicionado;Uid=gabriel;Pwd=p1ctasuncservant;";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string query = "UPDATE Solicitacao SET nome = @nome, Contato = @Contato, email = @email, TipodeServico = @TipodeServico, endereco = @endereco, cep = @cep, municipio = @municipio, DataAgendamento = @DataAgendamento WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query);

                cmd.Parameters.AddWithValue("@id", int.Parse(txtCodigo.Text));
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Contato", TxtContato.Text);
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@TipodeServico", TxtTipoServico.Text);
                cmd.Parameters.AddWithValue("@endereco", TxtEndereco.Text);
                cmd.Parameters.AddWithValue("@cep", TxtCep.Text);
                cmd.Parameters.AddWithValue("@municipio", TxtMunicipio.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Atualizado com sucesso!");

                LimpezaCli();
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimpezaCli();
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            using (var conexao = new MySqlConnection())
            {
                string query = "DELETE FROM solicitacao WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtCodigo.Text));

                conexao.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show(" Seu Cliente foi excluído com sucesso!");

                LimpezaCli();
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            using (var conexao = new MySqlConnection())
            {
                conexao.Open();

                
                using (var comando = new MySqlCommand("INSERT INTO Solicitacao (nome, Contato, email, TipodeServico, endereco, cep, municipio, DataAgendamento) " +
                    "VALUES (@nome, @Contato, @email, @TipodeServico, @endereco, @cep, @municipio, @DataAgendamento)"))
                {
                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@Contato", TxtContato.Text);
                    comando.Parameters.AddWithValue("@email", TxtEmail.Text);
                    comando.Parameters.AddWithValue("@TipodeServico", TxtTipoServico.Text);
                    comando.Parameters.AddWithValue("@endereco", TxtEndereco.Text);
                    comando.Parameters.AddWithValue("@DataAgendamento", TxtAgendamento.Text);
                    comando.Parameters.AddWithValue("@cep", TxtCep.Text);
                    comando.Parameters.AddWithValue("@municipio", TxtMunicipio);
          
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Funcionario Cadastrado com sucesso!");

                    LimpezaCli();
                }

            }
        }
        public void LimpezaCli()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            TxtAgendamento.Clear();
            TxtCep.Clear();
            TxtContato.Clear();
            TxtEndereco.Clear();
            TxtMunicipio.Clear();
            TxtTipoServico.Clear();
            TxtEmail.Clear();
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtMunicipio_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEndereco_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtCep_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtTipoServico_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtContato_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAgendamento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
