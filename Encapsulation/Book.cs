namespace Encapsulation
{
    
    public class Book : Product
    {
        public string Genre {  get; set; }

        public Book(int id, string name, double price,  string genre) : base(id, name, price)
        {
            Genre = genre;
        }

    } 
}
