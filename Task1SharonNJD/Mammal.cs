using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Mammal: Animal
    {
        private double MilkCal;
        private int PregMon;
       
        public Mammal(string Name, int age, bool issupperkiller, double howmuchcal ,double milkCal, int pergMon) : base( Name,  age,  issupperkiller,  howmuchcal)
        {
            MilkCal = milkCal;
            PregMon = pergMon;
        }
        public double GetMilkCal()
        {
            return this.MilkCal;
        }
        public int GetPregMon()
        {
            return this.PregMon;
        }
        public void SetMilkCal(double num)
        {
            this.MilkCal = num;
        }
        public void SetPergMon(int num) { this.PregMon = num; }
        public override string ToString()
        {
            return base.ToString() + "," + MilkCal.ToString() + "," + PregMon.ToString();
        }
        public new double Eat()
        {
            return base.Eat() + this.MilkCal;
        }
    }
}
