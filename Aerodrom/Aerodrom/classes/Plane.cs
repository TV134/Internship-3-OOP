namespace Aerodrom.classes
{
    public class Plane : Base
    {
        public string Name { get; set; }
        public int YearOfCreation { get; set; }
        public int Capacity { get; set; }
        public int NumberOfFlights { get; set; }
        public Dictionary<Category,int> Categories { get; set; }
        public Plane(string name, int yearOfCreation, int capacity, Dictionary<Category,int> categories) : base()
        {
            this.Name = name;
            this.YearOfCreation = yearOfCreation;
            this.Capacity = capacity;
            this.NumberOfFlights = 0;
            this.Categories = categories;
        }

        public Plane() : base()
        {
        }

        public override void Description()
        {
            Console.WriteLine($"{this.Id} - {this.Name} - {this.YearOfCreation} - {this.NumberOfFlights}");
        }
    }
}
