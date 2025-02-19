using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    public class Kor
    {
        private double sugar = 0.0,
            kerulet = 0.0,
            terulet = 0.0;
        public Kor(double r)
        {
            this.sugar = r;
        }
        public double SetKerulet(double r)
        {
            // return this.kerulet = 2 * r * Math.PI;
            return 0.0;
        }
        public double SetTerulet(double r)
        {
            // return this.kerulet = r * r * Math.PI;
            return 0;
        }
        public double GetSugar()
        {
            return sugar;
        }
    }
}
