using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Plata contact-full implica urmatoarele operatiuni:
 IntroduCard
 EfectueazaPlata
 ExtrageCard
*/
namespace Lab10WON7
{
    internal interface IContactfullPay
    {
        void InsertCard();
        void Pay(decimal sum);
        void RemoveCard();

    }
}
