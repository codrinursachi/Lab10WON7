using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10WON7
{
    internal class ContactlessSmartphone : IContactlessPay
    {
        public void Pay(decimal sum)
        {
            Console.WriteLine($"{sum:c} a fost platit");
        }

        public void TapCard()
        {
            Console.WriteLine("Telefonul a atins terminalul");
        }
    }
}
