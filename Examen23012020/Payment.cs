using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen23012020
{
    public class Payment
    {
        public Student Student { get; set; }
        public string Activity { get; set; }
        public decimal AmountToPay { get; set; }
        public bool IsPaid { get; set; }

        public Payment(Student student, string activity, decimal amountToPay, bool isPaid)
        {
            Student = student;
            Activity = activity;
            AmountToPay = amountToPay;
            IsPaid = isPaid;
        }

        public Payment()
        {
        }

        public override string ToString()
        {
            return $"{Student} '{Activity}' {AmountToPay} Euro";
        }
    }
}