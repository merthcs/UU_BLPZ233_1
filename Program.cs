using System;
using System.ComponentModel.DataAnnotations;

namespace UU_BLPZ233_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odev();
        }

        private static void Baslik(string baslik)
        {
            Console.Write($"--------------\n{baslik}");
        }

        private static void Odev()
        {
            int secim;
            try
            {
                Baslik("Ödev Numarası Giriniz: ");
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        HangisiBuyuk();
                        break;

                    case 2:
                        CarpimTablosu();
                        break;

                    case 3:
                        VizeFinal();
                        break;

                    case 4:
                        KelimeUzunlugu();
                        break;

                    case 5:
                        ToplayarakCarp();
                        break;

                    default:
                        Console.Write("\nLütfen geçerli ödev numarası giriniz. (1-5)\n");
                        Odev();
                        break;
                }
            }
            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void HangisiBuyuk()
        {
            try
            {
                int sayi, sayi2, sonuc;
                Baslik("Hangi Sayı Daha Büyük?\n");
                Console.Write("1. Sayı: ");
                sayi = int.Parse(Console.ReadLine());
                Console.Write("2. Sayı: ");
                sayi2 = int.Parse(Console.ReadLine());
                sonuc = (sayi > sayi2) ? sayi : sayi2;
                Console.WriteLine($"Sonuç: {sonuc}\n");
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void CarpimTablosu()
        {        
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine();
                    for (int k = 1; k <= 10; k++)
                    {
                        Console.Write($"{i}x{k}: {i * k}\n");
                    }
                }
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void VizeFinal()
        {
            try
            {
                double vize, final, sonuc;
                Baslik("Vize - Final Ortalaması Bulma\n");
                Console.Write("Vize: ");
                vize = double.Parse(Console.ReadLine());
                Console.Write("Final: ");
                final = double.Parse(Console.ReadLine());
                sonuc = (vize * 40) / 100 + (final * 60) / 100;
                Console.WriteLine($"Sonuç: {sonuc}\n");
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void KelimeUzunlugu()
        {
            try
            {
                string kelime, sonuc;
                Baslik("Kelime Uzunluğu Bulma\n");
                Console.Write("Kelime: ");
                kelime = Console.ReadLine();
                sonuc = $"{kelime.Length}";
                Console.WriteLine($"Sonuç: {sonuc}\n");
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }

        private static void ToplayarakCarp()
        {
            try
            {
                int sayi, sayi2, sonuc=0;
                Baslik("Hangi Sayı Daha Büyük?\n");
                Console.Write("1. Sayı: ");
                sayi = int.Parse(Console.ReadLine());
                Console.Write("2. Sayı: ");
                sayi2 = int.Parse(Console.ReadLine());
                for (int i = 0; i < sayi2; i++)
                {
                    sonuc = sonuc + sayi;
                }
                Console.WriteLine($"Sonuç: {sonuc}\n");
                Odev();
            }

            catch
            {
                Console.Write("Hata.");
            }
        }
    }
}
