using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculatorBlazorApp
{
    internal class SwordDamage
    {
        private static Random random = new Random();

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public int Damage { get; private set; }

        private int roll;
        private bool flaming;
        private bool magic;

        public int Roll { get { return roll; } set { roll = value; CalculateDamage(); } }

        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }

        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }

        public void RollDice()
        {
            Roll = random.Next(1, 7) * 3;
        }

        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
                magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming)
                Damage += FLAME_DAMAGE;
        }

        public SwordDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }
    }
}
