namespace Domain.Models
{
    public class HistoricoNegociacoes : NegociacoesDoDia
    {
        public int Id { get; set; }
        public string? SiglaMoeda { get; set; } 
    }
}
