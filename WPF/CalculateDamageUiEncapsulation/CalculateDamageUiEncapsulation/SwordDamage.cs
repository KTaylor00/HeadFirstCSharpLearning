using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDamageUiEncapsulation
{
    internal class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

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
            get { return roll; }
            set { roll = value; CalculateDamage(); }
        }

        /// <summary>
        /// True if the sword is flaming, otherwise false.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set { flaming = value; CalculateDamage(); }
        }

        /// <summary>
        /// True if the sword is magic, otherwise false.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set { magic = value; CalculateDamage(); }
        }

        /// <summary>
        /// Calculates damage based on the current properties.
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
                magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (flaming)
                Damage += FLAME_DAMAGE;
            Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }

        /// <summary>
        /// The constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="roll">starting 3d6 roll</param>
        public SwordDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
    }
}
