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
        // ObservableCollection<string> Colores = new ObservableCollection<string>();
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add(new Color("Rojo", "#FF0000", "(255,0,0)"));
            Colores.Add(new Color("Verde", "#00FF00", "(0,255,0)"));
            Colores.Add(new Color("Azul", "#00000FF", "(0,0,255)"));

            lstColores.ItemsSource = Colores;

        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            Colores.Add(new Color(txtColor.Text, txtHex.Text, txtRGB.Text));
            txtColor.Text = "";
            txtHex.Text = "";
            txtRGB.Text = "";

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
            if (lstColores.SelectedIndex != -1)
            {
                txtColorAct.Text = Colores[lstColores.SelectedIndex].Nombre;
                txtHexAct.Text = Colores[lstColores.SelectedIndex].Hexadecimal;
                txtRGBAct.Text = Colores[lstColores.SelectedIndex].RGB;
            }
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores[lstColores.SelectedIndex].Nombre = txtColorAct.Text;
                Colores[lstColores.SelectedIndex].Hexadecimal = txtHexAct.Text;
                Colores[lstColores.SelectedIndex].RGB = txtRGBAct.Text;
            }
            lstColores.Items.Refresh();
        }
    }
}