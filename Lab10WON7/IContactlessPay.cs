using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Plata contactless implica urmatoarele operatiuni:
 ApropieCard
 EfectueazaPlata
*/
namespace Lab10WON7
{
    internal interface IContactlessPay
    {
        void TapCard();
        void Pay(decimal sum);
    }
}
