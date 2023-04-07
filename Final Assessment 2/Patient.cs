using System;
using System.Collections.Generic;




namespace Final_Assessment_2
{
    class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }


        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public void Print()
        {
            Console.WriteLine($"{"",-5}{Id, -15}{FirstName,-15}{LastName,-20}{Age,-15}{EntryDate,-20}{"",-5}{ExitDate,-15}");
        }
        




    }
}
