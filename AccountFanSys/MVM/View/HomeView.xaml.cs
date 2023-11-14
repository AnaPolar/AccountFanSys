using System.Windows;
using System.Windows.Controls;

namespace AccountFanSys.MVM.View;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
    }
    
    private void UtilidadButton_Click(object sender, RoutedEventArgs e)
    {
        UtilidadPopup.IsOpen = true;
    }

    private void GuardarUtilidad_Click(object sender, RoutedEventArgs e)
    {
        // Aquí puedes obtener el valor ingresado en el TextBox y realizar las acciones de guardado
        string utilidad = UtilidadInput.Text;
    
        // Cierra la ventana emergente
        UtilidadPopup.IsOpen = false;
    }
    
    private void CancelarUtilidad_Click(object sender, RoutedEventArgs e)
    {
        // Cierra la ventana emergente sin guardar cambios
        UtilidadPopup.IsOpen = false;
    }
    
    
}