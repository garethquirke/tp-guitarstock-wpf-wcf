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
    /// Interaction logic for ActionsWindow.xaml
    /// </summary>
    public partial class ActionsWindow : Window
    {
        private GuitarViewModel GuitarViewModel { get; set; }
        private ServiceReference1.GuitarServiceClient service = new ServiceReference1.GuitarServiceClient();

        public ActionsWindow(GuitarViewModel v)
        {
            GuitarViewModel = new GuitarViewModel();
            GuitarViewModel = v;

            InitializeComponent();
            GuitarViewModel.Guitar = v.Guitar;
            DataContext = v.Guitar;
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Guitar g = new Guitar
            {
                ID = GuitarViewModel.Guitar.ID,
                Make = Make.Text,
                Model = Model.Text,
                Stock = Convert.ToInt16(Stock.Text),
                Year = Convert.ToInt16(Year.Text),
                Price = Convert.ToDouble(Price.Text)
            };

            GuitarViewModel.SaveEdit(g);

            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            GuitarViewModel.DeleteGuitar(GuitarViewModel.Guitar.ID);
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex r = new Regex("[^0-9]+");
            e.Handled = r.IsMatch(e.Text);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
