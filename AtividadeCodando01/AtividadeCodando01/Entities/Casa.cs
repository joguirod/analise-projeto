namespace AtividadeCodando01.Entities
{
    class Casa
    {
        public Telhado TelhadoAreaExterna { get; set; }
        public Telhado TelhadoAreaInterna { get; set; }
        public Parede ParedeQuarto { get; set; }
        public Parede ParedeBanheiro { get; set; }
        public Parede ParedeCozinha { get; set; }
        public Espelho EspelhoCorredor { get; set; }

        public Casa(Telhado telhadoAreaExterna, Telhado telhadoAreaInterna, Parede paredeQuarto, Parede paredeBanheiro, Parede paredeCozinha, Espelho espelhoCorredor)
        {
            TelhadoAreaExterna = telhadoAreaExterna;
            TelhadoAreaInterna = telhadoAreaInterna;
            ParedeQuarto = paredeQuarto;
            ParedeBanheiro = paredeBanheiro;
            ParedeCozinha = paredeCozinha;
            EspelhoCorredor = espelhoCorredor;
        }
    }
}
