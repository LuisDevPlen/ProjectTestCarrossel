using Microsoft.AspNetCore.Mvc;
using ProjectTest.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "Código Limpo: Habilidades Práticas do Agile Software", CoverImageUrl = "/image/livro1.png", Author = "Robert C. Martin ", Publisher = "Alta Books; 1ª edição (8 setembro 2009)", PublicationYear = 2009, Pages = 350, ISBN = "978-8576082675", Description = "Mesmo um código ruim pode funcionar. Mas se ele não for limpo, pode acabar com uma empresa de desenvolvimento. Perdem-se a cada ano horas incontáveis e recursos importantes devido a um código mal escrito. Mas não precisa ser assim.\r\n\r\nO renomado especialista em software, Robert C. Martin, apresenta um paradigma revolucionário com Código limpo: Habilidades Práticas do Agile Software. Martin se reuniu com seus colegas do Mentor Object para destilar suas melhores e mais ágeis práticas de limpar códigos “dinamicamente” em um livro que introduzirá gradualmente dentro de você os valores da habilidade de um profissional de softwares e lhe tornar um programador melhor –mas só se você praticar.\r\n\r\nQue tipo de trabalho você fará? Você lerá códigos aqui, muitos códigos. E você deverá descobrir o que está correto e errado nos códigos. E, o mais importante, você terá de reavaliar seus valores profissionais e seu comprometimento com o seu ofício.\r\n\r\nCódigo limpo está divido em três partes. Na primeira há diversos capítulos que descrevem os princípios, padrões e práticas para criar um código limpo.\r\n\r\nA segunda parte consiste em diversos casos de estudo de complexidade cada vez maior. Cada um é um exercício para limpar um código – transformar o código base que possui alguns problemas em um melhor e eficiente. A terceira parte é a compensação: um único capítulo com uma lista de heurísticas e “odores” reunidos durante a criação dos estudos de caso. O resultado será um conhecimento base que descreve a forma como pensamos quando criamos, lemos e limpamos um código." },
            new Book { Id = 2, Title = "Java®: Como Programar ", CoverImageUrl = "/image/livro0.png", Author = " Paul Deite", Publisher = "Pearson Universidades; 10ª edição (24 junho 2016)", PublicationYear = 2016, Pages = 968, ISBN = "978-8543004792", Description = "Milhões de alunos e profissionais aprenderam programação e desenvolvimento de software com os livros Deitel®. Java: como programar, 10ª edição, fornece uma introdução clara, simples, envolvente e divertida à programação Java com ênfase inicial em objetos. Destaques incluem: rica cobertura dos fundamentos com exemplos reais; apresentação com ênfase inicial em classes e objetos; uso com Java™ SE 7, Java™ SE 8 ou ambos; Java™ SE 8 abordado em seções modulares opcionais; lambdas, fluxos e interfaces funcionais usando métodos padrão e estáticos do Java SE 8; Swing e GUI do JavaFX: elementos gráficos e multimídia; conjunto de exercícios \"\"Fazendo a diferença\"\"; tratamento de exceções integrado; arquivos, fluxos e serialização de objetos; concorrência para melhor desempenho com multiprocessamento; o livro contém o conteúdo principal para cursos introdutórios; outros tópicos: recursão, pesquisa, classificação, coleções genéricas, estruturas de dados, multithreading, banco de dados (JDBC ™ e JPA)." },
  
        };

        public IActionResult Index()
        {
            return View(_books);
        }

        public IActionResult BookDescription(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            // Passa a lista de livros recomendados para a visão
            var recommendedBooks = _books.Where(b => b.Id != id).ToList();
            var viewModel = new BookDescriptionViewModel
            {
                Book = book,
                RecommendedBooks = recommendedBooks
            };

            return View(viewModel);
        }
    }
}
