namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book (1, "Anna Karenina",29.99, "Klassik");
            Book book2 = new Book(2, "1984", 15, "Distopiya");
            Book book3 = new Book(3, "Cinayet ve ceza", 19.99, "Klassik");
            Book book4 = new Book(4, "10 zenci balasi", 5.99, "Detektiv");

            Library library1 = new Library();
            library1.AddBook (book1);
            library1.AddBook (book4);
            library1.AddBook (book2);
            library1.AddBook (book3);

            foreach (Book book in library1.Books)
            {
               Console.WriteLine(book.Name);
            }
            

            
            foreach (var book in library1.GetFilteredBooks("Distopiya")) 
            {
                Console.WriteLine(book.Name + " " + book.Genre);

            }


            foreach (var book in library1.GetBookById(3))
            {
                Console.WriteLine(book.Name);
            }

            foreach (var book in library1.GetBookByName("1984"))
            {
                Console.WriteLine(book.Genre);
            }

            foreach (var book in library1.GetFilteredBooks(10,20))
            {
                Console.WriteLine(book.Name + " " + book.Genre);

            }


        }
    }
}
