using atm_app.Business;
using System;

namespace atm_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*ATM uygulaması
        Uygulama ilk çalıştığında kullanıcıdan yamak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temem işlemledir. Para çekme, para yatırma, ödeme yapma vs..İsteğe bağlı olarak genişletilebilir.Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

        Uygulamada bir de gün sonu seçeneği olmalıdır.Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction ların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

        Kullanılması gereken teknikler:

        Dosyaya Yazma
        Dosyadan Okuma
        İşlem listesi pre - defined olarak kullanılabilir. */

        Start:
            Console.WriteLine("Ahmet Bank'a hoşgeldiniz. Lütfen Müşteri numaranızı giriniz: ");
            int custNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen şifrenizi giriniz: ");
            string custPassword = Console.ReadLine();

            UserControl userControl = new UserControl();
            bool a = userControl.Controller(custNo, custPassword);

            Transactions transaction = new Transactions();
            Logger logger = new Logger();

            if (a == true)
            {
                Console.WriteLine("Giriş başarılı! \n Lütfen yapmak istediğiniz işlemi seçiniz:\n 1) Para yatırma \n 2) Para çekme \n 3) Fatura ödeme \n 4) Çıkış");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        transaction.Deposit(custNo);
                        break;
                    case "2":
                        transaction.WithDraw(custNo);
                        break;
                    case "3":
                        transaction.PayingBill(custNo);
                        break;
                    case "4":
                        Console.Out.Close();
                        break;
                }
            }

            else if (a == false)
            {
                string message = "Müşteri numaranızı veya şifrenizi hatalı girdiniz. Tekrar deneyin.";
                Console.WriteLine(message);
                logger.WriteFile(message);
                goto Start;
            }
        }
    }
}
