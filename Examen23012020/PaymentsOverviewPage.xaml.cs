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

namespace Examen23012020
{
    /// <summary>
    /// Interaction logic for PaymentsOverviewPage.xaml
    /// </summary>
    public partial class PaymentsOverviewPage : Page
    {
        private MainWindow mainWindow;

        public PaymentsOverviewPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Inladen van BETALINGEN in de 'ListBoxPayments' bij het laden van de pagina
            ListBoxPayments.ItemsSource = mainWindow.Payments;
        }

        private void ButtonAddPayment_Click(object sender, RoutedEventArgs e)
        {
            // Naar "AddPaymentPage" gaan
            mainWindow.Content = new AddPaymentPage(mainWindow);
        }
    }
}