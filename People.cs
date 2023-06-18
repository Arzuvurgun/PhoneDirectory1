using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneDirectory1
{
    public class People
    {
        private string name;
        private string surname;
        private int number;

        public static int Count { get; internal set; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Number { get => number; set => number = value; }
    }
}
