using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment_2
{
     class AllData
    {

        public List<Patient> Patients = new List<Patient>();
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Room> Rooms { get; set; } = new List<Room>();

        public AllData()
        {
            #region Doctors
            Doctor d1 = new Doctor() { Id = 1, FirstName = "Mike", LastName = "Johson", Age = 32, Salary = 3600 };
            Doctor d2 = new Doctor() { Id = 2, FirstName = "Mitchel", LastName = "Stark", Age = 26, Salary = 2000 };
            Doctor d3 = new Doctor() { Id = 3, FirstName = "John", LastName = "Abraham", Age = 24, Salary = 1600 };
            Doctor d4 = new Doctor() { Id = 4, FirstName = "Ditmitris", LastName = "Athanas", Age = 55, Salary = 5000 };
            Doctor d5 = new Doctor() { Id = 5, FirstName = "Jimmy", LastName = "Neesham", Age = 57, Salary = 5000 };
            Doctor d6 = new Doctor() { Id = 6, FirstName = "James", LastName = "Williamson", Age = 30, Salary = 3600 };
            Doctor d7 = new Doctor() { Id = 7, FirstName = "Muhammad", LastName = "Ali", Age = 38, Salary = 4100 };
            Doctor d8 = new Doctor() { Id = 8, FirstName = "Antonio", LastName = "Vival", Age = 22, Salary = 1000 };
            Doctor d9 = new Doctor() { Id = 9, FirstName = "Marios", LastName = "Bintakos", Age = 59, Salary = 6000 };
            Doctor d10 = new Doctor() { Id = 10, FirstName = "Christine", LastName = "Turner", Age = 27, Salary = 2200 };
            Doctor d11 = new Doctor() { Id = 11, FirstName = "Scarlet", LastName = "Anderson", Age = 22, Salary = 1100 };
            Doctor d12 = new Doctor() { Id = 12, FirstName = "Christopher", LastName = "Linch", Age = 31, Salary = 3400 };
            Doctor d13 = new Doctor() { Id = 13, FirstName = "Maria", LastName = "Papantoniou", Age = 26, Salary = 2100 };

            #endregion

            #region patients
            Patient P1 = new Patient() { Id = 101, FirstName = "Elizabeth", LastName = "Starc", Age = 18, EntryDate = new DateTime(2020, 6, 30, 18, 10, 20), ExitDate = new DateTime(2020, 7, 15, 7, 12, 44) };
            Patient P2 = new Patient() { Id = 102, FirstName = "Natham", LastName = "Liam", Age = 23, EntryDate = new DateTime(2021, 1, 27, 16, 8, 36), ExitDate = new DateTime(2021, 2, 6, 12, 14, 55) };
            Patient P3 = new Patient() { Id = 103, FirstName = "Jennet", LastName = "McCulum", Age = 16, EntryDate = new DateTime(2021, 2, 5, 5, 19, 11), ExitDate = new DateTime(2021, 2, 15, 19, 8, 33) };
            Patient P4 = new Patient() { Id = 104, FirstName = "Sulaiman", LastName = "Shah", Age = 19, EntryDate = new DateTime(2020, 11, 3, 19, 1, 34), ExitDate = new DateTime(2020, 11, 6, 17, 5, 34) };
            Patient P5 = new Patient() { Id = 105, FirstName = "Syed", LastName = "Ali", Age = 20, EntryDate = new DateTime(2020, 11, 5, 21, 10, 50), ExitDate = new DateTime(2020, 11, 25, 9, 11, 50) };
            Patient P6 = new Patient() { Id = 106, FirstName = "Konstantina", LastName = "Bekiou", Age = 22, EntryDate = new DateTime(2020, 9, 11, 5, 16, 11), ExitDate = new DateTime(2020, 9, 15, 8, 22, 41) };
            Patient P7 = new Patient() { Id = 107, FirstName = "Kostas", LastName = "Athanasopoulos", Age = 33, EntryDate = new DateTime(2021, 1, 30, 3, 44, 30), ExitDate = new DateTime(2021, 2, 12, 14, 5, 40) };
            Patient P8 = new Patient() { Id = 108, FirstName = "Brandom", LastName = "McMahon", Age = 37, EntryDate = new DateTime(2021, 2, 26, 13, 10, 24), ExitDate = new DateTime(2021, 3, 1, 17, 22, 57) };
            Patient P9 = new Patient() { Id = 109, FirstName = "Stepheni", LastName = "Clinton", Age = 36, EntryDate = new DateTime(2021, 6, 30, 5, 10, 20), ExitDate = new DateTime(2021, 7, 18, 18, 10, 20) };
            Patient P10 = new Patient() { Id = 1010, FirstName = "Donald", LastName = "Churchil", Age = 17, EntryDate = new DateTime(2020, 8, 23, 22, 34, 45), ExitDate = new DateTime(2020, 8, 28, 14, 30, 15) };
            Patient P11 = new Patient() { Id = 1011, FirstName = "Arthur", LastName = "Solomons", Age = 27, EntryDate = new DateTime(2020, 8, 24, 16, 10, 55), ExitDate = new DateTime(2020, 9, 14, 6, 5, 32) };
            Patient P12 = new Patient() { Id = 1012, FirstName = "Thomas", LastName = "Shelby", Age = 23, EntryDate = new DateTime(2021, 4, 1, 10, 8, 39), ExitDate = new DateTime(2021, 5, 1, 2, 5, 22) };
            Patient P13 = new Patient() { Id = 1013, FirstName = "Emma", LastName = "Duplesis", Age = 33, EntryDate = new DateTime(2021, 2, 20, 15, 10, 43), ExitDate = new DateTime(2021, 2, 26, 22, 40, 43) };
            Patient P14 = new Patient() { Id = 1014, FirstName = "Shane", LastName = "Watson", Age = 33, EntryDate = new DateTime(2020, 12, 12, 18, 9, 21), ExitDate = new DateTime(2021, 1, 3, 9, 45, 21) };
            Patient P15 = new Patient() { Id = 1015, FirstName = "Robert", LastName = "Saleem", Age = 19, EntryDate = new DateTime(2020, 12, 16, 14, 45, 48), ExitDate = new DateTime(2020, 12, 20, 19, 11, 30) };
            #endregion

            #region Addresses
            Address A1 = new Address() { Id = 001, Name = "Sikinou 11", City = "Athens", Country = "Greece", PostalCode = "65302" };
            Address A2 = new Address() { Id = 002, Name = "Ofiounots 9", City = "Athens", Country = "Greece", PostalCode = "11793" };
            Address A3 = new Address() { Id = 003, Name = "123 MEMORY LN", City = "Montreal QC", Country = "Canada", PostalCode = "K2B" };
            Address A4 = new Address() { Id = 004, Name = "118 Boulevard", City = "Paris", Country = "France", PostalCode = "75010" };
            Address A5 = new Address() { Id = 005, Name = "Alphabet Drive 23", City = "Los Angeles", Country = "United States", PostalCode = "06344" };
            Address A6 = new Address() { Id = 006, Name = "1/2 Main ST NW", City = "Montreal QC", Country = "Canada", PostalCode = "A4L" };
            Address A7 = new Address() { Id = 007, Name = "Al Falah St", City = "Dubai", Country = "UAE", PostalCode = "08045" };
            Address A8 = new Address() { Id = 008, Name = "Bu Maharah St", City = "Abu Dhabi", Country = "UAE", PostalCode = "03567" };
            Address A9 = new Address() { Id = 009, Name = "Heswall", City = "Bournemouth", Country = "England", PostalCode = "EC2T 8DY" };
            Address A10 = new Address() { Id = 010, Name ="122King's Road", City = "Riyadh", Country = "Saudi Arabia", PostalCode = "1257" };
            #endregion

            #region Rooms
            Room R1 = new Room() { Id = 100, Title = " ward " };
            Room R2 = new Room() { Id = 101, Title = " emergency " };
            Room R3 = new Room() { Id = 102, Title = " ICU " };
            Room R4 = new Room() { Id = 103, Title = " surgery " };
            Room R5 = new Room() { Id = 104, Title = " pharmecy " };
            Room R6 = new Room() { Id = 105, Title = " sickroom " };
            Room R7 = new Room() { Id = 106, Title = " padded cell " };
            Room R8 = new Room() { Id = 107, Title = " consulting room" };
            #endregion


            #region Lists
            List<Doctor> doctors = new List<Doctor>() { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13 };
            Doctors.AddRange(doctors);

            List<Patient> patients = new List<Patient>() { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15 };
            Patients.AddRange(patients);

            List<Address> addresses = new List<Address>() { A1, A2, A3, A4, A5, A6, A7, A8, A9, A10 };
            Addresses.AddRange(addresses);

            List<Room> rooms = new List<Room>() { R1, R2, R3, R4, R5, R6, R7, R8 };
            Rooms.AddRange(rooms);



            #endregion

            #region patient doctor population

            d1.Patients = new List<Patient>() { P4, };
            d2.Patients = new List<Patient>() { P15 };
            d3.Patients = new List<Patient>() { P3, P7 };
            d4.Patients = new List<Patient>() { P5, P9, P8 };
            d5.Patients = new List<Patient>() { P10 };
            d6.Patients = new List<Patient>() { P1, P11 };
            d7.Patients = new List<Patient>() { P2 };
            d8.Patients = new List<Patient>() { P6 };
            d9.Patients = new List<Patient>() { P14, P12 };
            d10.Patients = new List<Patient>() { P13 };

            P1.Doctors.Add(d6);
            P2.Doctors.Add(d7);
            P3.Doctors.Add(d3);
            P4.Doctors.Add(d1);
            P5.Doctors.Add(d4);
            P6.Doctors.Add(d8);
            P7.Doctors.Add(d3);
            P8.Doctors.Add(d4);
            P9.Doctors.Add(d4);
            P10.Doctors.Add(d5);
            P11.Doctors.Add(d6);
            P12.Doctors.Add(d9);
            P13.Doctors.Add(d10);
            P14.Doctors.Add(d9);
            P15.Doctors.Add(d2);
            #endregion
            #region Populating Addresses with patients
            A1.Patients = new List<Patient>() { P15 };
            A2.Patients = new List<Patient>() { P10 };
            A3.Patients = new List<Patient>() { P1, P4 };
            A4.Patients = new List<Patient>() { P5, P3 };
            A5.Patients = new List<Patient>() { P6 };
            A6.Patients = new List<Patient>() { P11, P2 };
            A7.Patients = new List<Patient>() { P13 };
            A8.Patients = new List<Patient>() { P9 };
            A9.Patients = new List<Patient>() { P12 };
            A10.Patients = new List<Patient>() { P14, P8, P7 };

            P1.Addresses.Add(A3);
            P2.Addresses.Add(A6);
            P3.Addresses.Add(A4);
            P4.Addresses.Add(A3);
            P5.Addresses.Add(A4);
            P6.Addresses.Add(A5);
            P7.Addresses.Add(A10);
            P8.Addresses.Add(A10);
            P9.Addresses.Add(A8);
            P10.Addresses.Add(A2);
            P11.Addresses.Add(A6);
            P12.Addresses.Add(A9);
            P13.Addresses.Add(A7);
            P14.Addresses.Add(A10);
            P15.Addresses.Add(A1);
            #endregion
            #region populating rooms with patients
            R1.Patients = new List<Patient>() { P3, P8, P9 };
            R2.Patients = new List<Patient>() { P2 };
            R3.Patients = new List<Patient>() { P4, P15 };
            R4.Patients = new List<Patient>() { P10, P1, P6 };
            R5.Patients = new List<Patient>() { P11 };
            R6.Patients = new List<Patient>() { P13, P7 };
            R7.Patients = new List<Patient>() { P12 };
            R8.Patients = new List<Patient>() { P14, P5 };

            P1.Rooms.Add(R4);
            P2.Rooms.Add(R2);
            P3.Rooms.Add(R1);
            P4.Rooms.Add(R3);
            P5.Rooms.Add(R8);
            P6.Rooms.Add(R4);
            P7.Rooms.Add(R6);
            P8.Rooms.Add(R1);
            #endregion
        }



    }
}
