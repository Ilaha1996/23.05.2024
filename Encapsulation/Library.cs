using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Encapsulation
{
    public class Library
    {
        public Book[] Books = new Book[0];
        public void AddBook (Book book) 
        {  
            Array.Resize (ref Books, Books.Length +1);
            Books[Books.Length-1] = book; 
        
        }   

        public Book[] GetBookById (int id) 
        {           
            Book[] getBookById = new Book[0];
            foreach (Book book in Books)
            {
                if (book.ID == id)
                {
                    Array.Resize(ref getBookById, getBookById.Length + 1);
                    getBookById[getBookById.Length - 1] = book;
                }
            }
            return getBookById;
           
        }

        public Book[] GetBookByName(string name)
        {
            Book[] getBookByName = new Book[0];
            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    Array.Resize(ref getBookByName, getBookByName.Length + 1);
                    getBookByName[getBookByName.Length - 1] = book;
                }
                         
            }
            return getBookByName;      
        }


        public Book[] GetFilteredBooks(string genreName) 
        {
            Book[] filteredBooks = new Book[0]; 
            foreach (var book in Books)
            {
                if(book.Genre == genreName) 
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length-1] = book;
                }
            }
            return filteredBooks;
        
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] filteredBooks = new Book[0];
            foreach (var book in Books)
            {
                if (book.Price >=minPrice && book.Price<=maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }
            return filteredBooks;

        }

    }
}
