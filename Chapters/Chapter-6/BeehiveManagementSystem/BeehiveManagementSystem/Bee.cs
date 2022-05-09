using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee
    {
        public string Job { get; private set; }
        public virtual float CostPerShift { get; }

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

        protected virtual void DoJob() { }
    }
}
