using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    /// <summary>
    /// Collects nectar each shift and adds it to the vault.
    /// </summary>
    internal class NectarCollector : Bee
    {
        /// <summary>
        /// Determines how much nectar is collected and how much is converted to honey each shift.
        /// </summary>
        private const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        public override float CostPerShift
        {
            get { return 1.95f; }
        }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }

        public NectarCollector() : base("Nectar Collector")
        {
        }
    }
}
