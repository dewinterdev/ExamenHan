using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen23012020
{
    public class DataCollection
    {
        public List<Payment> Payments = new List<Payment>();

        public DataCollection()
        {
        }

        public void Add(Payment payment)
        {
            Payments.Add(payment);
        }

        public List<string> GetUniquePayments()
        {
            List<string> uniqueList = new List<string>();

            foreach (var payment in Payments)
            {
                if (!uniqueList.Contains(payment.ToString())) uniqueList.Add(payment.ToString());
            }

            return uniqueList;
        }

        public List<string> GetStudentPayments(string student)
        {
            List<string> payments = GetUniquePayments();

            List<string> list = new List<string>();

            foreach (string payment in payments)
            {
                list.Add(student + payment);
            }

            return list;
        }
    }
}