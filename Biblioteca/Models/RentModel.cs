namespace Rent.Models
{
    public class RentModel
    {
        public int Id { get; set; }
        public int idBook { get; set; }
        public string nomeUser { get; set; } = string.Empty;
        public int anoNasc { get; set; }
        
        public DateTime emprestado_em { get; set; }
        public DateTime? devolvido_em { get; set; }
    }
}