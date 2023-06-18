using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    public class KisiEkleme:Rehber
    {
        private static string name;
        private static string surname;
        private static int number;


        public static List<People> kisiListesi = new List<People>();
        public static void Add(List<People> kisiListesi)

        {
            Console.Write("Lütfen isminizi giriniz:");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisminizi giriniz:");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numaranızı giriniz:");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***********");

            People kisi = new People
            {
                Name = name,
                Surname = surname,
                Number = number
            };
            Rehber.kisiListesi.Add(kisi);
            Console.WriteLine(isim + " " + soyisim + " " + "kişisi rehbere eklenmiştir.");
            
        }
    }      
}


     
