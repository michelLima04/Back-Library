using Microsoft.Extensions.Primitives;

namespace Book.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Ano { get; set; }
        public string Sinopse { get; set; } = string.Empty;
        public int Qtd { get; set; }

    }


}