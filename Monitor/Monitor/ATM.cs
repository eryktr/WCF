using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    public class ATM
    {
        private double _sum;
        private string _location;

        public ATM(double sum, string location)
        {
            _sum = sum;
            _location = location;
        }

        public double getSum()
        {
            return _sum;
        }

        public string getLocation()
        {
            return _location;
        }

        public void getMoney(double amount)
        {
            Console.WriteLine($"{amount} taken");
            _sum -= amount;
        }

        public void addMonet(double amount)
        {
            Console.WriteLine($"{amount} added");
            _sum += amount;
        }
    }
}
