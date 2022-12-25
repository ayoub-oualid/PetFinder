using System.ComponentModel.DataAnnotations;

namespace PetFinder.Models;



public class Pet
{

    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime? BirthDay { get; set; }
    public string? Race { get; set; }
}