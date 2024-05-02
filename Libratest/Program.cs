using Libratest;

var allBooks = new List<Libratest.Book>()
{
    new Libratest.Book()
    {
        Title = "Book 1"
    },
    new Libratest.Book()
    {
        Title = "book2 "
    }
};


foreach (var book in allBooks)
{
    Console.WriteLine(book.Title);
}

Console.ReadLine();