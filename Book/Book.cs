using System;

    internal class Book
    {
    private Title title = new Title();
    private Author author = new Author();
    private Content content = new Content();

    public void addtheTitleAuthorContent(string title,string author,string content)
    {
        this.title._Title = title;
        this.author._Author = author;
        this.content._Content = content;
    }
     
    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }
  
    }

