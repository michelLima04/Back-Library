namespace Biblioteca.Requests
{
    public class RentRequest
    {
        public int idBook { get; set; }
        public string nomeUser { get; set; } = string.Empty;
        public int anoNasc { get; set; }
    }
    
}
