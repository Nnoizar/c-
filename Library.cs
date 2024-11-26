using System.ComponentModel;

class Library
{
    //Data
    List<Book> registeredBooks;
    Dictionary<Book, int> bookInventory;

    //Constructor
    public Library()
    {
        registeredBooks = new List<Book>();
        bookInventory = new Dictionary<Book, int>();

        Book book1 = new("Foundation");
        registeredBooks.Add(book1);//LEgg til bøker vi vet om
        bookInventory.Add(book1, 10);//Legg til i beholdningen vår.

        Book book2 = new("Martian");
        registeredBooks.Add(book2);//LEgg til bøker vi vet om
        bookInventory.Add(book2, 20);//Legg til i beholdningen vår.
    }
    //Methods
    //Vise bøkene som er leagt til
    public List<Book> ListAvaliableBooks()
    {
        return registeredBooks;
    }
}