using Aerodrom.classes;
using System.Xml.Linq;

namespace Aerodrom
{
    public class Program
    {
        static List<Employee> employees = new List<Employee>
        {
            new Employee("Marko","Horvat",Position.Captain,new DateTime(1980,5,12),Gender.Male),
            new Employee("Ivan","Kovač",Position.Copilot,new DateTime(1987,3,2),Gender.Male),
            new Employee("Ana","Marić",Position.Steward,new DateTime(1990,9,21),Gender.Female),
            new Employee("Laura","Barišić",Position.Steward,new DateTime(1996,1,14),Gender.Female),
            new Employee("Petar","Jurić",Position.Captain,new DateTime(1978,11,5),Gender.Male),
            new Employee("Sara","Rajić",Position.Copilot,new DateTime(1989,6,30),Gender.Female),
            new Employee("Maja","Perić",Position.Steward,new DateTime(1991,12,8),Gender.Female),
            new Employee("Tomislav","Novak",Position.Steward,new DateTime(1997,4,18),Gender.Male)
        };
        static List<Crew> crews = new List<Crew>
        {
            new Crew("Posada 1", new List<Employee> { employees[0], employees[1], employees[2], employees[3]})
        };
        static void Main(string[] args)
        {
            string? menu = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Putnici\r\n2 - Letovi\r\n3 – Avioni\r\n4 – Posada\r\n5 – Izlaz iz programa\r\n");

                Console.Write("Odabir: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        PassengerMenu();
                        break;

                    case "2":
                        FlightMenu();
                        break;

                    case "3":
                        AirplaneMenu();
                        break;

                    case "4":
                        CrewMenu();
                        break;

                    case "5":
                        Console.WriteLine("Izlaz iz programa");
                        break;

                    default:
                        Console.WriteLine("Krivi unos");
                        break;
                }
                Console.WriteLine("Klikni tipku za nastavak");
                Console.ReadKey();
            }
            while (menu != "5");
        }

