class Book
{
    string Title;
    string Genre;
    int Pages;

    public Book(string title, string genre, int pages)
    {
        Title = title;
        Genre = genre;
        Pages = pages;
    }

    public string GetInfo()
    {
        return $"Kniga: {Title}, Janr: {Genre}, Stranitsa: {Pages}";
    }
}
