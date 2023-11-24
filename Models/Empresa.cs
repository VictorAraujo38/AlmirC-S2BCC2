using System.ComponentModel.DataAnnotations;

namespace AlmirTrabs.Models
{
    public class Empresa
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Descricao é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Descricao")]
        public string descricao { get; set; }
        //
        [Required(ErrorMessage = "Campo CNPJ é obrigatório...")]
        [StringLength(18)]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }
    }
}
