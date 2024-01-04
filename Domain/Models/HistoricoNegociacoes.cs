namespace Domain.Models
{
    public class HistoricoNegociacoes : NegociacoesDoDia
    {
        public string? Id { get; set; }
        public string? SiglaMoeda { get; set; }
        
        public void AdicionarSiglaMoeda(string siglaMoeda)
        {
            Id = Guid.NewGuid().ToString();
            SiglaMoeda = siglaMoeda;
        }
    }
}
