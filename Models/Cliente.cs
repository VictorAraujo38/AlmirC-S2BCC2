using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlmirTrabs.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo email é obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "email invalido")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório...")]
        [StringLength(35)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Empresas")]
        public int empresasID { get; set; }
        [ForeignKey("empresasID")]
        public Empresa empresas { get; set; }
    }
}
