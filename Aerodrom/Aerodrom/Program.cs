using Aerodrom.classes;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
        static List<Plane> planes = new List<Plane>
        {
            new Plane("Boeing 737", 2010, 180, new Dictionary<Category,int>{{Category.Standard,150 },{Category.Buisness,30 }}),
            new Plane("Airbus A320", 2015, 160, new Dictionary<Category,int>{{Category.Standard,140 },{Category.VIP,20 }}),
            new Plane("Embraer E190", 2012, 90, new Dictionary<Category,int>{{Category.Standard,90 }})
        };
        static List<Flight> Flights = new List<Flight>
        {
            new Flight("LH123", new DateTime(2025,11,21,10,0,0), new DateTime(2025,11,21,12,30,0), 1500,planes[0],crews[0],"Split"),
            new Flight("AF456", new DateTime(2025,11,22,14,0,0), new DateTime(2025,11,22,17,0,0), 2200,planes[1],crews[0],"Tokyo"),
            new Flight("BA789", new DateTime(2025,11,23,8,0,0), new DateTime(2025,11,23,10,15,0), 1300,planes[2],crews[0],"Frankfurt")
        };
        static List<Passenger> passengers = new List<Passenger>
        {
            new Passenger("Ivan", "Horvat", "ivan.horvat@gmail.com", "ivan123", new List<Flight>
            {
                Flights[0], Flights[1]
            }),
            new Passenger("Ana", "Kovač", "ana.kovac@gmail.com", "ana123", new List<Flight>
            {
                Flights[2]
            }),

            new Passenger("Marko", "Barić", "marko.baric@gmail.com", "marko123", new List<Flight>
            {
                Flights[0],Flights[1],Flights[2]
            }),
            new Passenger("Lucija", "Perić", "lucija.peric@gmail.com", "lucija123",new List<Flight>
            {
                Flights[0]
            }),
        };

        static Dictionary<string, string> passengerLog = new Dictionary<string, string>
        {
            { "ivan.horvat@gmail.com", "ivan123" },
            { "ana.kovac@gmail.com", "ana123" },
            { "marko.baric@gmail.com", "marko123" },
            { "lucija.peric@gmail.com", "lucija123" }
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
                        Registration();
                        break;

                    case "2":
                        var logedPassenger = Login();
                        if (logedPassenger == null)
                            return;
                        AdditionalMenu(logedPassenger);
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
                        foreach (var flight in Flights)
                        {
                            flight.Description();
                        }
                        break;

                    case "2":
                        AddFlight();
                        break;

                    case "3":
                        string? choice = FindMethod();
                        Search(choice, Flights);
                        break;

                    case "4":
                        UpdateFlight(Flights);
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
                string? choice;

                switch (menu)
                {
                    case "1":
                        foreach (var plane in planes)
                        {
                            plane.Description();
                        }
                        break;

                    case "2":
                        Plane newPlane = AddPlane();
                        planes.Add(newPlane);
                        Console.WriteLine("Avion unesen");
                        break;

                    case "3":
                        choice = FindMethod();
                        Search(choice, planes);
                        break;

                    case "4":
                        choice = FindMethod();
                        DeletePlane(choice);
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
            Employee newEmployee = new Employee();
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
                if (position == "1" || position == "2" || position == "3")
                {
                    break;
                }
                Console.Write("Krivi unos. Odaberite poziciju: ");
                position = Console.ReadLine();
            }
            newEmployee.Job = position == "1" ? Position.Captain : position == "2" ? Position.Copilot : Position.Steward;

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
            var availableCaptains = notInCrew.Where(e => e.Job == Position.Captain).ToList();
            var availableCopilots = notInCrew.Where(e => e.Job == Position.Copilot).ToList();
            var availableStewards = notInCrew.Where(e => e.Job == Position.Steward).ToList();
            Console.Write("Unesite naziv posade: ");
            string? crewName = Console.ReadLine();
            var captain = SelectEmployee(Position.Captain, availableCaptains);
            var copilot = SelectEmployee(Position.Copilot, availableCopilots);
            var steward1 = SelectEmployee(Position.Steward, availableStewards);
            var steward2 = SelectEmployee(Position.Steward, availableStewards.Where(e => e != steward1).ToList());
            if (captain == null || copilot == null || steward1 == null || steward2 == null)
            {
                Console.WriteLine("Nema dovoljno zaposlenika za formiranje posade.");
                return;
            }

            Crew newCrew = new Crew(crewName, new List<Employee> { captain, copilot, steward1, steward2 });
            crews.Add(newCrew);
            Console.WriteLine("Unesena nova posada");

        }
        static Employee SelectEmployee(Position position, List<Employee> availableEmployees)
        {
            Console.WriteLine($"Unesi {position}:");
            var selectForCrew = availableEmployees.Where(e => e.Job == position).ToList();
            if (selectForCrew.Count < 1)
            {
                return null;
            }
            List<int> number = new List<int>();
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

        static Plane AddPlane()
        {
            Plane newPlane = new Plane();
            Console.Write("Unesite ime: ");
            string? name = Console.ReadLine();
            while (newPlane.IsValidName(name))
            {
                Console.Write("Ime ne sadrži slova. Unesite ime: ");
                name = Console.ReadLine();
            }
            newPlane.Name = name;

            int yearOfCreation;
            bool validYear = false;
            do
            {
                Console.Write("Unesi godinu proizvodnje: ");
                validYear = int.TryParse(Console.ReadLine(), out yearOfCreation);
            } while (!validYear || yearOfCreation < 1900 || yearOfCreation > DateTime.Now.Year);

            newPlane.YearOfCreation = yearOfCreation;

            while (newPlane.Categories.Count == 0)
            {
                foreach (var category in Enum.GetValues(typeof(Category)))
                {
                    Console.WriteLine($"Želiš li unijeti {category} (Y/N)");
                    string yesNo = Console.ReadLine().ToUpper();
                    if (yesNo == "Y")
                    {
                        int seats;
                        bool validSeats = false;
                        do
                        {
                            Console.Write($"Unesi broj sjedala za kategoriju {category}: ");
                            validSeats = int.TryParse(Console.ReadLine(), out seats);
                        } while (!validSeats || seats < 0);
                        newPlane.Categories.Add((Category)category, seats);
                    }
                }
            }

            newPlane.Capacity = newPlane.Categories.Sum(c => c.Value);

            newPlane.NumberOfFlights = 0;

            return newPlane;
        }

        static (bool, T) FindById<T>(List<T> list, Guid id) where T : Base
        {
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    return (true, item);
                }
            }
            return (false, null);
        }
        static (bool, T) FindByName<T>(List<T> list, string name) where T : Base
        {
            foreach (var item in list)
            {
                if (item.Name.ToLower().CompareTo(name.ToLower()) == 0)
                {
                    return (true, item);
                }
            }
            return (false, null);
        }

        static void Search<T>(string choice, List<T> list) where T : Base
        {
            bool found = false;
            T item = null;
            if (choice == "1")
            {
                Console.Write("Unesi ID: ");
                if (Guid.TryParse(Console.ReadLine(), out Guid id))
                {
                    (found, item) = FindById(list, id);
                }

            }
            else if (choice == "2")
            {
                Console.Write("Unesi naziv: ");
                string name = Console.ReadLine();
                (found, item) = FindByName(list, name);
            }
            if (!found)
            {
                Console.WriteLine("Informacija nije pronađena.");
                return;
            }

            item.Description();


        }
        static string FindMethod()
        {
            string? choice = "";
            do
            {
                Console.WriteLine("Pretraga po:1 - ID, 2 - Nazivu: ");
                choice = Console.ReadLine();
            }
            while (choice != "1" && choice != "2");
            return choice;
        }
        static void DeletePlane(string choice)
        {
            bool found = false;
            Plane item = null;
            if (choice == "1")
            {
                Console.Write("Unesi ID: ");
                if (Guid.TryParse(Console.ReadLine(), out Guid id))
                {
                    (found, item) = FindById(planes, id);
                }

            }
            else if (choice == "2")
            {
                Console.Write("Unesi naziv: ");
                string name = Console.ReadLine();
                (found, item) = FindByName(planes, name);
            }
            if (!found)
            {
                Console.WriteLine("Informacija nije pronađena.");
                return;
            }

            bool confirm = Confirm();
            if (!confirm)
            {
                Console.WriteLine("Brisanje otkazano.");
                return;
            }
            planes.Remove(item);
            Console.WriteLine("Informacija obrisana.");

        }
        static void UpdateFlight(List<Flight> flights)
        {
            bool found = false;
            Flight item = null;
            Console.Write("Unesi ID: ");
            if (Guid.TryParse(Console.ReadLine(), out Guid id))
            {
                (found, item) = FindById(flights, id);
            }
            if (!found)
            {
                Console.WriteLine("Informacija nije pronađena.");
                return;
            }

            DateTime departure;
            bool validDate = false;
            do
            {
                Console.Write("Unesi datum polaska: ");
                validDate = DateTime.TryParse(Console.ReadLine(), out departure);
            }
            while (!validDate || (departure <= DateTime.Now));

            DateTime arival;
            bool validArrive = false;
            do
            {
                Console.Write("Unesi datum dolaska: ");
                validArrive = DateTime.TryParse(Console.ReadLine(), out arival);
            }
            while (!validArrive || (arival <= DateTime.Now));

            bool confirm = Confirm();
            if (!confirm)
            {
                Console.WriteLine("Ažuriranje otkazano.");
                return;
            }

            item.Crew = PickList(crews);
            item.ArrivalTime = arival;
            item.DepartureTime = departure;
            item.Duration = item.CalculateDuration();

        }

        static void AddFlight()
        {
            Flight newFlight = new Flight();
            Console.Write("Unesite ime: ");
            string? name = Console.ReadLine();
            while (newFlight.IsValidName(name))
            {
                Console.Write("Ime ne sadrži slova. Unesite ime: ");
                name = Console.ReadLine();
            }

            Console.Write("Unesite mjesto: ");
            string? place = Console.ReadLine();
            while (newFlight.IsValidName(place))
            {
                Console.Write("Prezime ne sadrži slova. Unesite prezime: ");
                place = Console.ReadLine();
            }

            DateTime departure;
            bool validDate = false;
            do
            {
                Console.Write("Unesi datum polaska: ");
                validDate = DateTime.TryParse(Console.ReadLine(), out departure);
            }
            while (!validDate || (departure <= DateTime.Now));

            DateTime arival;
            bool validArrive = false;
            do
            {
                Console.Write("Unesi datum dolaska: ");
                validArrive = DateTime.TryParse(Console.ReadLine(), out arival);
            }
            while (!validArrive || (arival <= DateTime.Now));

            int distance;
            bool validNumber = false;
            do
            {
                Console.Write("Unesi udaljenost: ");
                validNumber = int.TryParse(Console.ReadLine(), out distance);
            }
            while (!validNumber || (distance <= 0));

            newFlight.Crew = PickList(crews);
            newFlight.Plane = PickList(planes);
            newFlight.Name = name;
            newFlight.Distance = distance;
            newFlight.DepartureTime = departure;
            newFlight.ArrivalTime = arival;
            newFlight.LocStart = place;
            newFlight.Duration = newFlight.CalculateDuration();
            Flights.Add(newFlight);
            Console.WriteLine("Let unesen");
        }

        static T PickList<T>(List<T> list) where T : Base
        {
            List<int> number = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}: ");
                list[i].Description();
            }
            bool validNumber = false;
            int inputNumber;
            do
            {
                Console.Write("Unesi broj izbora: ");
                validNumber = int.TryParse(Console.ReadLine(), out inputNumber);

            }
            while (!validNumber || inputNumber < 0 || inputNumber >= list.Count);
            return list[inputNumber];
        }

        static bool Confirm()
        {
            Console.WriteLine($"Potvrdi: (Y/N)");
            string yesNo = Console.ReadLine().ToUpper();
            return yesNo == "Y" ? true : false;
        }
        //static void DeleteFlight()
        //{
        //    bool found = false;
        //    Flight item = null;

        //    Console.Write("Unesi ID: ");
        //    if (Guid.TryParse(Console.ReadLine(), out Guid id))
        //    {
        //        (found, item) = FindById(Flights, id);
        //    }

        //    if (!found || item.)
        //    {
        //        Console.WriteLine("Informacija nije pronađena.");
        //        return;
        //    }

        //    bool confirm = Confirm();
        //    if (!confirm)
        //    {
        //        Console.WriteLine("Brisanje otkazano.");
        //        return;
        //    }

        //    Flights.Remove(item);
        //    Console.WriteLine("Informacija obrisana.");
        //}

        static void Registration()
        {
            Console.Write("Ime: ");
            string? name = Console.ReadLine();

            Console.Write("Prezime: ");
            string? surname = Console.ReadLine();

            string? email = "";
            while (!email.Contains('@') & email.Length < 3)
            {
                Console.Write("Email: ");
                email = Console.ReadLine();

                if (passengerLog.ContainsKey(email))
                {
                    Console.WriteLine("Email već postoji.");
                    return;
                }
            }

            Console.Write("Lozinka: ");
            string? password = Console.ReadLine();
            while (password.Length < 6)
            {
                Console.Write("Lozinka: ");
                password = Console.ReadLine();
            }

            Console.Write("Godina rođenja: ");
            string? year = Console.ReadLine();

            Passenger newPassenger = new Passenger(name, surname, email, password, new List<Flight>());
            newPassenger.YearOfBirth = newPassenger.SetYear(year);

            passengerLog.Add(email, password);
            passengers.Add(newPassenger);

            Console.WriteLine("Registracija uspješna!");
        }

        static Passenger Login()
        {
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Lozinka: ");
            string? password = Console.ReadLine();
            if (!passengerLog.ContainsKey(email) && passengerLog[email] != password)
            {
                Console.WriteLine("Neispravan email ili lozinka.");
                return null;
            }
            Console.WriteLine("Uspješno logiranje");
            return passengers.First(p => p.Email == email);
        }
        static void AdditionalMenu(Passenger loged)
        {
            string? menu = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Prikaz svih letova\r\n2 - Odabir leta\r\n3 - Pretraga leta\r\n4 - Otkazivanje leta\r\n5 - Povratak na prethodni izbornik\r\n");

                Console.Write("Odabir: ");
                menu = Console.ReadLine();
                var allFlights = loged.TakenFlights;

                switch (menu)
                {
                    case "1":
                        foreach(var flight in allFlights)
                        {
                            flight.Description();
                        }
                        break;

                    case "2":
                        Flight chosenFlight;
                        Category category;
                        (chosenFlight, category) = PickFlight(loged);
                        loged.FlightAndSeat.Add(chosenFlight, category);
                        break;

                    case "3":
                        string? choice = FindMethod();
                        Search(choice,allFlights);
                        break;

                    case "4":
                        RemoveFlight(allFlights);
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
            }while (menu!="5");
        }
        static void RemoveFlight(List<Flight> logFlights)
        {
            if (logFlights.Count < 1) {
                Console.WriteLine("Ne postoje letovi");
                return;
            }
            Flight chosenFlight=PickList(logFlights);
            bool confirm = Confirm();
            if (!confirm || (chosenFlight.DepartureTime - DateTime.Now).TotalHours <= 24)
            { 
                Console.WriteLine("Otkazano brisanje");
                return;
            }
            logFlights.Remove(chosenFlight);
            Console.WriteLine("Izbrisan let");
        }
        static (Flight,Category) PickFlight(Passenger loged)
        {
            var availableFlights = Flights.Where(f => !loged.TakenFlights.Contains(f)).ToList();

            Flight chosenFlight = PickList(availableFlights);

            Console.WriteLine("\nKategorije na ovom letu:");
            var categories = chosenFlight.Plane.Categories.Keys.ToList();

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i} - {categories[i]}");
            }

            int inputNumber;
            do
            {
                Console.Write("Odaberi kategoriju: ");
            }
            while (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < 0 || inputNumber >= categories.Count);

            Category chosenCategory = categories[inputNumber];

            return (chosenFlight, chosenCategory);

        }
    }
}