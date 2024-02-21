using pz_18;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Credit credit1 = new Credit("Ivan", Status.high, 105000);
            credit1.GetCredit();
            credit1.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit2 = new Credit("Anna", Status.low, 105000);
            credit2.GetCredit();
            credit2.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit3 = new Credit("Yulia", Status.high, 5200000);
            credit3.GetCredit();
            credit3.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit4 = new Credit("Anastasia", Status.high, 4500000);
            credit4.GetCredit();
            credit4.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit5 = new Credit("Vladislav", Status.average, 105000);
            credit5.GetCredit();
            credit5.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit6 = new Credit("Zhania", Status.high, 115000);
            credit6.GetCredit();
            credit6.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit7 = new Credit("Valeria", Status.low, 99000);
            credit7.GetCredit();
            credit7.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit8 = new Credit("Sofia", Status.high, 308000);
            credit8.GetCredit();
            credit8.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit9 = new Credit("Sergei", Status.average, 215000);
            credit9.GetCredit();
            credit9.PrintCreditInfo();
            Credit.PrintBankInfo();

            Credit credit10 = new Credit("Ekaterina", Status.low, 105000);
            credit10.GetCredit();
            credit10.PrintCreditInfo();
            Credit.PrintBankInfo();
        }
    }
}