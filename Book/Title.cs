using System;
internal class Title
{
    private string title;

    public string _Title { get { return title; } set { title = value; } }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Title={title}");
    }
}