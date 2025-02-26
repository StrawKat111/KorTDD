using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    public class Korok
    {
        private double sugar = 0.0,
            kerulet = 0.0,
            terulet = 0.0;
        public Korok(double r)
        {
            this.sugar = r;
        }
        public void setSugar(double r)
        {
            this.sugar = r;
        }
        public double setKerulet(double r)
        {
            if (r<=0.0)
            {
                throw new ArgumentException();
            }
            return 2 * this.sugar * Math.Round(Math.PI,2);
        }
        public double setTerulet(double r)
        {
            // return this.kerulet = r * r * Math.PI;
            return 0;
        }
        public double getSugar()
        {
            return sugar;
        }
    }
}
