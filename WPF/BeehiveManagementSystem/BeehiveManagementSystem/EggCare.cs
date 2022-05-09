using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    /// <summary>
    /// Uses a reference to the Queen object to call her CareForEggs method to turn eggs into workers.
    /// </summary>
    internal class EggCare : Bee
    {
        private const float CARE_PROGRESS_PER_SHIFT = 0.15f;

        public override float CostPerShift
        {
            get { return 1.35f; }
        }

        private Queen queen;
        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
        }

        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }

    }
}