        static void PassengerMenu()
        {
            string? menu = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Registracija\r\n2 - Prijava\r\n3 – Povratak na prethodni izbornik\r\n");

                Console.Write("Odabir: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        Console.WriteLine("Povratak na prethodni izbornik");
                        break;

                    default:
                        Console.WriteLine("Krivi unos");
                        break;
                }
                Console.WriteLine("Klikni tipku za nastavak");
                Console.ReadKey();
            }
            while (menu != "3");
        }

        static void FlightMenu()
        {
            string? menu = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Prikaz svih letova\r\n2 - Dodavanje leta\r\n3 - Pretraga leta\r\n4 - Uređivanje leta\r\n5 - Brisanje leta\r\n6 – Povratak na prethodni izbornik\r\n");

                Console.Write("Odabir: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        Console.WriteLine("Povratak na prethodni izbornik");
                        break;

                    default:
                        Console.WriteLine("Krivi unos");
                        break;
                }
                Console.WriteLine("Klikni tipku za nastavak");
                Console.ReadKey();
            }
            while (menu != "6");
        }

        static void AirplaneMenu()
        {
            string? menu = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Prikaz svih aviona\r\n2 - Dodavanje novog aviona\r\n3 - Pretraga aviona\r\n4 - Brisnaje aviona\r\n5 – Povratak na prethodni izbornik\r\n");

                Console.Write("Odabir: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        Console.WriteLine("Povratak na prethodni izbornik");
                        break;

                    default:
                        Console.WriteLine("Krivi unos");
                        break;
                }
                Console.WriteLine("Klikni tipku za nastavak");
                Console.ReadKey();
            }
            while (menu != "5");
        }

        static void CrewMenu()
        {
            string? menu = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Prikaz svih posada\r\n2 - Dodavanje nove posade\r\n3 - Dodavanje osobe\r\n4 – Povratak na prethodni izbornik\r\n");

                Console.Write("Odabir: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        foreach (var crew in crews)
                        {
                            Console.WriteLine("Posada: ");
                            crew.Description();
                        }
                        break;

                    case "2":
                        AddCrew();
                        break;

                    case "3":
                        AddEmployee();
                        break;

                    case "4":
                        Console.WriteLine("Povratak na prethodni izbornik");
                        break;

                    default:
                        Console.WriteLine("Krivi unos");
                        break;
                }
                Console.WriteLine("Klikni tipku za nastavak");
                Console.ReadKey();
            }
            while (menu != "4");
        }
        static void AddEmployee()
        {
            Employee newEmployee=new Employee();
            Console.Write("Unesite ime: ");
            string? name = Console.ReadLine();
            while (newEmployee.IsValidName(name))
            {
                Console.Write("Ime ne sadrži slova. Unesite ime: ");
                name = Console.ReadLine();
            }
            newEmployee.Name = name;

            Console.Write("Unesite prezime: ");
            string? surname = Console.ReadLine();
            while (newEmployee.IsValidName(surname))
            {
                Console.Write("Prezime ne sadrži slova. Unesite prezime: ");
                surname = Console.ReadLine();
            }
            newEmployee.Surname = surname;

            Console.WriteLine("Odaberite poziciju: \r\n1 - Captain\r\n2 - Copilot\r\n3 - Steward");
            string? position = Console.ReadLine();
            while (true)
            {
                if (position=="1" || position=="2" || position=="3")
                {
                    break;
                }
                Console.Write("Krivi unos. Odaberite poziciju: ");
                position = Console.ReadLine();
            }
            newEmployee.Job = position=="1" ? Position.Captain : position=="2" ? Position.Copilot : Position.Steward;

            DateTime birthDay;
            bool validDate = false;
            do
            {
                Console.Write("Unesi datum rođenja (YYYY/MM/DD): ");
                validDate = DateTime.TryParse(Console.ReadLine(), out birthDay);
            }
            while (!validDate || (birthDay >= DateTime.Now || birthDay.Year < 1930));

            newEmployee.BirthDate = birthDay;

            Console.WriteLine("Odaberite spol: \r\n1 - Muško\r\n2 - Žensko");
            string? gender = Console.ReadLine();
            while (true)
            {
                if (gender == "1" || gender == "2")
                {
                    break;
                }
                Console.Write("Krivi unos. Odaberite spol: ");
                gender = Console.ReadLine();
            }
            newEmployee.Gender = gender == "1" ? Gender.Male : Gender.Female;

            employees.Add(newEmployee);
            Console.WriteLine("Unesen novi zaposlenik");
        }

        static void AddCrew()
        {
            var notInCrew = employees.Where(e => !crews.SelectMany(c => c.Employees).Contains(e)).ToList();
            var availableCaptains= notInCrew.Where(e => e.Job == Position.Captain).ToList();
            var availableCopilots= notInCrew.Where(e => e.Job == Position.Copilot).ToList();
            var availableStewards= notInCrew.Where(e => e.Job == Position.Steward).ToList();
            Console.Write("Unesite naziv posade: ");
            string? crewName = Console.ReadLine();
            var captain = SelectEmployee(Position.Captain, availableCaptains);
            var copilot = SelectEmployee(Position.Copilot, availableCopilots);
            var steward1 = SelectEmployee(Position.Steward, availableStewards);
            var steward2 = SelectEmployee(Position.Steward, availableStewards.Where(e => e!=steward1).ToList());
            if (captain==null || copilot==null || steward1==null || steward2==null)
            {
                Console.WriteLine("Nema dovoljno dostupnih zaposlenika za formiranje posade.");
                return;
            }
            
            Crew newCrew = new Crew(crewName, new List<Employee> { captain, copilot, steward1, steward2 });
            crews.Add(newCrew);
            Console.WriteLine("Unesena nova posada");

        }
        static Employee SelectEmployee(Position position, List<Employee> availableEmployees)
        {
            Console.WriteLine($"Unesi {position}:");
            var selectForCrew=availableEmployees.Where(e => e.Job == position).ToList();
            if (selectForCrew.Count<1)
            {
                return null;
            }
            List<int> number=new List<int>();
            for (int i = 0; i < selectForCrew.Count; i++)
            {
                Console.WriteLine($"{i}: ");
                selectForCrew[i].Description();
            }
            bool validNumber = false;
            int inputNumber;
            do
            {
                Console.Write("Unesi broj zaposlenika: ");
                validNumber = int.TryParse(Console.ReadLine(), out inputNumber);

            }
            while (!validNumber && !number.Contains(inputNumber));

            return selectForCrew[inputNumber];
        }
    }
}