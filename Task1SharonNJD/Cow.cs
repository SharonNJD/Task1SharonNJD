using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Cow: Mammal
    {
        private int NumOfHamltot;

        public Cow(string Name, int age, bool issupperkiller, double howmuchcal, double milkCal, int pergMon, int NumOFhamltot) : base(Name, age, issupperkiller, howmuchcal,milkCal,pergMon)
        {
            this.NumOfHamltot = NumOFhamltot;
        }
        public int GetNumOfHamltot() {  return this.NumOfHamltot; }
        public void SetNumOfHamltot(int num) { this.NumOfHamltot = num;}
        public new string ToString()
        {
             return base.ToString() + ',' + this.NumOfHamltot.ToString();
        }
        public new double Eat()
        {
            return ((base.Eat())/4);
        }
    }
}
