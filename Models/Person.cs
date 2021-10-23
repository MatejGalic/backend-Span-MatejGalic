using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_Span_MatejGalic.Models
{
    [Table("Podaci")]
    public class Person
    {
        [Required]        
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        //[RegularExpression("[0-9]", ErrorMessage = "numerical only")]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Key]
        [Required]
        public string PhoneNumber { get; set; }

    }
}
