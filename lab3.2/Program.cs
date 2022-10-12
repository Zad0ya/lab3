namespace Lab32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            Book book = new Book();
            Content content = new Content();
            Title title = new Title();

            Console.Write("Author:");
            author.SetAuthor(Console.ReadLine());
            Console.Write("Book:");
            book.SetBook(Console.ReadLine());
            Console.Write("Content:");
            content.SetContent(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Title:");
            title.SetTitle(Console.ReadLine());

            author.Show();
            book.Show();
            content.Show();
            title.Show();
        }
    }
}