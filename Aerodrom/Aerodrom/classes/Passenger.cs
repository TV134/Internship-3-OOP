namespace Aerodrom.classes
{
    public class Passenger : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get;set;}
        
        public int YearOfBirth { get; set; }
        public string Password { get; set; }
        public Passenger(string name, string surname, string email, int yearOfBirth, string password) : base()
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.YearOfBirth = yearOfBirth;
            this.Password = password;
        }
    }
}
