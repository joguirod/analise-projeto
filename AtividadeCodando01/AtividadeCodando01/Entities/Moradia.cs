namespace AtividadeCodando01.Entities
{
    class Moradia
    {
        public double Area { get; set; }
        public Endereco Endereco { get; set; }

        public Moradia(double area, Endereco endereco)
        {
            Area = area;
            Endereco = endereco;
        }
    }
}
