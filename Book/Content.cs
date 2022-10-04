using System;
internal class Content
{
    private string content;

    public string _Content { get { return content; } set { content = value; } }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nContent={content}");
    }
}