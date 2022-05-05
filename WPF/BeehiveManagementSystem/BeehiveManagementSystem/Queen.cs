using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee
    {
        private Bee[] workers = new Bee[0];
        override float CostPerShift;
        string StatusReport;

        public Queen() : base("Queen") { }

        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        private void AssignBee(string job)
        {
            switch (job)
            {
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;

                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer(this));
                    break;

                case "Nectar Collector":
                    AddWorker(new NectarCollector(this));
                    break;

                default:
                    break;
            }
        }
    }
}
