using atm_app.Database;
using atm_app.Entity;
using System;

namespace atm_app.Business
{
    public class Transactions : ITransactions
    {
        DB db = new DB();
        Logger logger = new Logger();

        public void Deposit(int customerCode)
        {
            User user = db.GetCustomerCode(customerCode);
            int balance = user.Balance;

            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
            int deposited = int.Parse(Console.ReadLine());

            balance += deposited;

            Console.WriteLine("Yeni Bakiyeniz: " + balance);
            string message = user.NameSurname + " " + balance + " TL hesabınıza yatırıldı.";
            logger.WriteFile(message);
        }

        public void PayingBill(int customerCode)
        {
            User user = db.GetCustomerCode(customerCode);
            int balance = user.Balance;

            Console.WriteLine("Ödemek istediğiniz fatura tipini seçiniz. \n 1) Telefon \n 2) Doğalgaz \n 3) Elektrik \n 4) Su");
            string choice = Console.ReadLine();

            if (int.Parse(choice) != 1 && int.Parse(choice) != 2 && int.Parse(choice) != 3 && int.Parse(choice) != 4)
                Console.WriteLine("Hatalı bir tuşlama yaptınız.");

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ödenecek tutarı giriniz: ");
                    int phoneBill = int.Parse(Console.ReadLine());
                    balance -= phoneBill;
                    Console.WriteLine("{0} TL tutarındaki faturanız ödenmiştir. Kalan bakiyeniz: {1}", phoneBill, balance);
                    string message = user.NameSurname + " " + phoneBill + " TL telefon faturası ödendi.";
                    logger.WriteFile(message);
                    break;
                case "2":
                    Console.WriteLine("Ödenecek tutarı giriniz: ");
                    int gasBill = int.Parse(Console.ReadLine());
                    balance -= gasBill;
                    Console.WriteLine("{0} TL tutarındaki faturanız ödenmiştir. Kalan bakiyeniz: {1}", gasBill, balance);
                    message = user.NameSurname + " " + gasBill + " TL doğalgaz faturası ödendi.";
                    logger.WriteFile(message);
                    break;
                case "3":
                    Console.WriteLine("Ödenecek tutarı giriniz: ");
                    int electricBill = int.Parse(Console.ReadLine());
                    balance -= electricBill;
                    Console.WriteLine("{0} TL tutarındaki faturanız ödenmiştir. Kalan bakiyeniz: {1}", electricBill, balance);
                    message = user.NameSurname + " " + electricBill + " TL elektrik faturası ödendi.";
                    logger.WriteFile(message);
                    break;
                case "4":
                    Console.WriteLine("Ödenecek tutarı giriniz: ");
                    int waterBill = int.Parse(Console.ReadLine());
                    balance -= waterBill;
                    Console.WriteLine("{0} TL tutarındaki faturanız ödenmiştir. Kalan bakiyeniz: {1}", waterBill, balance);
                    message = user.NameSurname + " " + waterBill + " TL su faturası ödendi.";
                    logger.WriteFile(message);
                    break;
            }
        }

        public void WithDraw(int customerCode)
        {
            User user = db.GetCustomerCode(customerCode);
            int balance = user.Balance;

            Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
            int draw = int.Parse(Console.ReadLine());

            balance -= draw;

            Console.WriteLine("{0} TL'yi para haznesinden alabilirsiniz. Kalan bakiyeniz {1}", draw, balance);
            string message = user.NameSurname + " " + draw + " TL çekildi.";
            logger.WriteFile(message);
        }
    }
}
