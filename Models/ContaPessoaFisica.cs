using System.ComponentModel.DataAnnotations;
using ObjectValues;

namespace Models
{
    public class ContaPessoaFisica
    {
        [Key]
        public int Id{ get; set ;}
        [Required]
        public TipoConta TipoConta{ get; set ;}
        [Required]
        public ClientePessoaFisica PessoaFisica { get; set; }
        [Required]
        public int AgenciaId{ get; set ;}
         public Agencia Agencia{ get ; set ;}
        
        
    }
}