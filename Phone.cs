
namespace task_consoleapp_phone
{
    internal class Phone
    {
        int _id;
        public int id
        {
            get { return _id; }
            set {
                if ( value>0 ) {
                _id = value;
                    
                }
                else { Console.WriteLine("Id must be positive number");
                    
                }
            }
        }
        string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (value.Length > 1)
                {
                    _name = value;
                }
                else { Console.WriteLine("Name must be than two letter"); }
            }
        }
        string _brand;
        public string brand { get {
                return _brand;} 
            set {
                if( value.Length > 2 ) { 
                _brand = value;
                }
                else { Console.WriteLine("Brand must be than three letter");
                    
                }
            } 
        }
        double _price;
        public double price
        {
            get { return _price; }
            set {
                if (value>0)
                {
                    _price = value;
                }
                else
                {
                    { Console.WriteLine("Price must be than zero"); }
                }
            }
        }
        int _count;
        public int count { get { return _count; } 
            set {
                if (value>0) {
                _count = value;
                }
            } }

        


     
      

      

    }
}
