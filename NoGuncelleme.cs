using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    public class NoGuncelleme:Rehber
    {
        public static void Update(List<People> kisiListesi)
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
                        Console.WriteLine("Lütfen kişininin şu an ki numarasını giriniz:"+kisi.Name+":");
                        int number = Convert.ToInt32(Console.ReadLine());
                        kisi.Number = number;
                        ct = true;
                        Console.WriteLine(number+""+" yeni numaranız olarak güncellenmiştir.");
                    }
                    else if (kisi.Surname.ToLower() == input)
                    {
                        Console.WriteLine("Lütfen kişininin şu an ki numarasını giriniz:" + kisi.Surname + ":");
                        int number = Convert.ToInt32(Console.ReadLine());
                        kisi.Number = number;
                        ct = true;
                        Console.WriteLine("Yeni numaranız güncellenmiştir.");
                    }
                   

                }
                    if (!ct)
                    {
                        Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                        Console.WriteLine("* Güncelemeyi sonlandırmak için (1)");
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

