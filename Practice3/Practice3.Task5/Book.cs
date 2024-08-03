namespace Practice3.Task4
{
    internal class Book
    {
        private string title;
        private string author;
        private int publishYear;

        public Book()
        {
            title = "Some Title";
            author = "Some Author";
            publishYear = 10;
        }

        public Book(string title, string author, int publishYear) : this(title, author)
        {
            this.publishYear = publishYear;
        }

        public Book(string title, string author) : this(title)
        {
            this.author = author;
        }

        public Book(string title)
        {
            this.title = title;
        }
    }
}
