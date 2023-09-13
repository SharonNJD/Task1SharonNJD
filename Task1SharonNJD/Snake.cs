using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Snake: Reptile
    {
        private bool Venomes;

        public Snake(string Name, int age, bool issupperkiller, double howmuchcal, double TailLength, bool Venomes) : base(Name, age, issupperkiller, howmuchcal, TailLength)
        { this.Venomes = Venomes; }
        public bool GetBodyFat() { return this.Venomes; }
        public void SetBodyFat(bool Venomes) { this.Venomes = Venomes; }

        public new string ToString() { return base.ToString() + ',' + this.Venomes.ToString(); }
        public string dance()
        {
            return "she only wants to dance";
        }
    }
}
