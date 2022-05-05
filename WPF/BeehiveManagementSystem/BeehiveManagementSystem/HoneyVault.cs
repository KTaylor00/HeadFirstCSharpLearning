using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        private const float NECTAR_CONVERSION_RATIO = .19f;
        private const float LOW_LEVEL_WARNING = 10f;

        public static string StatusReport
        {
            get
            {
                string report = $"Vault report:\n{honey} units of honey\n{nectar} units of nectar";

                if (honey < LOW_LEVEL_WARNING)
                {
                    return "LOW HONEY - ADD A HONEY MANUFACTURER";
                }

                if (nectar < LOW_LEVEL_WARNING)
                {
                    return "LOW NECTAR - ADD A NECTAR COLLECTOR";
                }

                return report;
            }
        }
        private static float honey = 25f;
        private static float nectar = 100f;

        public static float ConvertNectarToHoney(float amount)
        {
            nectar -= amount;
            honey += amount * NECTAR_CONVERSION_RATIO;

            if (amount < nectar)
            {
                nectar = honey;
            }
            return amount;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount > honey)
            {
                honey -= amount;
                return true;
            }
            else
                return false;
        }

        public static float CollectNectar(float amount)
        {
            if (amount > 0)
            {
                honey += amount;
            }
            return amount;
        }
    }
}
