namespace Aerodrom.classes
{
    public class Crew : Base
    {
        public List<Employee> Employees { get; set; }
        public Crew(string name, List<Employee> employees) : base(name)
        {
            this.Employees = employees;
        }

        public override void Description()
        {
            Console.WriteLine($"{this.Name}");
            foreach (var employee in this.Employees)
            {
                employee.Description();
            }
        }

    }
}
