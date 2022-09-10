namespace Lab2czB
{
    internal class Fruit : Product
    {
        private int count;
        public int Count { get { return count; } set { count = value; } }

        public Fruit(string name, int count) : base(name)
        {
            Name = name;
            this.count = count;
        }

        public override string Print()
        {
            return "        "+Name+ " ("+Count+ "fruits)";
        }
    }
}