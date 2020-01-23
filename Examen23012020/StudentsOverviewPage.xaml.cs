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
    /// Interaction logic for StudentsOverviewPage.xaml
    /// </summary>
    public partial class StudentsOverviewPage : Page
    {
        private MainWindow mainWindow;

        public StudentsOverviewPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Inladen van Studenten in de 'ListBoxStudents' bij het laden van de pagina
            ListBoxStudents.ItemsSource = mainWindow.Students;
        }

        private void ButtonAddStudent_Click(object sender, RoutedEventArgs e)
        {
            // Naar "AddStudentPage" gaan
            mainWindow.Content = new AddStudentPage(mainWindow);
        }

        private void ListBoxStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Naar "StudentPaymentsOverviewPage" gaan
            mainWindow.Content = new StudentPaymentsOverviewPage(mainWindow);
        }
    }
}