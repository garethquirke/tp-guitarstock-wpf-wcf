using GuitarSOA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GuitarClient
{
    /// <summary>
    /// Interaction logic for AddGuitarWindow.xaml
    /// </summary>
    public partial class AddGuitarWindow : Window
    {
        private GuitarViewModel GuitarViewModel { get; set; }


        public AddGuitarWindow()
        {
            InitializeComponent();
            GuitarViewModel = new GuitarViewModel();
        }

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex r = new Regex("[^0-9]+");
            e.Handled = r.IsMatch(e.Text);
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            // call the add method
            // make a obect first from the input fields
            Guitar g = new Guitar
            {
                Make = Make.Text,
                Model = Model.Text,
                Stock = Convert.ToInt16(Stock.Text),
                Year = Convert.ToInt16(Year.Text),
                Price = Convert.ToDouble(Price.Text)
            };

            GuitarViewModel.AddGuitar(g);

            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
