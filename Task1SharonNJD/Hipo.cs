using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Hipo : Mammal
    {
        private double BodyFat;

        public Hipo(string Name, int age, bool issupperkiller, double howmuchcal, double milkCal, int pergMon,double bodyfat) : base(Name, age, issupperkiller, howmuchcal, milkCal, pergMon)
        { this.BodyFat = bodyfat; }
        public double GetBodyFat() {  return this.BodyFat; }
        public void SetBodyFat(double bodyFat) {  this.BodyFat = bodyFat; }

        public new string ToString() {  return base.ToString() +','+ this.BodyFat.ToString(); }
    }
}
