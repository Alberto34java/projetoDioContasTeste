using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Agencia
    {
        [Key]
        public int Id{ get ; set ;}
        public EnderecoAgencia Endereco{ get; set ;}
        public int EnderecoAgenciaId{ get; set ;}
        
        
        
    }
}