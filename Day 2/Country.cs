class Country
{
    string Name;
    string Capital;
    int Population;
    string OfficialLanguage;

    public Country(string name, string capital, int population, string officialLanguage)
    {
        Name = name;
        Capital = capital;
        Population = population;
        OfficialLanguage = officialLanguage;
    }

    public void SetCapital(string capital)
    {
        Capital = capital;
    }

    public string GetCapital()
    {
        return Capital;
    }

    public void SetPopulation(int population)
    {
        Population = population;
    }

    public int GetPopulation()
    {
        return Population;
    }

    public void SetOfficialLanguage(string language)
    {
        OfficialLanguage = language;
    }

    public string GetOfficialLanguage()
    {
        return OfficialLanguage;
    }

    public string GetName()
    {
        return Name;
    }
}
