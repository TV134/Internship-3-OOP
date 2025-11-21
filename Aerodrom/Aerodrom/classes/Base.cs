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
    }
}
