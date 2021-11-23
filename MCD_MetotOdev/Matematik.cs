using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOdev
{
    class Matematik
    {
        

        public static void Toplama()
        {
            Console.WriteLine("Lütfen Birinci değeri Giriniz:");
            int deger1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci değeri Giriniz:");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = deger1 + deger2;
            Console.WriteLine("Sonuc : " + sonuc);
        }

        public static void Çıkarma()
        {
            Console.WriteLine("Lütfen Birinci değeri Giriniz:");
            int deger1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci değeri Giriniz:");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = deger1 - deger2;
            Console.WriteLine("Sonuc : " + sonuc);
        }

        public static void Bölme()
        {
            Console.WriteLine("Lütfen Birinci değeri Giriniz:");
            int deger1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci değeri Giriniz:");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = deger1 / deger2;
            Console.WriteLine("Sonuc : " + sonuc);
        }

        public static void Çarpma()
        {
            Console.WriteLine("Lütfen Birinci değeri Giriniz:");
            int deger1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci değeri Giriniz:");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = deger1 * deger2;
            Console.WriteLine("Sonuc : " + sonuc);
        }

        public static void Yeniden()
        {
            Console.WriteLine("Yeniden İşlem Yapmak İstiyor Musunuz? E/H");
            string yeniden1 = Console.ReadLine();
            if (yeniden1.ToLower() == "e")
            {
                Menu();
            }

            else
            {
                Environment.Exit(0);
            }
        }


        public static void Menu()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Bölme");
            Console.WriteLine("4- Çarpma");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Toplama();
                    break;

                    case 2:
                        Çıkarma();
                    break;

                case 3:
                    Bölme();
                    break;

                case 4:
                    Çarpma();
                    break;
                default:
                    Console.WriteLine("hatalı Giriiş Yaptınız.");
                    break;
            }
        }

        

    }
}
