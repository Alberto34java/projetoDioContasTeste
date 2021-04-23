using System.Collections.Generic;

namespace ObjectValues
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public char UF{ get; set;}
        public Cliente ClienteId { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}