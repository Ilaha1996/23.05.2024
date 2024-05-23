namespace Encapsulation
{
    public class Product
    {  
        private int _count;
        private double _price;
        public int ID { get; set; }
        public string Name { get; set; }    
        public double Price 
        { get
            {

                return _price;  
            }
          set
            {
                if (value >0) 
                {
                 _price = value;
                
                }

            }
        
        
        
        }
        public int Count
        { get
            {  
                return _count;
            }

            set
            {
                if (value > 0)
                {
                    _count = value;
                }

            } 
                       
        }
        public Product(int id)
        {
            ID = id;
        }

        public Product(int id, string name) : this(id) 
        {
            Name = name;
        }

        public Product(int id, string name, double price) : this(id,name)
        {
            Price = price;
        }


    }   

}
