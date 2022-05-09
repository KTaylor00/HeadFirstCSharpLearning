using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    abstract class Bee
    {
        public string Job { get; private set; }
        public abstract float CostPerShift { get; }

        /// <summary>
        /// Used to set the read-only Job property
        /// </summary>
        /// <param name="job">Takes a string parameter.</param>
        public Bee(string job)
        {
            Job = job;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected abstract void DoJob();
    }
}
