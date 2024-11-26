
// Book book1 = new Book("Alice in Wonderlnad");
// Book book2 = new Book("Foundation");
// Book book3 = new Book("Learning C#");

Library library = new Library();

// Main Loop
while (true)
{

    //når vi skriver dotnet run så kjører den første linja
    Console.WriteLine("please wright something then hit enter");
    //nå skriver vi noe
    string userInput = Console.ReadLine();

    //feilhåndtering
    if (userInput == null)
    {
        throw new Exception("Could not read user input");
    }
    switch (userInput)
    {
        case "list":
            List<Book> availableBooks = library.ListAvaliableBooks();
            foreach (var book in availableBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
            }
            break;
        // Book newBook = new Book("Foundation");
        // Console.WriteLine($"Add a new book with title : {newBook.Title}");
        // break;
        case "borrow":
            Console.WriteLine("borrrowing a book");
            break;
        case "return":
            Console.WriteLine("return a book");
            break;
        default:
            Console.WriteLine("unrecognized command");
            break;
    }
}

//Console.WriteLine("User input");
//Console.WriteLine(userInput);