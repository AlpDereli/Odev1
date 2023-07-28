// See https://aka.ms/new-console-template for more information
using System;

namespace Odev1
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("=========== 1. Kisim =============");
            Console.WriteLine("Girmek istediğiniz sayi sayisi: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] ciftler = new int[sayi];
            for (int i  = 0; i<sayi; i++)
            {
                Console.WriteLine("Sayi Giriniz: ");
                int a = Convert.ToInt32(Console.ReadLine());
                ciftler[i]=a;
            }
            foreach(int b in ciftler)
            {
                if (b%2==0)
                {
                    Console.WriteLine(b);
                }
            }
            Console.ReadLine();
            Console.WriteLine("=========== 2. Kisim =============");
            Console.WriteLine("Girmek istediğiniz sayi sayisi: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int[] sayis = new int[sayi1];
            Console.WriteLine("Bolunme kontrolu yapacaginiz sayiyi girin: ");
            int bol = Convert.ToInt32(Console.ReadLine());
            for (int l  = 0; l<sayi1; l++)
            {
                Console.WriteLine("Sayi Giriniz: ");
                int g = Convert.ToInt32(Console.ReadLine());
                sayis[l]=g;
            }
            foreach(int t in sayis)
            {
                if (t%bol==0)
                {
                    Console.WriteLine(t);
                }
            }
            Console.ReadLine();
            Console.WriteLine("=========== 3. Kisim =============");
            Console.WriteLine("Girmek istediğiniz kelime sayisi: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[sayi2];
            for (int i  = 0; i<sayi2; i++)
            {
                Console.WriteLine("Kelime Giriniz: ");
                string a = Console.ReadLine();
                kelimeler[i] = a;
            }
            foreach(string b in kelimeler.Reverse())
            {
                Console.Write(b);
            }
            Console.ReadLine();
            Console.WriteLine("=========== 4. Kisim =============");
            Console.WriteLine("Bir cumle yaz: ");
            string cumle = Console.ReadLine();
            string[] kelimekelime = cumle.Split();
            int kelimesayisi = kelimekelime.Count();
            Console.WriteLine("Kelime Sayisi: " + kelimesayisi);
            int harfsayisi = 0;
            foreach (string s in kelimekelime)
            {
                harfsayisi+= s.Count();
            }
            Console.WriteLine("Harf Sayisi: " + harfsayisi);
            Console.ReadLine();
        }
    }
}

