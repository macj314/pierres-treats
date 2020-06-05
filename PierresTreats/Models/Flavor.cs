namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<FlavorTreat> Treats { get; set; }
  }
}