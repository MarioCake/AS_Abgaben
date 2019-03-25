using System;
using System.Linq;

namespace Musterdaten
{
    public class Program
    {
        public static void Main(String[] args)
        {
            
            var customers = Service.GetCustomers();
            var orders = Service.GetOrders();
            var products = Service.GetProducts();
            //1.Geben Sie alle OrderIds auf der Console aus.
            orders.ToList().ForEach(order => Console.WriteLine(order.OrderID));

            //2.Geben Sie alle Customers auf der Console aus, deren Name mit H anfängt.
            customers
                .Select(customer => customer.Name)
                .Where(customerName => customerName.StartsWith("H")).ToList()
                .ForEach(Console.WriteLine);

            //3.Geben Sie alle order Ids auf der Console aus, deren Menge > 3 ist und deren Shipped Status false ist.
            orders.Where(order => order.Quantity > 3 && !order.Shipped).ToList()
                .ForEach(order => Console.WriteLine(order.OrderID));

            //4.Sortieren Sie alle Bestellungen über Ihre Menge und geben Sie die  Id und die Menge aus.
            orders.OrderBy(order => order.Quantity).ToList().ForEach(order =>
                Console.WriteLine("Id: {0}, Amount: {1}", order.OrderID, order.Quantity));

            //5.Gruppieren Sie alle Kunden nach Ihrem Wohnsitz und geben Sie das Ergebnis aus.
            //customers.OrderBy(customer => customer.City).ToList()
            //    .ForEach(customer => Console.WriteLine("Stadt: {0}, Kunde: {1}", customer.City, customer.Name));

            customers.GroupBy(customer => customer.City).ToList()
                .ForEach(cityGroup => cityGroup.ToList()
                    .ForEach(customer => Console.WriteLine("Stadt: {0}, Kunde: {1}", customer.City, customer.Name)));

            //6.Geben Sie alle Wohnorte der Kunden aus (keine doppelten Ausgaben!).
            customers.Select(customer => customer.City).Distinct().ToList()
                .ForEach(customer => Console.WriteLine(customer));

            //7.Wieviele Bestellungen hat jeweils ein Kunde aufgegeben?
            customers.ToList().ForEach(customer =>
                Console.WriteLine("Kunde: {0}, Bestellungen: {1}", customer.Name, customer.Orders.Length));

            //8.Geben Sie den maximalen Preis eines Produktes aus!
            Console.WriteLine("Teuerstes Produkt: {0}", products.Max(product => product.Price));

            //9.Geben Sie die ersten 3 Produktnamen aus!
            products.Take(3).ToList().ForEach(product => Console.WriteLine(product.ProductName));

            //10.Prüfen sie ob alle Produkte mehr als 3 (Euro) kosten!
            Console.WriteLine("Alle Produkte über 3 Euro: {0}", products.All(product => product.Price > 3));

            //11.Prüfen sie ob es ein Produkt gibt, welches mehr als 10 (Euro) kosten!
            Console.WriteLine("Ein Produkt mehr als 10 Euro: {0}", products.Any(product => product.Price > 10));

            //12.Geben Sie das letzte Produkt aus, welches mehr als 25 (Euro) kostet! Wenn es kein Produkt gibt, geben sie aus: "Kein Produkt kostet mehr als 25 Euro"
            var productMoreThen25Euro = products.LastOrDefault(product => product.Price > 25);

            if (productMoreThen25Euro != null)
            {
                Console.WriteLine("Letztes Product teurer als 25 Euro: {0}", productMoreThen25Euro.ProductName);
            }
            else
            {
                Console.WriteLine("Kein Produkt kostet mehr als 25 Euro");
            }

            //13.Erzeugen Sie eine LISTE<string> mit allen Kundennamen.
            var customerNames = customers.Select(customer => customer.Name).ToList();

            //14.Erzeugen Sie ein Array mit allen OrdersIds vom ersten Kunden.
            var orderIds = customers.First().Orders.Select(order => order.OrderID).ToArray();

            //15. In den Musterdaten liegen insgesamt 16 Bestellungen vor. Es soll nun für jede Bestellung die Bestellnummer des Artikels,
            //die Bestellmenge und der Einzelpreis des Artikels ausgegeben werden.
            orders.Join(products,
                    order => order.ProductID,
                    product => product.ProductID,
                    (order, product) => new {order.OrderID, order.Quantity, product.Price, product.ProductName})
                .ToList().ForEach(order =>
                    Console.WriteLine("Bestellnummer: {0}, Bestellmenge: {1}, Produkt: {2}, Einzelpreis: {3}",
                        order.OrderID, order.Quantity, order.ProductName, order.Price));
        }
    }
}