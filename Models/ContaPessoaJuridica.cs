using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ContaPessoaJuridica
    {
        [Key]
       public int Id { get; set; } 
       [Required]
       public ClientePessoaJuridica PessoaJuridica{ get; set ;}
       [Required]
       public int AgenciaId{ get; set ;}  
       public Agencia Agencia{ get ; set ;}
    }
}