namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public string Address {get; set;}
    public int StylistId {get; set;}
    public virtual Stylist Stylist {get; set;}

    [Display(Name = "Phone Number")]
    public string PhoneNumber {get; set;}
  }
}