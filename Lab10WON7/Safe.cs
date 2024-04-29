using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10WON7
{
    internal class Safe
    {
        decimal sum;
        public void Open()
        {
            Console.WriteLine("Seiful s-a deschis");
        }
        public void DepositSum(decimal sum)
        {
            this.sum += sum;
            Console.WriteLine("Suma a fost depusa");
        }
        public void Close()
        {
            Console.WriteLine("Seiful s-a inchis");
        }
    }
}
