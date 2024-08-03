namespace Practice3.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("New Book", "New Author");
            PrintBook(book);
        }

        static void PrintBook(Book book)
        {
            Console.WriteLine($"Книга {book.Title}, автор {book.Author}");
        }
    }
}
