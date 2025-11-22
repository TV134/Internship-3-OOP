namespace Aerodrom.classes
{
    abstract public class Base
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Name { get; set; }
        public Base(string name) { 
            this.Id= Guid.NewGuid();
            this.CreateDate= DateTime.Now;
            this.UpdateDate= DateTime.Now;
            this.Name= name;
        }
        public Base()
        {
            this.Id = Guid.NewGuid();
            this.CreateDate = DateTime.Now;
            this.UpdateDate = DateTime.Now;
            this.Name = "";
        }
        virtual public void Description() { }

        public void UpdateToNow()
        {
            this.UpdateDate = DateTime.Now;
        }
        public bool IsValidName(string name)
        {
            return name=="" || !name.All(c=>char.IsLetter(c));
        }

        public bool isValidDate(DateTime date)
        {
            return date.Year<1900 || date.Year>DateTime.Now.Year;
        }

        public virtual Guid GetId() { return Guid.Empty; }
        public virtual string GetName() { return ""; }
    }
}
