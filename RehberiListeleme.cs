using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    public class RehberiListeleme:Rehber
    {
        public static void listBySequentially(List<People> kisiler)
        {
            var kisilerList = kisiler.OrderBy(value => value.Name);
            foreach (var people in kisilerList)
            {
                Console.WriteLine("----REHBER LİSTESİ----");
                Console.WriteLine("Kişi adı:" + people.Name);
                Console.WriteLine("Kişi soyadı:" + people.Surname);
                Console.WriteLine("Kişi Telefon numarası:"+ people.Number);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
