namespace Lab2czB
{
    public abstract class Product : IThing
    {
        private string name;
        public  string Name { get; set; }
        

        public Product(string name)
        {
            this.name = name;
        }

        public abstract string Print();

    }
}