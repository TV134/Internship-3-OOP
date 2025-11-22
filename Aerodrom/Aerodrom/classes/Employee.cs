namespace Aerodrom.classes
{
    public class Employee : Base
    {
        public string Surname { get; set; }
        public Position Job { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Employee(string name, string surname, Position job, DateTime date, Gender gender) : base(name)
        {
            this.Surname = surname;
            this.Job = job;
            this.BirthDate = date;
            this.Gender = gender;
        }
        public Employee() : base()
        {
            
        }
        public override void Description()
        {
            Console.WriteLine($"\t{this.Name} - {this.Surname} - {this.Job} - {this.Gender} - {this.BirthDate}");
        }
    }
}
