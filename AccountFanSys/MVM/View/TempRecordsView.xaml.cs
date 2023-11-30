using System.Windows;

namespace AccountFanSys.MVM.View;

public partial class TempRecordsView : Window
{
    public TempRecordsView()
    {
        InitializeComponent();
    }
    
    private void Guardar_Click(object sender, RoutedEventArgs e)
    {
        // Cierra la ventana actual
        this.Close();
    }

    private void Eliminar_Click(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}