using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Rehbere yeni numara kaydetmek");
            Console.WriteLine("(2) Rehberde varolan numarayı silmek.");
            Console.WriteLine("(3) Rehberde varolan numarayı güncellemek.");
            Console.WriteLine("(4) Rehberi listelemek.");
            Console.WriteLine("(5) Rehberde Arama yapmak.");

            Console.WriteLine("****************************************");
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz:");
            int input =int.Parse(Console.ReadLine());

            Console.WriteLine("******");
            Rehber rehber = new Rehber();
            switch (input)
            {
                case 1:
                    KisiEkleme.Add(Rehber.kisiListesi);
                    break;
                case 2:
                    KisiSilme.Delete(Rehber.kisiListesi); break;    
                case 3:
                    NoGuncelleme.Update(Rehber.kisiListesi); break;
                case 4:
                    RehberiListeleme.listBySequentially(Rehber.kisiListesi); break;
                case 5:
                    RehberdeAramaYapmak.Search(Rehber.kisiListesi); break;
               
            }
            Console.ReadLine();
        }   
    }
}
