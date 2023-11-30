
namespace Тумаков_12лаб.Classes
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }
        public delegate int ComparisonDelegate(Book book1, Book book2);

    }
}
