namespace Lab2czB
{
    public class Meat : Product
    {

        private double weight;
        public double Weight { get { return weight; } set { weight = value; } }

        public Meat(String name, double weight):base(name)
        {
            Name = name;
            this.Weight = weight;
        }

        public override string Print()
        {
            return "        "+Name + " (" + Weight + "kg)"; 
        }
    }
}