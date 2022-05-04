using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDamageCalculatorInheritance
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 1M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.75M;

        /// <summary>
        /// Contains the calculated damage
        /// </summary>
        public int Damage { get; private set; }
        private int roll;
        private bool flaming;
        private bool magic;


        /// <summary>
        /// Sets or gets the 3d6 roll
        /// </summary>
        public int Roll
        {
            get => roll;
            set { roll = value; CalculateDamage(); }

        }

        /// <summary>
        /// True if the sword is flaming, otherwise false.
        /// </summary>
        public bool Flaming
        {
            get => flaming;
            set { flaming = value; CalculateDamage(); }
        }

        /// <summary>
        /// True if the sword is magic, otherwise false.
        /// </summary>
        public bool Magic
        {
            get => magic;
            set { magic = value; CalculateDamage(); }
        }

        /// <summary>
        /// Calculates damage based on the current properties.
        /// </summary>
        private void CalculateDamage()
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
        public ArrowDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
    }
}
