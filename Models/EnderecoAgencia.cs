namespace Models
{
    public class EnderecoAgencia
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
        public int AgenciaId { get ; set ;}
    }
}