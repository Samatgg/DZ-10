using static Тумаков_12лаб.Classes.Book;

namespace Тумаков_12лаб.Classes
{
    public class BookContainer
    {
        private Book[] books;

        public BookContainer(Book[] books)
        {
            this.books = books;
        }

        public void SortBooks(ComparisonDelegate comparisonDelegate)
        {
            for (int i = 0; i < books.Length - 1; i++)
            {
                for (int j = 0; j < books.Length - i - 1; j++)
                {
                    if (comparisonDelegate(books[j], books[j + 1]) > 0)
                    {
                        // Обмен местами
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }
    }
}
