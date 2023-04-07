using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Final_Assessment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string X;
            AllData AD = new AllData();
           
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Choose one of the following: ");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 - View All Doctors");
                Console.WriteLine("2 - View All Addresses");
                Console.WriteLine("3 - View All Patients");
                Console.WriteLine("4 - View All Rooms");
                Console.WriteLine("5 - View All Patients Per Room");
                Console.WriteLine("6 - View All Patients Per Doctor");
                Console.WriteLine("7 - View All Patients Per Address");
                Console.WriteLine("8 - View All Addresses Per Patient");
                Console.WriteLine("9 - View All Doctors By FirstName");
                Console.WriteLine("10 - Rooms Filtered By Title and Number of Patients");
                Console.WriteLine("11 - All Patients By Age");
                Console.WriteLine("12 - All Doctors  Ascending By FirstName");
                Console.WriteLine("13 - All Addresses Descending By Country");
                Console.WriteLine("14 - All Patients Ascending By Age");
                Console.WriteLine("15 - All Rooms Ascending By Title");
                Console.WriteLine("16 - Number of Doctors");
                Console.WriteLine("17 - Number of  Patients");
                Console.WriteLine("18 - Patients Per Room");
                Console.WriteLine("19 - Firstname of Doctors and of Patients By AscendingOrder");
                Console.ResetColor();
                X = Console.ReadLine();
                Console.Clear();

                switch (X)
                {

                    case "1": View.Doctors(AD.Doctors , "All Doctors"); break;
                    case "2": View.Addresses(AD.Addresses, "All Addresses"); break;
                    case "3": View.Patients(AD.Patients, "All Patients"); break;
                    case "4": View.Rooms(AD.Rooms, "All Rooms"); break;
                    case "5": View.PatientsPerRoom(AD.Rooms,"All Patients Per Rooms"); break;
                    case "6": View.PatientsPerDoctor(AD.Doctors,"All Patients Per Doctors"); break;
                    case "7": View.PatientsPerAddress(AD.Addresses,"All Patients Per Addresses"); break;
                    case "8": View.AddressPerPatient(AD.Patients,"All Addresses Per Patients"); break;
                    case "9": View.FilterDoctorsByFirstname(AD.Doctors,"Doctors Filtered by FirstName"); break;
                    case "10": View.FilterRoomsByTitlandPatients(AD.Rooms,"Rooms Filtered By Title and Number of Patients"); break;
                    case "11": View.FilterPatientsByAge(AD.Patients,"Patients Filtered By Age"); break;
                    case "12": View.Doctors(AD.Doctors.OrderBy(x => x.FirstName).ToList(), "All Doctors  Ascending By FirstName");  break;
                    case "13": View.Addresses(AD.Addresses.OrderByDescending(x => x.Country).ToList(), "All Addresses Descending By Country");  break;
                    case "14": View.Patients(AD.Patients.OrderBy(x => x.Age).ToList(), "All Patients Ascending By Age");  break;
                    case "15": View.Rooms(AD.Rooms.OrderBy(x => x.Title).ToList(), "All Rooms Ascending By Title");  break;
                    case "16": View.DoctorsCount(AD.Doctors, "Number of Doctors");  break;
                    case "17": View.PatientsCount(AD.Patients, "Number of  Patients");  break;
                    case "18": View.PatientsByRoom(AD.Rooms, "Patients Per Room");  break;
                    case "19": View.Inheritence(AD.Doctors.OrderBy(x=>x.FirstName).ToList(),"Firstname of Doctors and Firstname of Patients By AscendingOrder");  break;
                    
                    case "stop": break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("WRONG OPTION PLEASE TRY AGAIN");
                        Console.ResetColor(); break;

                }
            } while (X != "stop");




        }
    }
     
    

    
}
