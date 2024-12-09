using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Book.Models;
using Rent.Models;
using Biblioteca.Requests;


namespace Back.Library.LibraryController
{
    [Route("api/biblioteca")]
    [ApiController]


    public class LibraryControllers : ControllerBase
    {
        private static List<BookModel> bookModels =
                new List<BookModel>
                {
                    new  BookModel
                    {
                        Id = 1,
                        Titulo = "Dom Casmurro",
                        Autor = "Machado de Assis",
                        Ano = 1899,
                        Sinopse = "Dom Casmurro é uma das obras mais importantes da literatura brasileira. O romance narra a história de Bentinho, que cresce no Rio de Janeiro do século XIX, e sua relação com sua amiga de infância, Capitu, uma mulher enigmática. O romance explora temas como o ciúme, a dúvida e a interpretação de eventos da vida de uma maneira que deixa a resposta final em aberto: Capitu traiu ou não Bentinho?",
                        Qtd = 2,

                    },

                    new  BookModel

                    {
                        Id = 2,
                        Titulo = "Memórias Póstumas de Brás Cubas",
                        Autor = "Machado de Assis",
                        Ano = 1881,
                        Sinopse = "Memórias Póstumas de Brás Cubas é um romance escrito após a morte do protagonista, Brás Cubas. O livro oferece uma visão sarcástica e irônica sobre a sociedade brasileira do século XIX, com foco na morte e nas falhas da vida humana.",
                        Qtd = 3,

                    },

                    new  BookModel

                    {

                        Id = 3,

                        Titulo = "Grande Sertão: Veredas",

                        Autor = "João Guimarães Rosa",

                        Ano = 1956,

                        Sinopse = "Grande Sertão: Veredas é uma obra do modernismo que narra a história de Riobaldo, um jagunço que reflete sobre sua vida e as questões existenciais em meio ao sertão brasileiro. A obra mistura realidade, simbolismo e filosofia.",

                        Qtd = 4,



                    },

                    new BookModel

                    {

                        Id = 4,
                        Titulo = "O Cortiço",
                        Autor = "Aluísio Azevedo",
                        Ano = 1890,
                        Sinopse = "O Cortiço é um romance naturalista que descreve a vida de moradores de um cortiço no Rio de Janeiro. A obra expõe as condições de vida precárias, a luta pela sobrevivência e os conflitos entre as classes sociais.",
                        Qtd = 4,

                    },

                    new  BookModel

                    {
                       Id = 5,
                       Titulo = "Iracema",
                       Autor = "José de Alencar",
                       Ano = 1865,
                       Sinopse = "Iracema é um romance indianista que descreve o amor entre o guerreiro português Martim e a índia Iracema. A obra aborda a perda da identidade indígena e a formação do Brasil.",
                       Qtd = 1,


                    },
                    new  BookModel

                    {

                       Id = 6,
                       Titulo = "Macunaíma",
                       Autor = "Mário de Andrade",
                       Ano = 1928,
                       Sinopse = "Macunaíma é uma obra modernista que mistura elementos do folclore brasileiro com a literatura popular, apresentando o anti-herói Macunaíma, que representa as contradições culturais do Brasil.",
                       Qtd = 11,

                    },

                    new  BookModel

                    {

                       Id = 7,
                       Titulo = "Capitães da Areia",
                       Autor = "Jorge Amado",
                       Ano = 1937,
                       Sinopse = "Capitães da Areia narra a história de um grupo de meninos de rua em Salvador, abordando questões como a pobreza, a marginalização e os sonhos desses jovens.",
                       Qtd = 2,

                    },

                    new  BookModel

                    {
                        Id = 8,
                        Titulo = "Vidas Secas",
                        Autor = "Graciliano Ramos",
                        Ano = 1938,
                        Sinopse = "Vidas Secas descreve a vida de uma família nordestina que luta para sobreviver à seca, abordando as adversidades da vida no sertão e os problemas sociais.",
                        Qtd = 9,

                    },

                    new  BookModel

                    {
                        Id = 9,
                        Titulo = "A Moreninha",
                        Autor = "Joaquim Manuel de Macedo",
                        Ano = 1844,
                        Sinopse = "A Moreninha é um romance romântico que narra o amor de Augusto por uma jovem misteriosa chamada Moreninha, que vive em uma ilha no Rio de Janeiro.",
                        Qtd = 2,

                    },

                    new  BookModel
                    {
                        Id = 10,
                        Titulo = "O Tempo e o Vento",
                        Autor = "Érico Verissimo",
                        Ano = 1949,
                        Sinopse = "O Tempo e o Vento é uma obra épica que narra a história de uma família ao longo de várias gerações no sul do Brasil, destacando eventos históricos e sociais da região.",
                        Qtd = 1,

                    },

                    new  BookModel

                    {

                        Id = 11,

                        Titulo = "A Hora da Estrela",

                        Autor = "Clarice Lispector",

                        Ano = 1977,

                        Sinopse = "A Hora da Estrela segue a vida de Macabéa, uma nordestina que vive no Rio de Janeiro e é descrita com uma linguagem introspectiva, refletindo sobre a solidão e a existência humana.",

                        Qtd = 1,



                    },

                    new  BookModel

                    {

                        Id = 12,

                        Titulo = "O Quinze",

                        Autor = "Rachel de Queiroz",

                        Ano = 1930,

                        Sinopse = "O Quinze descreve a seca de 1915 no sertão nordestino e os efeitos devastadores sobre a população, com uma crítica social forte sobre as desigualdades regionais.",

                        Qtd = 1,



                    },

                    new  BookModel

                    {

                    Id = 13,

                    Titulo = "Menino do Engenho",

                    Autor = "José Lins do Rego",

                    Ano = 1932,

                    Sinopse = "Menino do Engenho é o primeiro livro da trilogia que narra a vida no engenho de açúcar no nordeste, com um enfoque na infância do protagonista e nas relações familiares.",

                    Qtd = 5,



                    },

                    new  BookModel

                    {

                        Id = 14,

                        Titulo = "Sagarana",

                        Autor = "João Guimarães Rosa",

                        Ano = 1946,

                        Sinopse = "Sagarana é uma coletânea de contos que misturam o real e o fantástico, com uma linguagem inovadora que retrata o sertão mineiro e suas figuras típicas.",

                        Qtd = 3,



                    },

                    new  BookModel

                    {

                        Id = 15,

                        Titulo = "Fogo Morto",

                        Autor = "José Lins do Rego",

                        Ano = 1943,

                        Sinopse = "Fogo Morto descreve a decadência de um engenho de açúcar e os problemas sociais e econômicos da região nordestina, com foco na transformação do modo de vida.",

                        Qtd = 1,



                    }
                };

