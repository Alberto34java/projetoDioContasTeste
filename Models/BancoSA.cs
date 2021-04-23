using System.ComponentModel.DataAnnotations;

namespace ObjectValues
{
    public class BancoSA
    {
        public BancoSA(string razaoSocial, string nomeFantasia, string webSite, ContatoBanco contatoBanco, int contatoBancoId)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            WebSite = webSite;
            ContatoBanco = contatoBanco;
            ContatoBancoId = contatoBancoId;
        }

        [Key]
        public int Id{ get; set ;}
        [Required]
        public string RazaoSocial { get; set ;}
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        public string WebSite { get; set; }
        public  ContatoBanco ContatoBanco{ get; set; }
        [Required]
        public int ContatoBancoId { get; set; }
        
        
        
        
    }
}