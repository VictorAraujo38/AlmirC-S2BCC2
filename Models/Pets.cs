using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlmirTrabs.Models
{
    [Table("Pets")]
    public class Pets
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Valor é obrigatório.")]
        [Display(Name = "Valor")]
        public double valor { get; set; }


        [StringLength(35)]
        [Display(Name = "raca")]
        public string raca { get; set; }
    }
}
