namespace Practice3.Task11
{
    internal class Book
    {
        private string title;
        private string author;

        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}
