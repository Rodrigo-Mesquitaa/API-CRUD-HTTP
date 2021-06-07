using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Carro
{
    [Table("TB_CARRO")]
   public class CarroViewModel
    {
        [Column("CAR_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("CAR_NOME")]
        [Display(Name = "Name")]
        [MaxLength(255)]

        public string Nome { get; set; }

    }
}
