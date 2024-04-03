using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JJ_ArCondicionado_Jailton
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSenha_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Obtenha o e-mail e a senha dos campos de entrada
                string email = txtUsuario.Text;
                string senha = txtSenha.Text;

                using (var conexao = new Conexão())
                {
                    conexao.AbrirConexao();

                    // Verificar na tabela Usuarios
                    using (var comando = new MySqlCommand("SELECT * FROM Usuario WHERE Email = @Email AND Senha = @Senha", conexao.GetConexao()))
                    {
                        comando.Parameters.AddWithValue("@Email", email);
                        comando.Parameters.AddWithValue("@Senha", senha);

                        using (var leitor = comando.ExecuteReader())
                        {
                            if (leitor.HasRows)
                            {
                                // Se as credenciais estiverem corretas, navega para a próxima página
                                Gerenciamento painel = new Gerenciamento();
                                NavigationWindow window = new NavigationWindow();
                                window.Content = painel;
                                window.Show();
                                this.Close(); // Fecha a janela de login
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha inválidos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar as credenciais: " + ex.Message);
            }
        }
        
        private void PainelLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            // Fecha a aplicação
            Application.Current.Shutdown();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            // Cria uma instância da página Cadastro.xaml
            Cadastro cadastroPage = new Cadastro();

            // Define a página Cadastro.xaml como conteúdo da MainWindow
            Application.Current.MainWindow.Content = cadastroPage;
        }

        private void txtSenha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
   
}
