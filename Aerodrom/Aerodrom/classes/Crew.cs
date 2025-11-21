namespace Aerodrom.classes
{
    public class Crew : Base
    {
        public string CrewName { get; set; }
        public List<Employee> Employees { get; set; }
        public Crew( string crewName, List<Employee> employees) : base()
        {
            this.CrewName = crewName;
            this.Employees = employees;
        }

        public override void Description()
        {
            Console.WriteLine($"{this.CrewName}");
            foreach (var employee in Employees)
            {
                employee.Description();
            }
        }

    }
}
