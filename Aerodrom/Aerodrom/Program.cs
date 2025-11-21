namespace Aerodrom
{
    public class Program
    {
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
                        break;

                    case "2":
                        break;

                    case "3":
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
    }
}
