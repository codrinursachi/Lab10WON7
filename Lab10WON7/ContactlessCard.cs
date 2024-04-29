using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10WON7
{
    internal class ContactlessCard : IContactfullPay, IContactlessPay
    {
        public void InsertCard()
        {
            Console.WriteLine("Cardul a fost introdus");
        }

        public void Pay(decimal sum)
        {
            Console.WriteLine($"{sum:c} a fost platit");
        }

        public void RemoveCard()
        {
            Console.WriteLine("Cardul a fost scos");
        }

        public void TapCard()
        {
            Console.WriteLine("Cardul a atins terminalul");
        }
    }
}
