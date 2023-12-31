namespace Domain.Models
{
    public class HistoricoNegociacao : NegociacoesDoDia
    {
        public int Id { get; set; }
        public string? SiglaMoeda { get; set; } 
    }
}
