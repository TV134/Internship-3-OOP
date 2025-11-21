namespace Aerodrom.classes
{
    public class Flight : Base
    {
        public string FlightName { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public double Distance { get; set; }
        public double Duration { get; set; }

        public Flight(string flightName, DateTime departureTime, DateTime arrivalTime, double distance, int duration) : base()
        {
            this.FlightName = flightName;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.Distance = distance;
            this.Duration = CalculateDuration();
        }

        public override void Description()
        {
            Console.WriteLine($"{this.FlightName} - {this.DepartureTime} - {this.ArrivalTime} - {this.Distance} - {this.Duration}");
        }

        private double CalculateDuration()
        {
            return (this.ArrivalTime - this.DepartureTime).TotalMinutes;
        }
    }
}
