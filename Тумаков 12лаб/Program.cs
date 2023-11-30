using System;
using Тумаков_11лаб;
using Тумаков_12лаб.Classes;

namespace Тумаков_12лаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 12.1 - Переопределить операторы '==' и '!=' , метод Equals,метод GetHashCode, метод ToString\n");
            BankAccount account1 = new BankAccount("Андрей Булгаков", 1000);
            BankAccount account2 = new BankAccount("Александ Пушкин", 500);
            BankAccount account3 = new BankAccount("Сергей Некрасов", 1000);

            Console.WriteLine(account1 == account2); 
            Console.WriteLine(account1 != account2); 
            Console.WriteLine(account1 == account3); 
            Console.WriteLine(account1 != account3); 

            Console.WriteLine(account1.Equals(account2)); 
            Console.WriteLine(account1.Equals(account3)); 

            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account2.GetHashCode());
            Console.WriteLine(account3.GetHashCode());

            Console.WriteLine(account1.ToString());

            Console.WriteLine("\nУпр 12.2 - Создать класс рац.чисел,два поля - числ.,знам.Переопределить метод ToString() для вывода дроби.\n");
            RationalNumber rational1 = new RationalNumber(1, 2);
            RationalNumber rational2 = new RationalNumber(2, 3);

            Console.WriteLine(rational1); 
            Console.WriteLine(rational2); 

            Console.WriteLine(rational1 == rational2); 
            Console.WriteLine(rational1 != rational2); 
            Console.WriteLine(rational1 < rational2); 
            Console.WriteLine(rational1 > rational2); 
            Console.WriteLine(rational1 <= rational2); 
            Console.WriteLine(rational1 >= rational2); 

            RationalNumber sum = rational1 + rational2;
            Console.WriteLine(sum);

            RationalNumber difference = rational1 - rational2;
            Console.WriteLine(difference);

            RationalNumber increment = ++rational1;
            Console.WriteLine(increment); 

            RationalNumber decrement = --rational1;
            Console.WriteLine(decrement);

            int integerNumber = (int)rational1;
            Console.WriteLine(integerNumber); 

            float floatNumber = (float)rational2;
            Console.WriteLine(floatNumber);

            Console.WriteLine("\nДз 12.1 - Класс комплексных чисел,операции: +,-,/,*, =,<,>,<=,>=,!=\n");

            ComplexNumber complex1 = new ComplexNumber(2, 3);
            ComplexNumber complex2 = new ComplexNumber(4, 5);

            Console.WriteLine(complex1); // 2 + 3i
            Console.WriteLine(complex2); // 4 + 5i

            ComplexNumber summa = complex1 + complex2;
            Console.WriteLine(sum); // 6 + 8i

            ComplexNumber differenc = complex1 - complex2;
            Console.WriteLine(difference); // -2 - 2i

            ComplexNumber product = complex1 * complex2;
            Console.WriteLine(product); // -7 + 22i

            Console.WriteLine(complex1 == complex2); // False
            Console.WriteLine(complex1 != complex2); // True

            Console.WriteLine("\nДз 12.2 - Написать делегат,книга - название,автор,издательство.Класс конт.для множ.книг.Сортировка\n");
            Book[] books = new Book[]
            {
                new Book("Возлюбленная", "Тони Моррисон", "Роман"),
                new Book("Кровавая комната", "Анджела Картер", "Детектив"),
                new Book("Зов предков", "Джек Лондон", "Приключение")
            };
            BookContainer bookContainer = new BookContainer(books);
            // Пример сортировки по названию книги
            bookContainer.SortBooks((book1, book2) => book1.Title.CompareTo(book2.Title));
            // Пример сортировки по автору
            bookContainer.SortBooks((book1, book2) => book1.Author.CompareTo(book2.Author));
            // Пример сортировки по издательству
            bookContainer.SortBooks((book1, book2) => book1.Publisher.CompareTo(book2.Publisher));
        }
    }
}
