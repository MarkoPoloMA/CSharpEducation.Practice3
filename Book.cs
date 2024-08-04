using System;

namespace CSharpEducation.Practice3;

internal class Book
{
    private string NameBook { get; set; }
    private string Year { get; set; }
    private string Avtor { get; set; }
    
    public Book(string avtor, string nameBook, string year)
    {
        this.Avtor = avtor;
        this.NameBook = nameBook;
        this.Year = year;
    }

    public Book(string nameBook, string year) : this("nilll", year, nameBook){}
    public Book() : this("niill ", "niill  ", "niil") { }
    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {NameBook}, Автор: {Avtor}, Год издания: {Year}");
    }
}