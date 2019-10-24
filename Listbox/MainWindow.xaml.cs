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
using System.Collections.ObjectModel;

namespace Listbox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> Colores = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add("Rojo");
            Colores.Add("Naranja");
            Colores.Add("Amarillo");
            Colores.Add("Verde");

            lstColores.ItemsSource = Colores;
            
        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            
            if(txtColor.Text != "")
            Colores.Add(txtColor.Text);
            txtColor.Clear();

            if (txtHex.Text != "")
            Colores.Add(txtHex.Text);
            txtHex.Clear();

            if (txtRGB.Text != "")
            Colores.Add(txtRGB.Text);
            txtRGB.Clear();

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores.RemoveAt(lstColores.SelectedIndex);
            }
        }

        private void LstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtColorAct.Text = Colores[lstColores.SelectedIndex].Nombre;
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores.
            }
        }
    }
}
