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
        
        // Bloquear la interacción con la ventana principal
        this.IsEnabled = false;

        // Suscribir al evento Closed para desbloquear la interacción cuando la nueva ventana se cierre
        ventanaRegistro.Closed += (s, args) => { this.IsEnabled = true; };

        // Muestra la nueva ventana
        ventanaRegistro.Show();

    }
    
    private void NuevaVentaButton_Click(object sender, RoutedEventArgs e)
    {
        // Crea una nueva instancia de la ventana
        NuevaVenta nuevaVenta = new NuevaVenta();
        
        // Bloquear la interacción con la ventana principal
        this.IsEnabled = false;

        // Suscribir al evento Closed para desbloquear la interacción cuando la nueva ventana se cierre
        nuevaVenta.Closed += (s, args) => { this.IsEnabled = true; };

        // Muestra la ventana
        nuevaVenta.Show();
        
        // Cierra la ventana actual
        this.Close();
    }
    
    
    private void Cancelar_Click(object sender, RoutedEventArgs e)
    {
        // Cierra la ventana actual
        this.Close();
    }
}