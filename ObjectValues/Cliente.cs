using System;
using System.ComponentModel.DataAnnotations;

namespace ObjectValues
{
    public class Cliente
    {
        public Cliente(string nome, TipoPessoa tipoPessoa)
        {
            Nome = nome;
            TipoPessoa = tipoPessoa;
        }

        [Key] 
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        
        public TipoPessoa TipoPessoa{ get; set ;}
        
        
        
    }
}