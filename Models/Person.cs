using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_Span_MatejGalic.Models
{
    [Table("Podaci")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        [Key]
        public string PhoneNumber { get; set; }

    }
}
