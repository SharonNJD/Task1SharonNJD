using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Bulbul: Bird
    {
        private bool CanSing;

        public Bulbul(string Name, int age, bool issupperkiller, double howmuchcal, double flightheight, double flightwingswitdh,bool sing) : base(Name, age, issupperkiller, howmuchcal,flightheight,flightwingswitdh)
        {
            this.CanSing = sing;

        }
        public bool GetCanSing() {  return this.CanSing; }
        public void SetCanSing(bool can) { this.CanSing = can; }

        public new string ToString()
        {
            return base.ToString() + ',' + this.CanSing.ToString();
        }
    }

}
