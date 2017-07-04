using GuitarSOA;
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

namespace GuitarClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddGuitarWindow addview = new AddGuitarWindow();
            Close();
            addview.Show();
        }

        private void SelectItemFromGrid(object sender, MouseButtonEventArgs e)
        {
            int id = GuitarListingsTable.GetRowHandleByMouseEventArgs(e) + 1;
            ServiceReference1.GuitarServiceClient service = new ServiceReference1.GuitarServiceClient();

            // Create a guitar object based on the chosen guitar in the list
            // set this as the view model property and open that view with the context passed in
            GuitarViewModel v = new GuitarViewModel();
            v.Guitar = service.Edit(id);

            ActionsWindow actWindow = new ActionsWindow(v);
            Close();
            actWindow.Show();
        }
    }
}
