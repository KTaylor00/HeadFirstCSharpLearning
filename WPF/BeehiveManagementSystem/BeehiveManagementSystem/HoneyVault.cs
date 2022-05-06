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
        private static float honey = 25f;
        private static float nectar = 100f;

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

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static float CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
            return amount;
        }
    }
}
