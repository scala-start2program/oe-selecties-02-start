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

namespace Prb.JarenEnSeizoenen.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SeedMonths();



        }
        private void SeedMonths()
        {
            cmbMonths.Items.Add("januari");
            cmbMonths.Items.Add("februari");
            cmbMonths.Items.Add("maart");
            cmbMonths.Items.Add("april");
            cmbMonths.Items.Add("mei");
            cmbMonths.Items.Add("juni");
            cmbMonths.Items.Add("juli");
            cmbMonths.Items.Add("augustus");
            cmbMonths.Items.Add("september");
            cmbMonths.Items.Add("oktober");
            cmbMonths.Items.Add("november");
            cmbMonths.Items.Add("december");
        }
        private void txtYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtYear.IsLoaded)
            {

            }
        }
        private void btnYearMin_Click(object sender, RoutedEventArgs e)
        {
            // if (int.TryParse(txtJaar.Text, out int jaar))

        }
        private void btnYearPlus_Click(object sender, RoutedEventArgs e)
        {
            // if (int.TryParse(txtJaar.Text, out int jaar))

        }
        private void cmbMonths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            // meteoroligsche seizoenen
            /*
             * Lente: 1 maart t/m 31 mei
             * Zomer: 1 juni t/m 31 augustus
             * Herfst: 1 september t/m 30 november
             * Winter: 1 december t/m 28 februari
            */

        }
    }
}
