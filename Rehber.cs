using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    public class Rehber
    {
        public static List<People> kisiListesi= new List<People>();
        public Rehber()
        {
            People kisi1= new People  { Name  ="Arzu",Surname  = "Vurgun", Number = 1234567890 };
            People kisi2 = new People { Name = "Rana", Surname = "Tunç", Number  = 1234567890 };
            People kisi3 = new People { Name = "Ali", Surname = "Vurgun", Number = 1234567890 };
            People kisi4 = new People { Name = "Emre", Surname = "Şahin", Number = 1234567890 };
            People kisi5 = new People { Name = "Umay", Surname = "Otaklı", Number = 1234567890 };

         
            kisiListesi.Add(kisi1);
            kisiListesi.Add(kisi2);
            kisiListesi.Add(kisi3);
            kisiListesi.Add(kisi4);
            kisiListesi.Add(kisi5);
       
        }
    }
}
