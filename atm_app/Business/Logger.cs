using atm_app.Database;
using System;
using System.IO;

namespace atm_app.Business
{
    internal class Logger : ILogger
    {
        DB db = new DB();
        public void ReadFile()
        {
            string filePath = @"C:\Users\Ahmet\Desktop\Metin Belgesi.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string log = sr.ReadLine();

            while (log != null)
            {
                Console.WriteLine(log);
                log = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

        public void WriteFile(string message)
        {
            string filePath = @"C:\Users\Ahmet\Desktop\" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(message);

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
