using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MySql.Data.MySqlClient;
namespace AccountFanSys.MVM.View;


public partial class CatalogView : UserControl
{
    public CatalogView()
    {
        InitializeComponent();
        actionComboBox.SelectionChanged += ActionComboBox_SelectionChanged;
        categoryComboBox.SelectionChanged += CategoryComboBox_SelectionChanged;
        
        InitializeComponent();
        // Llamar a un método para cargar los datos en el ComboBox
        LoadDataToComboBox();
    }
        
        private void LoadDataToComboBox()
        {
            string connectionString = "Server=localhost;Database=facturacion_ucc;Uid=root;Pwd='';";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT nombre FROM catalogos ORDER BY nombre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agregar cada elemento de la consulta al ComboBox
                            string nombre = reader.GetString(0);
                            categoryComboBox.Items.Add(nombre);
                        }
                    }
                }
            }
        }
    

    private void ActionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (actionComboBox.SelectedIndex == 0)
        {
            dataTable.Visibility = Visibility.Collapsed;
        }
        else if (actionComboBox.SelectedIndex == 1)
        {
            dataTable.Visibility = Visibility.Visible;
        }

        // Reiniciar el ComboBox de categoría
        categoryComboBox.SelectedIndex = -1; // Restablece el índice seleccionado
    }
    
    private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (categoryComboBox.SelectedIndex == 0)
        {
            inputsEnterprise1.Visibility = Visibility.Visible;
            inputsEnterprise2.Visibility = Visibility.Visible;
            inputsBranch1.Visibility = Visibility.Collapsed;
            inputsBranch2.Visibility = Visibility.Collapsed;
            inputsSupplier1.Visibility = Visibility.Collapsed;
            inputsSupplier2.Visibility = Visibility.Collapsed;
            inputNameOnly.Visibility = Visibility.Collapsed;
        }
        else if (categoryComboBox.SelectedIndex == 1)
        {
            inputsEnterprise1.Visibility = Visibility.Collapsed;
            inputsEnterprise2.Visibility = Visibility.Collapsed;
            inputsBranch1.Visibility = Visibility.Visible;
            inputsBranch2.Visibility = Visibility.Visible;
            inputsSupplier1.Visibility = Visibility.Collapsed;
            inputsSupplier2.Visibility = Visibility.Collapsed;
            inputNameOnly.Visibility = Visibility.Collapsed;
        }
        
        else if (categoryComboBox.SelectedIndex == 2)
        {
            inputsEnterprise1.Visibility = Visibility.Collapsed;
            inputsEnterprise2.Visibility = Visibility.Collapsed;
            inputsBranch1.Visibility = Visibility.Collapsed;
            inputsBranch2.Visibility = Visibility.Collapsed;
            inputsSupplier1.Visibility = Visibility.Visible;
            inputsSupplier2.Visibility = Visibility.Visible;
            inputNameOnly.Visibility = Visibility.Collapsed;
        }

        else
        {
            inputsEnterprise1.Visibility = Visibility.Collapsed;
            inputsEnterprise2.Visibility = Visibility.Collapsed;
            inputsBranch1.Visibility = Visibility.Collapsed;
            inputsBranch2.Visibility = Visibility.Collapsed;
            inputsSupplier1.Visibility = Visibility.Collapsed;
            inputsSupplier2.Visibility = Visibility.Collapsed;
            inputNameOnly.Visibility = Visibility.Visible;
        }
        
    }
    
    
    
    
}



