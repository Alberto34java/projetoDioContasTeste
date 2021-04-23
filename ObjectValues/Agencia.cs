using System.ComponentModel.DataAnnotations;

namespace ObjectValues
{
    public class Agencia
    {
        [Key]
        public int Id{ get ; set ;}
        public EnderecoAgencia Endereco{ get; set ;}
        public int EnderecoAgenciaId{ get; set ;}
    }
}