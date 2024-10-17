using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{   public class Paper
    {
        public string Title { get; set; }
        public Person Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public Paper(string title, Person author, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }

        public Paper()
        {
            Title = "Название по умолчанию";
            Author = new Person();
            PublicationDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Title}, Автор: {Author.ToShortString()}, Дата публикации: {PublicationDate.ToShortDateString()}";
        }
    }
}
