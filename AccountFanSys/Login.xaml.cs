using System.Windows;

namespace AccountFanSys;

public partial class Login : Window
{
    public Login()
    {
        InitializeComponent();
    }

    private void IniciarSesion_Click(object sender, RoutedEventArgs e)
    {
        MainWindow inicio = new MainWindow();
        inicio.Show();
        this.Close();
    }
}