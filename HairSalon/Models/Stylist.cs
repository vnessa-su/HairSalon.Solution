using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public string Address {get; set;}
    public virtual ICollection<Client> Clients {get; set;}

    [Display(Name = "Phone Number")]
    public string PhoneNumber {get; set;}

    [Display(Name = "Stylist Level")]
    public string StylistLevel {get; set;}

    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
  }
}