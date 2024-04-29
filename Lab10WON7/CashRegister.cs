using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Casa de marcat
O casa de marcat va avea o metoda prin care va scana un produs, va oferi metode de plata cash sau prin 
intermediul unui POS.
• In cazul platii cash, casa de marcat 
1. va deschide un seif 
2. va introduce suma in seif
3. va inchide seif-ul
4. Va elibera chitanta
Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma 
de plata. La fiecare dintre operatiunile de mai sus, un mesaj corespunzator va fi afisat pe ecran
• In cazul platii cu cardul, casa de marcat va pune la dispozitia clientului un POS, printr-o metoda care 
va oferi la cerere un POS*/
namespace Lab10WON7
{
    internal class CashRegister
    {
        readonly Safe safe;

        public CashRegister()
        {
            this.safe = new Safe();
        }

        public decimal ScanProduct()
        {
            return (decimal)Random.Shared.NextDouble() * 100M;
        }
        public void PayByCash(decimal sum)
        {
            safe.Open();
            safe.DepositSum(sum);
            safe.Close();
            Console.WriteLine($"Platit {sum:c}");
        }
        public POS PayByCard()
        {
            return new POS();
        }
    }
}
