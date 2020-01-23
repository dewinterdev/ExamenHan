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
    /// Interaction logic for AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        private MainWindow mainWindow;

        public AddStudentPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void ButtonSaveStudentIsEnabled()
        {
            ButtonSaveStudent.IsEnabled =
                TextBoxFirstName.Text.Trim() != string.Empty &&
                TextBoxLastName.Text.Trim() != string.Empty &&
                TextBoxClassNumber.Text.Trim() != string.Empty;
        }

        private void TextBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonSaveStudentIsEnabled();
        }

        private void TextBoxLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonSaveStudentIsEnabled();
        }

        private void TextBoxClassNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonSaveStudentIsEnabled();
        }

        private void ButtonSaveStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!decimal.TryParse(TextBoxClassNumber.Text.Trim(), out decimal classNumber))
            {
                MessageBox.Show("Dit is geen correcte ingave zorg ervoor dat het ingegeven klasnummer een nummer is.");
                return;
            }

            Student student = new Student(TextBoxFirstName.Text.Trim(), TextBoxLastName.Text.Trim(), classNumber);
            mainWindow.Students.Add(student);
            mainWindow.Content = new StudentsOverviewPage(mainWindow);
        }
    }
}