using System;
internal class Author
{
    private string author;

    public string _Author { get { return author; } set { author = value; } }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nAuthor={author}");
    }
}