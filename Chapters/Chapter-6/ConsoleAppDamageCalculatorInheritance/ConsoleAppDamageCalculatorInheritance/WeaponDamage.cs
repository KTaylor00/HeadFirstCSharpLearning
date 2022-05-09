using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDamageCalculatorInheritance
{
    abstract class WeaponDamage
    {
        /// <summary>
        /// Contains the calculated damage
        /// </summary>
        public int Damage { get; protected set; }

        ////// <summary>
        /// Sets or gets the 3d6 roll
        /// </summary>
        private int roll;
        public int Roll
        {
            get => roll;
            set { roll = value; CalculateDamage(); }

        }

        /// <summary>
        /// True if the sword is flaming, otherwise false.
        /// </summary>
        private bool flaming;
        public bool Flaming
        {
            get => flaming;
            set { flaming = value; CalculateDamage(); }
        }

        /// <summary>
        /// True if the sword is magic, otherwise false.
        /// </summary>
        private bool magic;
        public bool Magic
        {
            get => magic;
            set { magic = value; CalculateDamage(); }
        }

        /// <summary>
        /// Calculates damage based on the current properties.
        /// </summary>
        protected abstract void CalculateDamage();

        /// <summary>
        /// The constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="roll">starting 3d6 roll</param>
        public WeaponDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
    }
}
