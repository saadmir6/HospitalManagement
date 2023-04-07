using System;
using System.Collections.Generic;

namespace Final_Assessment_2
{
    class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void Print()
        {
            Console.WriteLine($"{"",-5}{Id,-15}{Name,-20}{City,-20}{Country,-20}{PostalCode,-20}");
        }

    }
}
