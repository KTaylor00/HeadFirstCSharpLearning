using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        /// <summary>
        /// This is very important as it adds honey to the vault, the ratio can effect the amount of honey being added to the vault.
        /// </summary>
        private const float NECTAR_CONVERSION_RATIO = .19f;
        private const float LOW_LEVEL_WARNING = 10f;
        private static float honey = 25f;
        private static float nectar = 100f;

        /// <summary>
        /// Prints a report of the honey and nectar as well as gives a low level warning.
        /// </summary>
        public static string StatusReport
        {
            get
            {
                string report = $"{honey} units of honey\n{nectar} units of nectar\n";

                string warning = "";
                if (honey < LOW_LEVEL_WARNING)
                    warning += "LOW HONEY - ADD A HONEY MANUFACTURER\n";


                if (nectar < LOW_LEVEL_WARNING)
                    warning += "LOW NECTAR - ADD A NECTAR COLLECTOR\n";

                return report + warning;
            }
        }

        /// <summary>
        /// Reduces the nectar and increases the honey.
        /// </summary>
        /// <param name="amount">takes a float amount</param>
        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            if (nectarToConvert > nectar)
            {
                nectarToConvert = nectar;
            }

            nectar -= nectarToConvert;
            honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
        }

        /// <summary>
        /// The amount of honey a bee consumes per shift.
        /// </summary>
        /// <param name="amount">takes a float amount</param>
        /// <returns>Returns true if there is enough honey, otherwise it returns false.</returns>
        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Takes an amount and then adds that amount to the nectar.
        /// </summary>
        /// <param name="amount">float parameter</param>
        public static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
        }
    }
}
