using System;
using System.Collections.Generic;

namespace Final_Assessment_2
{
    class Room
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void Print()
        {
            Console.WriteLine($"{"",-5}{Id,-10}{Title,-15}");
        }

        
    }
}
