using System.ComponentModel.DataAnnotations;

namespace FBTarjeta.Models
{
    public class TarjetaCredito
    {   
        public int Id { get; set; }
        [Required]
        public String Titular { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        [Required]
        public String FechaExpiracion { get; set; }


        [Required]
        public String CVV { get; set; }

    }
}
