using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Reptile:Animal, IReptile
    {
        private double TailLength;

        public Reptile(string Name, int age, bool issupperkiller, double howmuchcal, double TailLength) : base(Name, age, issupperkiller, howmuchcal)
        {
            this.TailLength = TailLength;

        }
        public double GetTailLength() { 
        return this.TailLength;
        }
        public void SetTailLength(double num)
        { this.TailLength = num; }
        public new string ToString() {
            return base.ToString() +"," + TailLength.ToString();
        
        }
        public void Crawl()
        {
            Console.WriteLine("sneaky");
        }
        public void Protect()
        {
            Console.WriteLine(" protecting in progress ");
        }
        public void CheckBloodTemp()
        {
            Console.WriteLine("hmmmm cold");
        }

        public override void Breathing()
        {
            Console.WriteLine("sniff");
        }
        public override void Growing() { this.Age++; Console.WriteLine("bigger"); }
        public override void Mate() { Console.WriteLine("not famliy freindly"); }
    }
}
