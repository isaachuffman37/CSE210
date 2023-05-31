public class Book : Loanable
{
    string _title;
    string _isbn;
    string _upc;

    public Book(string title, string isbn, string upc)
    {
         _title = title;
         _isbn = isbn;
         _upc = upc;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Title:{_title}\nISBN: {_isbn}\nUPC: {_upc}");
    }




}
