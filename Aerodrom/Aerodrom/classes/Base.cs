namespace Aerodrom.classes
{
    abstract public class Base
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Base() { 
            this.Id= Guid.NewGuid();
            this.CreateDate= DateTime.Now;
            this.UpdateDate= DateTime.Now;
        }
        virtual public void Description() { }

        protected void UpdateToNow()
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

    }
}
