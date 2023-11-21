using System.Windows;

namespace AccountFanSys.MVM.View;

public partial class FechaRegistro : Window
{
    public FechaRegistro()
    {
        InitializeComponent();
    }

    private void Save_OnClick(object sender, RoutedEventArgs e)
    {
        // Crea una instancia de la nueva ventana a la que deseas redirigir
        NewRegisterView ventanaRegistro = new NewRegisterView();

        // Muestra la nueva ventana
        ventanaRegistro.Show();

        // Cierra la ventana actual
        this.Close();
    }
}