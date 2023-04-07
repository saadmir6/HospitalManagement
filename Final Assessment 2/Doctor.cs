using System;
using System.Collections.Generic;

namespace Final_Assessment_2
{
    class Doctor :Patient 
    {
        
        public double Salary { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public void Print2()
        {
            Console.WriteLine($"{"",-5}{Id,-15}{FirstName,-15}{LastName,-20}{Age,-10}{Salary,-15}");
        }
        
        
    }
}