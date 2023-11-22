using System.Windows;

namespace AccountFanSys.MVM.View;

public partial class NewRegisterView : Window
{
    public NewRegisterView()
    {
        InitializeComponent();
    }
    
    private void TemptRecords_OnClick(object sender, RoutedEventArgs e)
    {
        // Crea una instancia de la nueva ventana a la que deseas redirigir
        TempRecordsView ventanaRegistro = new TempRecordsView();

        // Muestra la nueva ventana
        ventanaRegistro.Show();

        // Cierra la ventana actual
        this.Close();
    }
    
    private void NuevaVentaButton_Click(object sender, RoutedEventArgs e)
    {
        // Crea una nueva instancia de la ventana
        NuevaVenta nuevaVenta = new NuevaVenta();

        // Muestra la ventana
        nuevaVenta.ShowDialog();
        
        // Cierra la ventana actual
        this.Close();
    }
}