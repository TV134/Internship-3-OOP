namespace Aerodrom.classes
{
    public class Employee : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Job { get; set; }
        public DateOnly BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Employee(string name, string surname, Position job, DateOnly date, Gender gender) : base()
        {
            this.Name = name;
            this.Surname = surname;
            this.Job = job;
            this.BirthDate = date;
            this.Gender = gender;
        }
        public override void Description()
        {
            Console.WriteLine($"\t{this.Name} - {this.Surname} - {this.Job} - {this.Gender} - {this.BirthDate}");
        }
    }
}
