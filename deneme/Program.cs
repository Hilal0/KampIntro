using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();//new ederek classımızı çağırıp özelliklerine isimler vereceğiz.
            urun1.UrunAdi = "Ceket";// ürün ismi
            urun1.UrunFiyati = 100;//ürün fiyatı

            urun urun2 = new urun();
            urun2.UrunAdi = "Etek";
            urun2.UrunFiyati = 70;

            urun urun3 = new urun();
            urun3.UrunAdi = "Kazak";
            urun3.UrunFiyati = 80;

            urun urun4 = new urun();
            urun4.UrunAdi = "Elbise";
            urun4.UrunFiyati = 120;

            urun urun5 = new urun();
            urun5.UrunAdi = "Gömlek";
            urun5.UrunFiyati = 90;

            urun[] urunler = new urun[] { urun1, urun2, urun3, urun4, urun5 };//Diziye ekleyerek listelemeyi sağlayacağiz.

            foreach (var urun in urunler)//foreach diyerek Hızlı ve basit bir şekilde ekrana bastıracağiz.
            {
                Console.WriteLine(urun1.UrunAdi + " : " + urun1.UrunFiyati);//urunun adı ve fiyatını ekrana bastırıyoruz.
                Console.WriteLine(urun2.UrunAdi + " : " + urun2.UrunFiyati);
                Console.WriteLine(urun3.UrunAdi + " : " + urun3.UrunFiyati);
                Console.WriteLine(urun4.UrunAdi + " : " + urun4.UrunFiyati);
                Console.WriteLine(urun5.UrunAdi + " : " + urun5.UrunFiyati);
            }
            Console.WriteLine("******************");//diğer döngü ile karışmaması için 

            for (int i = 0; i < urunler.Length; i++)//for döngüsü kullanarak ürünleri ve isimlerini listeledik.
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunFiyati);//i dizi içerisinde gezerek bize ürünleri getirecek.
            }
            Console.WriteLine("Ürünler Sıralanmıştır!")// döngü bittiğinde uyarı verdik.
            Console.WriteLine("++++++++++++++++++");//karışmaması için 


            Console.WriteLine("------------------");//karışmaması için 
            int j = 0;//while döngüsü içerisine girmek için int değerinde j değeri belirledik.

            while (j < urunler.Length)// j küçüktür ürünlerin uzunlugundan.
            {
                Console.WriteLine(urunler[j].UrunAdi + " " + urunler[j].UrunFiyati);//j gezerek ürünleri ekrana bastırdık.
                j++;
            }

        }
    }
    class urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
    }
}