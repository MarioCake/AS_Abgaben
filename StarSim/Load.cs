namespace StarSim
{
    public class Load
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Load(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}({2}t)", this.GetType().Name, Name, Weight);
        }
    }
}