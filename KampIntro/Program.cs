
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            //Data Types
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            //Buradaki veri bir DB'den gelir
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            /*Arraylerde tutmalıyız
            string kurs1 = "Yazılım geliştirici yetiştirme kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            */


            //Yeni kurs eklenince for ile dinamik olarak ekranda gösterilir
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kursu",
"Programlamaya başlangıç için temel kurs","Java","Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //foreach ile daha kolay dönebiliriz
            //kurs ismi bir alias'dır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - Footer");
        }
    }
}



