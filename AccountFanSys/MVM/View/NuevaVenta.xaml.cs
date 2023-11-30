using System.Windows;

namespace AccountFanSys.MVM.View;

public partial class NuevaVenta : Window
{
    
    public NuevaVenta()
    {
        InitializeComponent();
    }
    
    private void Cancelar_Click(object sender, RoutedEventArgs e)
    {
        NewRegisterView paginaAnterior = new NewRegisterView();
        paginaAnterior.Show();
        
        // Cierra la ventana actual
        this.Close();
    }
    
    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        // Cierra la ventana actual
        this.Close();
    }
}