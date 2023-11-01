using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace AccountFanSys.MVM.View;

public partial class CatalogView : UserControl
{
    public CatalogView()
    {
        InitializeComponent();
        // Suscribe el método de manejo de eventos al evento de selección cambiada del ComboBox
        categoryComboBox.SelectionChanged += CategoryComboBox_SelectionChanged;
    }
    
    private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Obtiene el ComboBox seleccionado
        ComboBox comboBox = (ComboBox)sender;

        // Obtiene el índice seleccionado
        int selectedIndex = comboBox.SelectedIndex;

        // Configura la visibilidad de los campos de entrada según la selección
        switch (selectedIndex)
        {
            case 0: //empresa
                ShowInputs(8);
                break;
            case 1: //sucursal
                ShowInputs(7);
                break;
            case 2: //proveedor
                ShowInputs(7);
                break;
            case 3: //ciudad
                ShowInputs(1);
                break;
            case 4: //movimiento
                ShowInputs(1);
                break;
            case 5: //persona
                ShowInputs(1);
                break;
            // Agrega más casos según sea necesario para otras selecciones
            default:
                break;
        }
    }

    private void ShowInputs(int count)
    {
        // Oculta todos los campos de entrada
        HideAllInputs();

        // Muestra la cantidad de campos de entrada especificada
        for (int i = 1; i <= count; i++)
        {
            TextBox input = FindName($"input{i}") as TextBox;
            if (input != null)
            {
                input.Visibility = Visibility.Visible;
            }
        }
    }

    private void HideAllInputs()
    {
        for (int i = 1; i <= 8; i++)
        {
            TextBox input = FindName($"input{i}") as TextBox;
            if (input != null)
            {
                input.Visibility = Visibility.Hidden;
            }
        }
    }
    
    
    
}