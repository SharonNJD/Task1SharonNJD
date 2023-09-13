using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Ball_Pythons: Snake 
    {
        private string color; 
        public Ball_Pythons(string Name, int age, bool issupperkiller, double howmuchcal, double TailLength, bool Venomes,string color) : base(Name, age, issupperkiller, howmuchcal, TailLength, Venomes)
        {
            this.color = color;
        }
        public string GetColor() {  return this.color; }
        public void SetColor(string Color) { this.color = Color;}

        public new string ToString()
        {
             return base.ToString() + ',' + color;
        }
    }
}
