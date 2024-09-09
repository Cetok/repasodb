using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace repasodb.Models
{
    [Table("t_cliente")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set;}
        public string? Nombre {get; set;}
        public string? Apellidos {get; set;}
        public string? DNI {get; set;}
        public DateOnly FechaNacimiento {get; set;}
    }
}