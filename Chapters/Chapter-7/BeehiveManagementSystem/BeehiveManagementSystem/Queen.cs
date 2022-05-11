using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee, INotifyPropertyChanged
    {
        public string StatusReport { get; private set; }
        public override float CostPerShift { get { return 2.15f; } }

        private const float EGGS_PER_SHIFT = 0.45f;
        private const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        private float eggs;
        private float unassignedWorkers = 3;

        private IWorker[] workers = new IWorker[0];

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Resizes the array and adds a Bee Object to the end.
        /// </summary>
        /// <param name="worker">Takes in a Bee object(worker)</param>
        private void AddWorker(IWorker worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;

                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;

                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;

                default:
                    break;
            }
            UpdateStatusReport();
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;

            foreach (IWorker worker in workers)
            {
                worker.WorkTheNextShift();
            }
            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * unassignedWorkers);
            UpdateStatusReport();
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"Vault Report:\n{HoneyVault.StatusReport}\nEgg Count: {eggs:0.0}\nUnassigned workers: {unassignedWorkers:0}\n{WorkerStatus("Nectar Collector")}\n{WorkerStatus("Honey Manufacturer")}\n{WorkerStatus("Egg Care")} \nTOTAL WORKERS: {workers.Length}";
            OnPropertyChanged("StatusReport");
        }

        /// <summary>
        /// Uses a foreach loop to count the number of bees in the workers array that match a specific job. Adds an s if there are more than one bee.
        /// </summary>
        /// <param name="job">takes a string parameter of job</param>
        /// <returns>Returns a string</returns>
        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (IWorker worker in workers)
                if (worker.Job == job)
                    count++;
            string s = "s";
            if (count == 1)
                s = "";
            return $"{count} {job} bee{s}";

        }

        public Queen() : base("Queen")
        {
            AssignBee("Egg Care");
            AssignBee("Honey Manufacturer");
            AssignBee("Nectar Collector");
        }
    }

}
