

namespace task_consoleapp_phone
{
    internal class Store
    {
        // public string Name;
        //Phone[] Phones;
        List<Phone> phones = new List<Phone>();

        public void Show()
        {
            if (phones.Count == 0)
            {
                Console.WriteLine("No phones have been added yet.");
                return;
            }
            int i = 1;
            foreach (Phone phone in phones)
            {
                Console.WriteLine($"Catalog {i}: Id is {phone.id}, Name is {phone.name} , Brand is {phone.brand} ,price is {phone.price} ,only exsist count {phone.count}");
                i++;
            }

        }

        public void AddPhone()
        {

            Console.WriteLine("please enter id");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("////////////////////////");

            Console.WriteLine("please enter phone name");
            string Name = Console.ReadLine();
            Console.WriteLine("////////////////////////");

            Console.WriteLine("please enter  phone brand name");
            string Brand = Console.ReadLine();
            Console.WriteLine("////////////////////////");

            Console.WriteLine("please enter value of phone");
            double Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("////////////////////////");

            Console.WriteLine("please enter count");
            int Count = Convert.ToInt32(Console.ReadLine());

            Phone phone = new Phone()
            {
                id = Id,
                name = Name,
                brand = Brand,
                price = Price,
                count = Count

            };
            phones.Add(phone);
            //phones = new Phone[]
            //{
            //    phone
            //};
            //Phone[] phones = new Phone[]
            //{

            //};

        }

        public void RemovePhone()
        {

            Console.WriteLine("enetr id");
            int Id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < phones.Count; i++)
            {
                if (phones[i].id == Id)
                {
                    Console.WriteLine("deleted this item in list");
                    phones.RemoveAt(i);
                }
            }
        }
        public void ShowPhoneForPrice()
        {
            Console.WriteLine("Enter min value");
            int min=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max value");
            int max=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < phones.Count; i++)
            {
                if (phones[i].price > min && phones[i].price < max)
                {
                    Console.WriteLine($"Number {i+1} Name is {phones[i].name} , Brand is {phones[i].brand} , Price is {phones[i].price}");
                }
            }
        }

    }
}
