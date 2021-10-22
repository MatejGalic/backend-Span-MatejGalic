using System.ComponentModel.DataAnnotations;

namespace backend_Span_MatejGalic.DTOs
{
    public class PersonCreateDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
