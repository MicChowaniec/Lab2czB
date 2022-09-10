using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lab2czB
{
    public class Shop : IThing
    {
        private string name;
        string IThing.Name { get { return name; } set => name = value; }

        public Shop(string name, Person[] people, Product[] products) 
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }


        private Person[] people;
        private Product[] products;


        public void Print()
        {
            Console.WriteLine("Shop: "+name);
            Console.WriteLine("-- People: --");
            foreach (var v in people)
            {
                Console.WriteLine(v.Print());
            };
            Console.WriteLine("-- Products: --");
            foreach (var v in products)
            {
                Console.WriteLine(v.Print());
            }
        }

        
    }
}