/*Exercițiu
Scrieti un program care va modela operatiunile unei casa de marcat.
*/
using Lab10WON7;

CashRegister cashRegister = new();
decimal sum = cashRegister.ScanProduct();
POS pOS = new();
Console.WriteLine("1 pentru cash 2 pentru card");
switch (Console.ReadLine())
{
    case "1":
        cashRegister.PayByCash(sum);
        return;
    case "2":
        pOS = cashRegister.PayByCard();
        break;
}


Console.WriteLine("1 pentru contactfull 2 pentru contactless");
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("1 pentru card clasic, 2 pentru card contactless");
        switch (Console.ReadLine())
        {
            case "1":
                pOS.ContactfullPay(sum, new ClassicCard());
                break;
            case "2":
                pOS.ContactfullPay(sum, new ContactlessCard());
                break;
        };
        break;
    case "2":
        Console.WriteLine("1 pentru card contactless, 2 pentru telefon");
        switch (Console.ReadLine())
        {
            case "1":
                pOS.ContactlsessPay(sum, new ContactlessCard());
                break;
            case "2":
                pOS.ContactlsessPay(sum, new ContactlessSmartphone());
                break;
        };
        break;
}