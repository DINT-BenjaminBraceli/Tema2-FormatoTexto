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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulColorRadioButon.IsChecked = true;
        }
        private void ActualizaFuente()
        {
            if (negritaCheckBox.IsChecked == true)
            {
                salidaTextoTextBlock.FontWeight = FontWeights.Bold;
            }
            else
            {
                salidaTextoTextBlock.FontWeight = FontWeights.Normal;
            }


            if (cursivaCheckBox.IsChecked == true)
            {
                salidaTextoTextBlock.FontStyle = FontStyles.Italic;
            }
            else
            {
                salidaTextoTextBlock.FontStyle = FontStyles.Normal;
            }


            if (azulColorRadioButon.IsChecked==true)
            {
                salidaTextoTextBlock.Foreground = Brushes.Blue;
            } else if(rojoColorRadioButon.IsChecked==true)
            {
                salidaTextoTextBlock.Foreground = Brushes.Red;
            } else if(verdeColorRadioButon.IsChecked==true)
            {
                salidaTextoTextBlock.Foreground = Brushes.Green;
            }
        }
        private void EscribeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            salidaTextoTextBlock.Text = escribeTextBox.Text;
            ActualizaFuente();
        }

        private void NegritaCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            ActualizaFuente();
        }

        private void CursivaCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            ActualizaFuente();
        }

        private void AzulColorRadioButon_Checked(object sender, RoutedEventArgs e)
        {
            ActualizaFuente();
        }

        private void RojoColorRadioButon_Checked(object sender, RoutedEventArgs e)
        {
            ActualizaFuente();
        }

        private void VerdeColorRadioButon_Checked(object sender, RoutedEventArgs e)
        {
            ActualizaFuente();
        }
    }
}
