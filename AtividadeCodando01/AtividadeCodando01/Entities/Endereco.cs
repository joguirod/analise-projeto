namespace AtividadeCodando01.Entities
{
    class Endereco
    {
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }

        public Endereco(string logradouro, string cep, string numero)
        {
            Logradouro = logradouro;
            Cep = cep;
            Numero = numero;
        }
    }
}
