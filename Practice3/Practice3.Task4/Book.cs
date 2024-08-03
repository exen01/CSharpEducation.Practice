namespace Practice3.Task4
{
    internal class Book
    {
        private string title;
        private string author;

        public Book()
        {
            title = "Some Title";
            author = "Some Author";
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}
