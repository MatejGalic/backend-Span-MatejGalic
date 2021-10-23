using System.ComponentModel.DataAnnotations;

namespace backend_Span_MatejGalic.DTOs
{
    public class PersonCreateDTO
    {
        [Required]
        [RegularExpression("[a-zA-Z ]*", ErrorMessage = "only alphabet")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z ]*", ErrorMessage = "only alphabet")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("[0-9]*", ErrorMessage = "numerical only")]
        public string PostalCode { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z ]*", ErrorMessage = "only alphabet")]
        public string City { get; set; }
        [Required]
        [RegularExpression(@"\+?[0-9 ]+", ErrorMessage = "only alphabet")]
        public string PhoneNumber { get; set; }
    }
}
