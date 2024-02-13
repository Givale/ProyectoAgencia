using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public string NumPlaca { get; set; }
        public string? VIN { get; set; }
        public string? Marca { get; set; }
        public string? Serie { get; set; }
        public int? Ano { get; set; }
        public string? Color { get; set; }
        public int? CantPuertas { get; set; }

    }
}
