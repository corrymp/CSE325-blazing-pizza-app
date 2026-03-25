using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(2,
        ErrorMessage = "Please use a name with at least two letters."), MaxLength(100,
        ErrorMessage = "Please use a name with no more than 100 letters.")]
        public string Name { get; set; }

        [Required, MinLength(5,
        ErrorMessage = "Please use an address with at least five letters."), MaxLength(100,
        ErrorMessage = "Please use an address no more than 100 letters.")]
        public string Line1 { get; set; }

        [MaxLength(100,
        ErrorMessage = "Please use an address no more than 100 letters.")]
        public string Line2 { get; set; }

        [Required, MinLength(3,
        ErrorMessage = "Please use a city with at least three letters."), MaxLength(50,
        ErrorMessage = "Please use a city with at most 50 letters.")]
        public string City { get; set; }

        [Required, MinLength(3,
        ErrorMessage = "Please use a region at least three letters."), MaxLength(20,
        ErrorMessage = "Please use a region no more than 20 letters.")]
        public string Region { get; set; }

        [Required, RegularExpression(@"^([0-9]{5})$",
        ErrorMessage = "Please use a valid five number postal code.")]
        public string PostalCode { get; set; }
    }
}
