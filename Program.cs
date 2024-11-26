// See https://aka.ms/new-console-template for more information

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
        case "borrow":
            Console.WriteLine("borrrowing a book");
            break;
        case "return":
            Console.WriteLine("return a book");
            break;
        default:
            Console.Write("unrecognized command");
            break;
    }
}

//Console.WriteLine("User input");
//Console.WriteLine(userInput);