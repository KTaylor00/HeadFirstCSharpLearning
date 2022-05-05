using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDamageCalculatorInheritance
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Calculates damage based on the current properties.
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
                magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming)
                Damage += FLAME_DAMAGE;
        }

        /// <summary>
        /// The constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="roll">starting 3d6 roll</param>
        public SwordDamage(int roll) : base(roll) { }
    }
}
