using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JJ_ArCondicionado_Jailton
{
    /// <summary>
    /// Lógica interna para RegistrarHospedagem.xaml
    /// </summary>
    public partial class RegistrarHospedagem : Window
    {
        public RegistrarHospedagem()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtDominio_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNomeBanco_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUsuarioBanco_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSenhaUsuBanco_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
