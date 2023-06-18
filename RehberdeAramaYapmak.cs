using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    public class RehberdeAramaYapmak:Rehber
    {
        public static void Search(List<People> kisiListesi)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz:");
            Console.WriteLine("İsim veya soyisme göre arama yapmak için (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için (2)");
            int arama=int.Parse(Console.ReadLine());

            if(arama ==1)
            {
                Console.WriteLine("Lütfen ardığınız kişinin adını ve soyadını giriniz:");
                string nameOrsurname=Console.ReadLine();
                foreach (People kisi in kisiListesi)
                {
                    //if (nameOrsurname =kisi.Name nameOrsurname = kisi.Surname)
                    //{
                    //    Console.WriteLine("Kişi adı:" + kisi.Name);
                    //    Console.WriteLine("Kişi soyadı:" + kisi.Surname);
                    //    Console.WriteLine("Kişi Telefon numarası:" + kisi.Number);
                    //    break;

                    //}
                   if (kisi.Name.ToLower() == nameOrsurname)
                    {
                        Console.WriteLine("Kişi adı:" + kisi.Name);
                        Console.WriteLine("Kişi soyadı:" + kisi.Surname);
                        Console.WriteLine("Kişi Telefon numarası:" + kisi.Number);
                    }
                    else if (kisi.Surname.ToLower() == nameOrsurname)
                    {
                        Console.WriteLine("Kişi adı:" + kisi.Name);
                        Console.WriteLine("Kişi soyadı:" + kisi.Surname);
                        Console.WriteLine("Kişi Telefon numarası:" + kisi.Number);
                        break;
                    }

                }
            
            }
            else if (arama ==2)
            {
                Console.WriteLine("Lütfen ardığınız kişinin telefon numarasını giriniz:");
                int searchnumber = int.Parse(Console.ReadLine());    
                
                foreach(People kisi in kisiListesi)
                {
                    if (kisi.Number == searchnumber)
                    {
                        Console.WriteLine("Kişi adı:" + kisi.Name);
                        Console.WriteLine("Kişi soyadı:" + kisi.Surname);
                        Console.WriteLine("Kişi Telefon numarası:" + kisi.Number);
                        break;
                    }
                }
                

            }
            
            
        }
    }
}
