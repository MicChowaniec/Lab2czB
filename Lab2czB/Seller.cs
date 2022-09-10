namespace Lab2czB
{
    public class Seller :Person
    {
        public Seller(string name, int age) : base(name, age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string Print()
        {
            return "        Seller: " + Name + " (" + Age + " y.o.)";
        }
    }

    
}