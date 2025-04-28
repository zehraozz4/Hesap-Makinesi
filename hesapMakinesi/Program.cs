using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("----------ANA MENU----------");
                Console.WriteLine("Cıkıs icin --> 0");
                Console.WriteLine("Topalma icin --> 1");
                Console.WriteLine("Cikarma icin --> 2");
                Console.WriteLine("Carpma icin --> 3");
                Console.WriteLine("Bolme icin --> 4");
                Console.WriteLine("Mod alma icin --> 5");

                int secim =girisKontrolu("Lutfen yapmak istediginiz islemi seciniz:",0,5);
                double sonuc=0;
                switch (secim)
                {
                    case 0:
                        Console.WriteLine("Cikis yapiliyor...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        double sayi1t = doubleSayi();
                        double sayi2t = doubleSayi();
                        sonuc = sayi1t + sayi2t;
                        break;
                    case 2:
                        double sayi1c = doubleSayi();
                        double sayi2c = doubleSayi();
                        sonuc = sayi1c - sayi2c;
                        break;
                    case 3:
                        double sayi1cc = doubleSayi();
                        double sayi2cc = doubleSayi();
                        sonuc = sayi1cc * sayi2cc;
                        break;
                    case 4:
                        double sayi1b = doubleSayi();
                        double sayi2b = doubleSayi();
                        if(sayi2b==0)
                        {
                            Console.WriteLine("Bolen sayi 0 olamaz!!!");
                            break;
                        }
                        sonuc = sayi1b / sayi2b;
                        break;
                    case 5:
                        int sayi1 = intSayi();
                        int sayi2 = intSayi();
                        sonuc = sayi1 % sayi2;
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli deger giriniz!!!");
                        break;

                }
                Console.WriteLine("Sonuc:" + sonuc);
            }
        }

        static int girisKontrolu(string mesaj, int min, int max)
        {
            int sayi;
            while (true)
            {
                Console.Write(mesaj);
                string secim = Console.ReadLine();

                if (int.TryParse(secim, out sayi))
                {
                    if (sayi >= min && sayi <= max)
                    {
                        return sayi;
                    }
                    else
                    {
                        Console.WriteLine("Lutfen " + min + " ile " + max + " arasinda bir deger giriniz!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir deger giriniz!!!");
                }
            }
        }

        static  double doubleSayi()
        {
            while(true)
            {
                Console.Write("Lutfen double turunde sayi giriniz:");
                string StringSayi = Console.ReadLine();
                if (double.TryParse(StringSayi, out double sayi))
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli double turunde bir sayi giriniz!!!");
                }
            }
        }

        static int intSayi()
        {
            while (true)
            {
                Console.Write("Lutfen int turunde sayi giriniz:");
                string StringSayi = Console.ReadLine();
                if (int.TryParse(StringSayi, out int sayi))
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli int turunde bir sayi giriniz!!!");
                }
            }
        }
    }
}
