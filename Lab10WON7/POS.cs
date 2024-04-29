using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*POS-ul
POS-ul va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi 
modelate prin intermediul a doua metode, ce vor primi doi parametri: suma si dispozitivul prin care se 
va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata. 
Pentru plata prin intermediul POS-ului, clientul va putea folosi atat 
 carduri clasice – suporta doar plati contactfull
 carduri contactless - suporta atat plati contact-full cat si plati contactless
 telefoane mobile contactless - suporta doar plati contactless
*/
namespace Lab10WON7
{
    internal class POS
    {
        public void ContactfullPay(decimal sum, IContactfullPay paymentMethod)
        {
            paymentMethod.InsertCard();
            paymentMethod.Pay(sum);
            paymentMethod.RemoveCard();
        }
        public void ContactlsessPay(decimal sum, IContactlessPay paymentMethod)
        {
            paymentMethod.TapCard();
            paymentMethod.Pay(sum);
        }
    }
}
