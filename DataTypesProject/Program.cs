using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double sayi1 = 0, sayi2 = 0;
            string islem;
            Console.WriteLine("Lütfen birinci sayıyı giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());



        Basla: //switch case kullanmadığım için goto ile döngü yaptım. Eğer yanlış bir karakter girilirse tekrar giriş yapılmasını sağlamak için
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz Toplama (+), Çıkarma(-), Çarpma(x), Bölme(/)");
            //islem = Convert.ToString(Console.ReadLine());
            islem = Console.ReadLine() ?? ""; // Parse ya da Convert yapmama nedenim default string olarak algılıyor olması. Hata aldım hata kodundan ?? "" ekleyerek sorun çözüldü
            if (islem == "+")
            {
                Double Toplam = 0; // Double girme nedenim aslında bölme işleminde sorun çıkabilme ihtimali
                Toplam = sayi1 + sayi2;
                Console.WriteLine("İşlem Sonucunuz : " + Toplam);
            }
            else if (islem == "-")
            {
                Double Cikar = 0;
                Cikar = sayi1 - sayi2;
                Console.WriteLine("İşlem Sonucunuz : " + Cikar);
            }
            else if (islem == "*")
            {
                Double Carp = 0;
                Carp = sayi1 * sayi2;
                Console.WriteLine("İşlem Sonucunuz : " + Carp);
            }
            else if (islem == "/")
            {
                Double Bol = 0;
                Bol = sayi1 / sayi2;
                Console.WriteLine("İşlem Sonucunuz : " + Bol);
            }
            else
            {
                Console.WriteLine("Yalnış giriş yaptınız tekrar deneyin");
                goto Basla;// Hatalı giriş olursa tekrar işlem girilmesi istenecek
            }
            Console.ReadLine();

        }
    }
}
