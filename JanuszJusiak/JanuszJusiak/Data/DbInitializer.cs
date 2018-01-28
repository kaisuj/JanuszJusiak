using JanuszJusiak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanuszJusiak.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.AbstractElements.Any())
            {
                context.AddRange
                (
                    new AbstractElement { Name = "Paragraf", Description = "Grupuje blok tekstu w akapit.", HtmlTag = "<p>" },
                    new AbstractElement { Name = "Link", Description = "Tworzy łącze do pliku lub innej strony.", HtmlTag = "<a>" },
                    new AbstractElement { Name = "Nagłówek1", Description = "Służy do wpisywania tytułów stron. Stopień nagłówka wskazuje na wielkość czcionki malejąco od 1 do 6.", HtmlTag = "<h1>" },
                    new AbstractElement { Name = "Nagłówek2", Description = "Służy do wpisywania tytułów stron. Stopień nagłówka wskazuje na wielkość czcionki malejąco od 1 do 6.", HtmlTag = "<h2>" },
                    new AbstractElement { Name = "Nagłówek3", Description = "Służy do wpisywania tytułów stron. Stopień nagłówka wskazuje na wielkość czcionki malejąco od 1 do 6.", HtmlTag = "<h3>" },
                    new AbstractElement { Name = "Nagłówek4", Description = "Służy do wpisywania tytułów stron. Stopień nagłówka wskazuje na wielkość czcionki malejąco od 1 do 6.", HtmlTag = "<h4>" },
                    new AbstractElement { Name = "Nagłówek5", Description = "Służy do wpisywania tytułów stron. Stopień nagłówka wskazuje na wielkość czcionki malejąco od 1 do 6.", HtmlTag = "<h5>" },
                    new AbstractElement { Name = "Nagłówek6", Description = "Służy do wpisywania tytułów stron. Stopień nagłówka wskazuje na wielkość czcionki malejąco od 1 do 6.", HtmlTag = "<h6>" },
                    new AbstractElement { Name = "Złamanie linii", Description = "Pozwala na złamanie linii tekstu i przejście do anstępnej linii.", HtmlTag = "<br>" },
                    new AbstractElement { Name = "Lista numerowana", Description = "Rozpoczyna listę numerowaną.", HtmlTag = "<ol>" },
                    new AbstractElement { Name = "Lista nienumerowana", Description = "Rozpoczyna listę nienumerowaną.", HtmlTag = "<ul>" },
                    new AbstractElement { Name = "Element listy", Description = "Dany fragment tekstu staję się elementem listy.", HtmlTag = "<li>" }
                );
            }

            if (!context.Fonts.Any())
            {
                context.AddRange
                (
                    new Font { Name="Arial", IsStandard=true},
                    new Font { Name="Consolas", IsStandard=true}
                );
            }
        }
    }
}
