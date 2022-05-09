using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDamageCalculatorInheritance
{
    internal class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.75M;

        /// <summary>
        /// Calculates damage based on the current properties.
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic)
                baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming)
                Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else
                Damage = (int)Math.Ceiling(baseDamage);
        }

        /// <summary>
        /// The constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="roll">starting 3d6 roll</param>
        public ArrowDamage(int roll) : base(roll) { }
    }
}
