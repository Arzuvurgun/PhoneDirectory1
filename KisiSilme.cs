using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace PhoneDirectory1 
{ 
    public class KisiSilme:Rehber
    {
        public static void Delete(List<People> kisiListesi)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine().ToLower();
            bool ct = false;

            while (!ct)
            {
                foreach (People kisi in kisiListesi)
                {
                    if (kisi.Name.ToLower() == input)
                    {
                        Console.WriteLine(kisi.Name+" " + "isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                        char control = char.Parse(Console.ReadLine());

                        if (control == 'y')
                        {
                            kisiListesi.Remove(kisi);
                            Console.WriteLine(kisi.Name.ToLower() + "  isimli Kişi silindi...");
                            //Console.WriteLine("Çıkış yapılıyor.");
                            ct = true;
                            break;
                        }


                    }
                    if ( kisi.Surname.ToLower() == input)
                    {
                        Console.WriteLine(kisi.Surname + " " + "soyisimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                        char control = char.Parse(Console.ReadLine());
                        if (control == 'y')
                        {
                            kisiListesi.Remove(kisi);
                            Console.WriteLine(kisi.Surname.ToLower() + "  soyisimli Kişi silindi...");
                            ct = true;
                            break;

                        }
                        else
                        {
                            ct = true;
                        }

                    }
                    else if (!ct)
                    {
                        Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                        Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                        Console.WriteLine("* Yeniden denemek için (2)");
                        int input2 = int.Parse(Console.ReadLine());

                        if (input2 == 1)
                        {
                            Console.WriteLine("İşlem sonlandırıldı.");
                            ct = true;
                        }
                        else if (input2 == 2)
                        {
                            ct = false;
                            Console.WriteLine("Lütfen Tekrar Deneyiniz.");
                            string control = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("Çıkış yapılıyor...");

                        }

                    }

                }
            }

        }

    }
}


