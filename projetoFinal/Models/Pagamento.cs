namespace projetoFinal.Models
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public DateTime DataLimite { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
    }
}