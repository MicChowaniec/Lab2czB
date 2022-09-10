namespace Lab2czB
{
    public class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string Print()
        {
            string text = "        Buyer: " + Name + " (" + Age + " y.o.)";

            if (tasks.Count > 0)
            {
                text += "\n                -- Products: --";              
                foreach (Product p in tasks)
                {

                    text += "\n        " + p.Print() ;

                    
                }
                
            }
            return text;
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
            
        }

        public void RemoveProduct(int index)
        {
            tasks.Remove(tasks[index]);
        }

      
    }
}