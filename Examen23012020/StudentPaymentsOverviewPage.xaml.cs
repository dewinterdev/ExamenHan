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
    /// Interaction logic for StudentPaymentsOverviewPage.xaml
    /// </summary>
    public partial class StudentPaymentsOverviewPage : Page
    {
        private MainWindow mainWindow;
        public List<string> Methods = new List<string>();
        public string str1 = "Alle Betalingen";
        private string str2 = "Betaald";
        private string str3 = "Niet Betaald";

        public StudentPaymentsOverviewPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void ButtonPayIsEnabled()
        {
            ButtonPay.IsEnabled =
                ListBoxStudentPayments.SelectedItem != null;
        }

        private void ListBoxStudentPayments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonPayIsEnabled();
        }

        private void ButtonPay_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Methods.Add(str1);
            Methods.Add(str2);
            Methods.Add(str3);
            ComboBoxFilter.ItemsSource = Methods;
            ListBoxStudentPayments.ItemsSource = mainWindow.Payments;
        }

        private void ComboBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)ComboBoxFilter.SelectedItem == str1)
            {
                ListBoxStudentPayments.ItemsSource = mainWindow.Payments;
            }
            else if ((string)ComboBoxFilter.SelectedItem == str2)
            {
                ListBoxStudentPayments.ItemsSource = mainWindow.IsPaid();
            }
            else if ((string)ComboBoxFilter.SelectedItem == str3)
            {
                ListBoxStudentPayments.ItemsSource = mainWindow.UnPaid();
            }
        }
    }
}