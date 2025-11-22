namespace Aerodrom.classes
{
    public class Passenger : Base
    {
        public string Surname { get; set; }
        public string Email { get;set;}
        
        public int YearOfBirth { get; set; }
        public string Password { get; set; }
        public List<Flight> TakenFlights { get; set; }
        public Passenger(string name, string surname, string email, string password,List<Flight> flights) : base(name)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.YearOfBirth = 1900;
            this.Password = password;
            this.TakenFlights=flights;
        }

        public int SetYear(string year)
        {
            int value;
            if (!int.TryParse(year, out value))
            {
                value = 1900;
            }
            return value;
        }
    }
}
