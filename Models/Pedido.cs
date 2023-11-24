using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlmirTrabs.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "racoes")]
        public int racoesID { get; set; }
        [ForeignKey("racoesID")]
        public Racoes racoes { get; set; }

        [Display(Name = "Pets")]
        public int petsID { get; set; }
        [ForeignKey("PetsID")]
        public Pets pets { get; set; }

        [Required(ErrorMessage = "Campo Quantidades é obrigatório.")]
        [Display(Name = "Quantidades")]
        public int quantidade { get; set; }

        [Display(Name = "Valor")]
        public double valor { get; set; }
    }
}
