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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfazDeUnRestaurante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AccesoLogin login = new AccesoLogin();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string usernamevalido = " admin";
            string passwordvalido = "nimda";

            if (login.Check (usernamevalido, passwordvalido))

            {
                // SalidaLabel.Content = "Usuario logeado";
                // MessageBox.Show("EXITO!!", "Usuario Logeado");

                VentanaInicio ventanainicio = new VentanaInicio();
                ventanainicio.Show();
                this.Close();
            }
            else
            {
                //MessageBox.Show("Error de Login ", "Usuario o Password incorrectos");
                SalidaLabel.Content = "Usuario o Password incorrectos";
            }
        }
        
    }
    
}
