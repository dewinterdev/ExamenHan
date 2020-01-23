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
    /// Interaction logic for AddPaymentPage.xaml
    /// </summary>
    public partial class AddPaymentPage : Page
    {
        private MainWindow mainWindow;

        public AddPaymentPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Inladen van alle student in de "ComboBoxStudent"
            ComboBoxStudent.ItemsSource = mainWindow.Students;
        }

        private void ButtonSavePaymentIsEnabled()
        {
            ButtonSavePayment.IsEnabled =
                ComboBoxStudent.SelectedItem != null &&
                TextBoxActivity.Text.Trim() != string.Empty &&
                TextBoxAmountToPay.Text.Trim() != string.Empty;
        }

        private void ComboBoxStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonSavePaymentIsEnabled();
        }

        private void TextBoxActivity_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonSavePaymentIsEnabled();
        }

        private void TextBoxAmountToPay_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonSavePaymentIsEnabled();
        }

        private void ButtonSavePayment_Click(object sender, RoutedEventArgs e)
        {
            if (!decimal.TryParse(TextBoxAmountToPay.Text.Trim(), out decimal amountToPay))
            {
                MessageBox.Show("Dit is geen correcte ingave zorg ervoor dat het ingegeven bedrag decimaal is.");
                return;
            }
            Payment payment = new Payment((Student)ComboBoxStudent.SelectedItem, TextBoxActivity.Text.Trim(), amountToPay, false);
            mainWindow.Payments.Add(payment);
            mainWindow.Content = new PaymentsOverviewPage(mainWindow);
        }
    }
}