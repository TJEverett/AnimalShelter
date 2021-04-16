using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public bool Gender { get; set; } //true = male; false = female
    public string Species { get; set; }
    public string ColorPattern { get; set; }
    public DateTime Birthday { get; set; }
    public DateTime Admitted { get; set; }
  }
}