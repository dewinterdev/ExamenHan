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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Content = new MenuPage(this);
            Seeder();
        }

        public List<Student> Students = new List<Student>();
        public List<Payment> Payments = new List<Payment>();
        public DataCollection PaymentStudent = new DataCollection();

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                if (Content is StudentsOverviewPage || Content is PaymentsOverviewPage)
                {
                    Content = new MenuPage(this);
                }
                if (Content is AddStudentPage || Content is StudentPaymentsOverviewPage)
                {
                    Content = new StudentsOverviewPage(this);
                }
                if (Content is AddPaymentPage)
                {
                    Content = new PaymentsOverviewPage(this);
                }
            }
        }

        public void Seeder()    //Test data toevoegen die zal worden ingeladen bij het opstarten van het programma
        {
            //Students
            Student student1 = new Student("Han", "Dewinter", 1);
            Students.Add(student1);
            Students.Add(new Student("Micheal", "Delbeke", 2));
            Students.Add(new Student("Yannick", "Myny", 3));

            //Payments
            Payments.Add(new Payment(student1, "Paradiso", 23, true));
            Payments.Add(new Payment(student1, "Planetarium", 65, false));
            Payments.Add(new Payment(student1, "Plopsaland", 12, false));
        }

        public List<Payment> IsPaid()
        {
            List<Payment> PaidPayments = new List<Payment>();

            foreach (Payment payment in Payments)
            {
                if (payment.IsPaid == true)
                {
                    PaidPayments.Add(payment);
                }
            }
            return PaidPayments;
        }

        public List<Payment> UnPaid()
        {
            List<Payment> LBUnPaid = new List<Payment>();

            foreach (Payment payment in Payments)
            {
                if (payment.IsPaid == false)
                {
                    LBUnPaid.Add(payment);
                }
            }
            return LBUnPaid;
        }
    }
}