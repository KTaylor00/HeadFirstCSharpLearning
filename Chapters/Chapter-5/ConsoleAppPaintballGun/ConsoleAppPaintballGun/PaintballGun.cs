using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaintballGun
{
    internal class PaintballGun
    {
        public int MagazineSize { get; private set; }

        private int balls;
        public int BallsLoaded { get; private set; }

        public bool IsEmpty() => BallsLoaded == 0;

        public PaintballGun(int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded)
                Reload();
        }

        public int Balls
        {
            get { return balls; }

            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }

        public void Reload()
        {
            if (balls < MagazineSize)
                BallsLoaded = MagazineSize;
            else
                BallsLoaded = balls;
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0 || balls == 0)
                return false;

            BallsLoaded--;
            balls--;

            return true;
        }
    }
}
