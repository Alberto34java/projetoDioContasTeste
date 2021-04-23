using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ObjectValues;

namespace Models
{
    public class ClientePessoaFisica
    {
        public int Id { get; set; }
        public Cliente Cliente{ get; set ;}
        [Required]
        public string Cpf{ get ; set ;}
        [Required]
        public TipoSexo TipoSexo{ get; set ;}
        public int ClienteId { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        
        
        
        
    }
}