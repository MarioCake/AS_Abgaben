using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarSim
{
    public abstract class Ship
    {
        public Capitan Capitan { get; private set; }
        public Engine Engine { get; private set; }
        abstract public int MaximumLoad { get; }
        private List<Load> load = new List<Load>();
        public IReadOnlyList<Load> Load { get => load; }

        private int currentLoadWeight = 0;

        public Ship(Engine engine, Capitan capitan)
        {
            Capitan = capitan;
            Engine = engine;
        }

        public bool HasFreeStorage(int amount)
        {
            return currentLoadWeight + amount < MaximumLoad;
        }

        public bool AddLoad(List<Load> load)
        {
            int loadWeight = load.Sum(thisLoad => thisLoad.Weight);
            if (!HasFreeStorage(loadWeight))
            {
                return false;
            }
            currentLoadWeight += loadWeight;
            this.load.AddRange(load);
            return true;
        }

        public bool AddLoad(Load load)
        {
            if (!HasFreeStorage(load.Weight))
            {
                return false;
            }
            currentLoadWeight += load.Weight;
            this.load.Add(load);
            return true;
        }

        public bool TransferLoad(Ship other, Load load)
        {
            Load loadToTransfer = Load.FirstOrDefault(thisLoad => thisLoad == load);
            if (loadToTransfer == null || !other.AddLoad(loadToTransfer))
            {
                return false;
            }
            currentLoadWeight -= loadToTransfer.Weight;
            this.load.Remove(loadToTransfer);
            return true;
        }

        public bool TranferAllLoad(Ship other)
        {
            if (!other.HasFreeStorage(currentLoadWeight))
            {
                return false;
            }

            other.load.AddRange(Load);
            other.currentLoadWeight += currentLoadWeight;

            this.load.Clear();
            currentLoadWeight = 0;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Ship: {0}", this.GetType().Name));
            sb.AppendLine();
            sb.AppendLine(this.Capitan.ToString());
            sb.AppendLine(this.Engine.ToString());

            sb.AppendLine("Load:");
            foreach(Load load in Load)
            {
                sb.AppendLine(string.Format("\t{0}", load.ToString()));
            }

            return sb.ToString();
        }
    }
}