        private static List<RentModel> rentModels =
               new List<RentModel>();


        [HttpGet]
        public ActionResult<List<BookModel>>
             ListarLivros()
        {
            return Ok(bookModels);
        }

        [HttpGet("{id}")]
        public ActionResult<List<BookModel>>
            ListarUnicoLivro(int id)
        {
            var unico = bookModels.Find(x => x.Id == id);

            if (unico is null)
                return NotFound("Este livro não foi encontrado!");

            return Ok(unico);
        }


        [HttpPost]
        public ActionResult<List<BookModel>>
            EmprestarLivro(RentRequest novo)
        {
            var pesquisa = bookModels.Find(x => x.Id == novo.idBook);

            if (pesquisa == null)
                return NotFound("Livro não encontrado!");

            if (pesquisa.Qtd == 0)
                return NotFound("Livro sem estoque!");

            var rent = new RentModel();

            rent.Id = rentModels.Count > 0 ? rentModels[rentModels.Count - 1].Id + 1 : 1;
            
            rent.nomeUser = novo.nomeUser;
            rent.anoNasc = novo.anoNasc;
            rent.idBook = novo.idBook;
            rent.emprestado_em = DateTime.Now;
            rent.devolvido_em = null;

            rentModels.Add(rent);

            pesquisa.Qtd--;

            return Created();
        }

        [HttpGet("rent")]
        public ActionResult<List<BookModel>>
             ListarAlugueis()
        {
            return Ok(rentModels);
        }

    }
}