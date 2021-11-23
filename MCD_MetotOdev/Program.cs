using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Matematik adında bir sınıf oluşturun. bir menü hazırlayın metot ile. 
            /*
             * menüde
             * ****MENÜ****
             * 1- Toplama
             * 2- Çıkartma
             * 3- Bölme
             * 4- Çarpma
             * Lütfen bir değer seçiniz
             * metot ile 4 işlemleri ekrana yazdır. metot ile yazdırılacak
             * public statik void içinde
             * Matematik sınıfının bir instance'ini al
             * kullanıcıdan 2 değer iste ve matematik sınıfındaki 4 şlem metodunu kullanarak sonuçları ekrana yazdır.
             */


            Matematik.Menu();
            Matematik.Yeniden();

            Console.ReadLine();
            #endregion
        }
    }
}
