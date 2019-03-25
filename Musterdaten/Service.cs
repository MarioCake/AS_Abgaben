namespace Musterdaten
{
    public class Service
    {
        public static Product[] GetProducts()
        {
            return Product;
        }

        public static Customer[] GetCustomers()
        {
            return Customers;
        }

        public static Order[] GetOrders()
        {
            return Orders;
        }

        private static readonly Product[] Product = new Product[]
        {
            new Product {ProductID = 1, ProductName = "Käse", Price = 10},
            new Product {ProductID = 2, ProductName = "Wurst", Price = 5},
            new Product {ProductID = 3, ProductName = "Obst", Price = 8.56},
            new Product {ProductID = 4, ProductName = "Gemüse", Price = 4},
            new Product {ProductID = 5, ProductName = "Fleisch", Price = 17.5},
            new Product {ProductID = 6, ProductName = "Süßwaren", Price = 3},
            new Product {ProductID = 7, ProductName = "Bier", Price = 2.8},
            new Product {ProductID = 8, ProductName = "Pizza", Price = 7}
        };

        private static readonly Order[] Orders = new Order[]
        {
            new Order {OrderID = 1, ProductID = 4, Quantity = 2, Shipped = true},
            new Order {OrderID = 2, ProductID = 1, Quantity = 1, Shipped = true},
            new Order {OrderID = 3, ProductID = 5, Quantity = 4, Shipped = false},
            new Order {OrderID = 4, ProductID = 4, Quantity = 5, Shipped = true},
            new Order {OrderID = 5, ProductID = 8, Quantity = 6, Shipped = true},
            new Order {OrderID = 6, ProductID = 3, Quantity = 3, Shipped = false},
            new Order {OrderID = 7, ProductID = 7, Quantity = 2, Shipped = true},
            new Order {OrderID = 8, ProductID = 8, Quantity = 1, Shipped = false},
            new Order {OrderID = 9, ProductID = 4, Quantity = 1, Shipped = false},
            new Order {OrderID = 10, ProductID = 1, Quantity = 8, Shipped = true},
            new Order {OrderID = 11, ProductID = 3, Quantity = 3, Shipped = true},
            new Order {OrderID = 12, ProductID = 6, Quantity = 6, Shipped = true},
            new Order {OrderID = 13, ProductID = 1, Quantity = 4, Shipped = false},
            new Order {OrderID = 14, ProductID = 6, Quantity = 3, Shipped = true},
            new Order {OrderID = 15, ProductID = 5, Quantity = 7, Shipped = true},
            new Order {OrderID = 16, ProductID = 1, Quantity = 9, Shipped = true}
        };

        private static readonly Customer[] Customers = new Customer[]
        {
            new Customer
            {
                Name = "Herbert", City = Cities.Aachen, Orders = new Order[]
                {
                    Orders[3], Orders[2], Orders[8], Orders[10]
                }
            },
            new Customer
            {
                Name = "Willi", City = Cities.Köln, Orders = new Order[]
                {
                    Orders[6], Orders[7], Orders[9]
                }
            },
            new Customer
            {
                Name = "Hans", City = Cities.Bonn, Orders = new Order[]
                {
                    Orders[4], Orders[11], Orders[14]
                }
            },
            new Customer
            {
                Name = "Freddy", City = Cities.Bonn, Orders = new Order[]
                {
                    Orders[1], Orders[5], Orders[13]
                }
            },
            new Customer
            {
                Name = "Theo", City = Cities.Aachen, Orders = new Order[]
                {
                    Orders[15], Orders[12]
                }
            }
        };
    }
}