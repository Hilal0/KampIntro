using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği ; ne tipte bişi yazacaksan önce tip belirtiyorsun
            //do not repeat yourself - tekrar eden kodlar yazma!!

            string kategoriEtiketi = "Kategoriler"; //string metinsel ifadeler için

            int ogrenciSayisi = 32000; // int sayısal ifadeler için; çok büyük sayılar için int kullanılmaz farklı kodlar var

            double faizOrani = 1.45; // double ondalikli sayı tipleri için

            bool sistemeGirisYapmisMi = true; // kayıt ol butonu gibi düşün

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}

