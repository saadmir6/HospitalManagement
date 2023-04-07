using System;
using System.Linq;
using System.Collections.Generic;

namespace Final_Assessment_2
{
    class View
    {
        

        public static void Patients(List<Patient> patients, string message) 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"",-5}{"ID",-15}{"FIRSTNAME",-15}{"LASTNAME",-20}{"AGE",-15}{"ENTRYDATE",-25}  {"EXITDATE",-15}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var patient in patients)
            {
                patient.Print();
            }

        }

        public static void Addresses(List<Address> addresses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"",-5}{"ID",-15}{"NAME",-20}{"CITY",-20}{"COUNTRY",-20}{"POSTALCODE",-20}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var address in addresses)
            { 
                address.Print();    
            }
        }

        public static void Doctors(List<Doctor> doctors, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{"",-5}{"ID",-15}{"FIRSTNAME",-15}{"LASTNAME",-20}{"AGE",-10}{"SALARY",-15}");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var doctor in doctors)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                doctor.Print2();
                Console.ResetColor();
            }
        }

        public static void Rooms(List<Room> rooms, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{"",-5}{"ID",-10}{"TITLE",-15}");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var room in rooms)
            {
                room.Print();
            }
        }

        public static void Inheritence(List<Doctor> doctors, string message)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{"",-5}{" FIRSTNAMES OF DOCTORS AND PATIENTS ",-15}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            foreach (var doctor in doctors)
            {

                Console.WriteLine($"{"",-5}{doctor.FirstName}");
                foreach (var patient in doctor.Patients)
                {
                    Console.WriteLine($"{"",-25}{patient.FirstName,-15}");
                }
                if (doctor.Patients.Count()==0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine($"{"",-25} NULL");
                    Console.WriteLine();
                    Console.ResetColor();
                }
                

            }
        }
        
        public static void PatientsPerRoom(List<Room> rooms, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"",-5}{"ROOM",-20}{"PATIENTS",-15}");
            Console.WriteLine();
            Console.ResetColor();

            
            foreach (var room in rooms)
            {
                Console.WriteLine($"{"",-5}{room.Title}");
                foreach (var patient in room.Patients)
                {
                    Console.WriteLine($"{"",-25}{patient.FirstName + " "+ patient.LastName}");
                }
            }
        }
        public static void PatientsPerDoctor(List<Doctor> doctorss, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{"",-5}{"DOCTORS",-23}{"PATIENTS",-15}");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var doctor in doctorss)
            {
                Console.WriteLine($"{"",-5}{doctor.FirstName}");
                foreach (var patient in doctor.Patients)
                {
                    Console.WriteLine($"{"",-25}{patient.FirstName + " " + patient.LastName}");
                }
                if (doctor.Patients.Count==0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine($"{"",-25} NO PATIENTS");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
        }
        public static void PatientsPerAddress(List<Address> addresses, string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"",-5}{"ADDRESSES",-20}{"PATIENTS",-15}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var address in addresses)
            {
                Console.WriteLine($"{"",-5}{address.Name}");
                foreach (var patient in address.Patients)
                {
                    Console.WriteLine($"{"",-25}{patient.FirstName + " " + patient.LastName}");
                }
            }
        }
        public static void AddressPerPatient(List<Patient> patients, string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"",-5}{"PATIENT",-30}{"ADDRESSES",-15}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var patient in patients)
            {
                Console.WriteLine($"{"",-5}{patient.FirstName + " " + patient.LastName}");
                foreach (var address in patient.Addresses)
                {
                    Console.WriteLine($"{"",-30}{address.Name + " " + address.City}");
                }
            }
        }

        public static void FilterDoctorsByFirstname(List<Doctor> doctors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the doctors Firstname please: ");
            Console.WriteLine();
            Console.ResetColor();
            string doctorsname = Console.ReadLine();
            var FilteredDoctor = doctors.Where(x => x.FirstName.Contains(doctorsname)).ToList();

            if (FilteredDoctor.Count==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no doctor name with '{doctorsname}'");
                Console.ResetColor();
            }
            else
            {
                View.Doctors(FilteredDoctor, message);          
            }
        }

        public static void FilterPatientsByAge(List<Patient> patients, string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; ;
            Console.WriteLine("Enter the patients Age please: ");
            Console.ResetColor();
            string patientage = Console.ReadLine();
            Console.WriteLine();
            var FilteredPatient = patients.Where(x => x.Age.ToString().Contains(patientage)).ToList();

            if (FilteredPatient.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is no patient with age '{patientage}'");
                Console.ResetColor();
            }
            else
            {
                View.Patients(FilteredPatient, message);
            }
        }

        public static void FilterRoomsByTitlandPatients(List<Room> rooms, string message)
        {
            foreach (var room in rooms)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter title name letter: ");
                Console.ResetColor();
                Console.WriteLine();
                string roombytitle = Console.ReadLine();
                var Filteredroomtitle = rooms.Where(x => x.Title.Contains(roombytitle)).ToList();
                foreach (var patient in room.Patients)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Enter the number of patients: ");
                    Console.ResetColor();
                    Console.WriteLine();
                    string roombypatients=Console.ReadLine();
                    Filteredroomtitle = Filteredroomtitle.Where(x => x.Patients.Count.ToString().Contains(roombypatients)).ToList();
                    
                    if (Filteredroomtitle.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"There is no room title with '{roombytitle}' or patient number '{roombypatients}'");
                        Console.ResetColor();
                    }
                    else
                    {
                        View.Rooms(Filteredroomtitle, message);
                    }
                    break;
                }
                break;
                
            }
            
        }          
        
        public static void DoctorsCount(List<Doctor> doctors, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"Number of Doctors is: {doctors.Count() }");
        }

        public static void PatientsCount(List<Patient> patients, string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"Number of Patients is: {patients.Count() }");
        }

        public static void PatientsByRoom(List<Room> rooms, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"",-5}{"ROOM",-20}{"NUMBER OF PATIENTS",-15}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var room in rooms)
            {
                Console.WriteLine($"{"",-4}{room.Title}");
                int patients = room.Patients.Count();
                Console.WriteLine($"{"",-30}{patients}");
                
            }


        }

        

     }
     
    

    
}
