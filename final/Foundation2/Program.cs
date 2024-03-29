using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        List<Order> orders = new List<Order>(), ordeRepository;
        Order ord1 = new Order("Cliftom Roberts", "1456", "Abraham Lincoln St", "Miami", "Florida", "USA");
        ord1.AddProduct("Frezzer", 731, 400, 3);
        ord1.AddProduct("SmartTV", 311, 800,2);
        ord1.AddProduct("kitchen", 112, 500,3);
        Order ord2 = new Order("Marcelo Caramayo", "379", "John F Kennedy St", "Colonia Juarez", "Chihuahua", "Mexico");
        ord2.AddProduct("kitchen", 213, 500,3);
        ord2.AddProduct("HairDryer", 514, 124, 4);
        ord2.AddProduct("Washing Machine", 815, 290, 2);
        Order ord3 = new Order("Charles Newton", "3552", "Benjamin Franklin St", "Atlanta", "Georgia", "USA");
        ord3.AddProduct("Mobile Phone", 616, 690, 2);
        ord3.AddProduct("DeskTop", 917, 220, 2);
        ord3.AddProduct("LapTop", 418, 700, 3);
        ordeRepository = new List<Order>(){ord1, ord2, ord3};

        double price, tot = 0;
        int i, prodId, quant, n = 0;
        string op, prodName, customer, stNumber, street, city, stateOrProv, country, aux;

        do
        {
            Console.Write($"{n} order/s entered for $ {tot:N2}\nMenu Options:\n\n1-Create an Order Track\n2-List Orders\n3-Add Product\n4-Load Pre Saved Orders\n5-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3" | op == "4")
            {
                if(op == "1")
                {
                    do
                    {
                        Console.Write("Who is the customer of the order? ");
                        customer = Console.ReadLine();
                        customer = customer.Trim();
                    }while(customer == "");

                    do
                    {
                        Console.Write("What is the address number at the street? ");
                        stNumber = Console.ReadLine();
                        stNumber = stNumber.Trim();
                    }while(stNumber == "");

                    do
                    {
                        Console.Write("What is the street name? ");
                        street = Console.ReadLine();
                        street = street.Trim();
                    }while(street == "");

                    do
                    {
                        Console.Write("What is the city name? ");
                        city = Console.ReadLine();
                        city = city.Trim();
                    }while(city == "");

                    do
                    {
                        Console.Write("What is the state or province? ");
                        stateOrProv = Console.ReadLine();
                        stateOrProv = stateOrProv.Trim();
                    }while(stateOrProv == "");

                    Console.Write("It is in USA? Y/N: ");
                    aux = Console.ReadLine();
                    aux = aux.Trim();
                    if(aux.ToUpper() == "Y") country = "USA";
                    else
                    {
                        do
                        {
                            Console.Write("What is the country name? ");
                            country = Console.ReadLine();
                            country = country.Trim();
                        }while(country == "" | country.ToUpper() == "USA");
                    }

                    orders.Add(new Order(customer,stNumber,street, city, stateOrProv, country));
                }
                else
                {
                    if(orders.Count == 0 & op != "4")  Console.WriteLine("There are NO orders entered still!");
                    else
                    {
                        if(op == "2" | op == "3")
                        {
                            i = 0;
                            Console.WriteLine("Orders entered:");
                            foreach(Order order in orders)
                            {
                                Console.Write($"\n{i+1}-");
                                Console.WriteLine($"{order.ShippingLabel()}");
                                if(order.HowManyProductHas() > 0) Console.WriteLine($"\n{order.PackingLabel()}\n\n   Total $ {order.TotalCost(),47:N2}");
                                i++;
                            }

                            if(op == "3")
                            {
                                do
                                {
                                    do
                                    {
                                        Console.Write("To which of those orders do you wish to add a product? ");
                                        aux = Console.ReadLine();
                                        aux = aux.Trim();
                                    }while(aux == "");
                                    i = int.Parse(aux);
                                }while(i <= 0 | i > orders.Count);

                                do
                                {
                                    Console.Write("What is the product name? ");
                                    prodName = Console.ReadLine();
                                    prodName = prodName.Trim();
                                }while(prodName == "");

                                do
                                {
                                    do
                                    {
                                        Console.Write("What is the product Id? It should not be repeated in the same order: ");
                                        aux = Console.ReadLine();
                                        aux = aux.Trim();
                                    }while(aux == "");
                                    prodId = int.Parse(aux);
                                }while(prodId <= 0);

                                do
                                {
                                    do
                                    {
                                        Console.Write("What is product price? ");
                                        aux = Console.ReadLine();
                                        aux = aux.Trim();
                                    }while(aux == "");
                                    price = double.Parse(aux);
                                }while(price <= 0);

                                do
                                {
                                    do
                                    {
                                        Console.Write("What is the product quantity? ");
                                        aux = Console.ReadLine();
                                        aux = aux.Trim();
                                    }while(aux == "");
                                    quant = int.Parse(aux);
                                }while(quant <= 0);

                                orders[i-1].AddProduct(prodName, prodId, price, quant);
                            }
                        }
                        else
                        {
                            orders.AddRange(ordeRepository);
                            Console.WriteLine("Repository Order Added");
                        }
                        i = 0;
                        n = 0;
                        tot = 0;
                        foreach(Order order in orders)
                        {
                            tot += order.TotalCost();
                            i++;
                        }
                        n = i;
                    }
                }
                Console.Write("\nPlease press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(op != "5");
        Console.WriteLine("Thanks for using this program! Please come back soon...");
    }
}