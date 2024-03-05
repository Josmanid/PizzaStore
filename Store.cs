using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Store
    {
        /*Call the Start method from the main method in the 
              class Program.*/
        public void Start() {
            
            // In the Start method you should Create 3 Pizza objects//
            Pizza pizza1 = new Pizza("calzone", 60);
            Pizza pizza2 = new Pizza("Pepperoni", 55);
            Pizza pizza3 = new Pizza("SalatPizza",60);
            // 3 Customer objects
            Customer customer1 = new Customer("Bob");
            Customer customer2 = new Customer("Hans");
            Customer customer3 = new Customer("Kalle");
            // 3 Order objects each with a diffferent pizza
            Order order1 = new Order(pizza1,customer1);
            Order order2 = new Order(pizza2,customer2);
            Order order3 = new Order(pizza3,customer3);

            // Printing out order information
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);

            // Test the method CalculateTotalPrice
            Console.WriteLine("test af CalculateTotalPrice metoden: Pris før på pizza1: " + order1.Pizza.Price + " kr");
            Console.WriteLine("test af CalculateTotalPrice metoden: Pris efter metoden er benyttet på pizza1: " + order1.CalculateTotalPrice() + " kr");
            
        }


    }
}
