class Author
{
    string Name;
    int Age;
    string Nationality;
    List<Book> Books;
    public Author() { }

    public Author(string name, int age)
    {
        Name = name;
        Age = age;
        Nationality = "Неизвестно";
        Books = new List<Book>();
    }

    public Author(string name, int age, string nationality)
    {
        Name = name;
        Age = age;
        Nationality = nationality;
        Books = new List<Book>();
    }

    public string GetName()
    {
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }

    public string GetNationality()
    {
        return Nationality;
    }

    public void Introduce()
    {
        Console.WriteLine(
            $"Menya zovut {Name}. Mne {Age} let. Ya iz {Nationality}."
        );
    }

    public void CelBirth()
    {
        Age++;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> ListBk()
    {
        return Books;
    }
}