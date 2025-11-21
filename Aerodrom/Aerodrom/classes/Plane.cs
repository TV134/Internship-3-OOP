namespace Aerodrom.classes
{
    public class Plane : Base
    {
        public string Name { get; set; }
        public int YearOfCreation { get; set; }
        public int Capacity { get; set; }
        public int NumberOfFlights { get; set; }
        public Category Category { get; set; }
        public Plane() : base()
        {
        }
    }
}
