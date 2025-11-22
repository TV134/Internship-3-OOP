namespace Aerodrom.classes
{
    public class Flight : Base
    { 
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public double Distance { get; set; }
        public double Duration { get; set; }
        public Plane Plane { get; set; }
        public Crew Crew { get; set; }
        public string LocStart { get; set; }
        public string LocEnd { get; set; }

        public Flight(string name, DateTime departureTime, DateTime arrivalTime, double distance, Plane plane, Crew crew, string locStart, string locEnd) : base(name)
        {
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.Distance = distance;
            this.Duration = CalculateDuration();
            this.Plane = plane;
            this.Crew = crew;
            this.LocStart = locStart;
            this.LocEnd = locEnd;
        }

        public override void Description()
        {
            Console.WriteLine($"{this.Name} - {this.DepartureTime} - {this.ArrivalTime} - {this.Distance} - {this.Duration}");
        }

        private double CalculateDuration()
        {
            return (this.ArrivalTime - this.DepartureTime).TotalHours;
        }
    }
}
