using System.ComponentModel.DataAnnotations.Schema;

namespace repasodb.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set;}
        public string? Name {get; set;}
        public string? Email {get; set;}
        public string? Message {get; set;}
    }
}