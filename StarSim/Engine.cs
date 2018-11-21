namespace StarSim
{
    abstract public class Engine
    {
        public override string ToString()
        {
            return string.Format("Engine: {0}", this.GetType().Name);
        }
    }
}