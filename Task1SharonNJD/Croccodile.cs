using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Croccodile:Reptile
    {
        private bool DidHaveDentinst;

        public Croccodile(string Name, int age, bool issupperkiller, double howmuchcal,  double TailLenght, bool DidHaveDentinst) : base(Name, age, issupperkiller, howmuchcal,TailLenght )
        { this.DidHaveDentinst = DidHaveDentinst; }
        public bool GetBodyFat() { return this.DidHaveDentinst; }
        public void SetBodyFat(bool DidHaveDentinst) { this.DidHaveDentinst = DidHaveDentinst; }

        public new string ToString() { return base.ToString() + ',' + this.DidHaveDentinst.ToString(); }
    }
}
