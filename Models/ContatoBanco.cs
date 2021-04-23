using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ContatoBanco
    {
        public ContatoBanco(string fone, string foneRegiao)
        {
            Fone = fone;
            FoneRegiao = foneRegiao;
        }

        [Key]
        public int Id{ get; set ;}
        [Required]
        public string Fone { get; set; }
        [Required]
        public string FoneRegiao { get; set; }
        
        
        
        
    }
}