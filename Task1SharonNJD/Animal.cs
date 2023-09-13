using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal abstract class Animal
    {
        protected string Name;
        protected int Age;
        protected bool Issupperkiller;
        protected double Howmuchcal;
        

        public  Animal(string Name, int age, bool issupperkiller, double howmuchcal)
        {
            this.Name = Name;
            this.Age = age;
            this.Issupperkiller = issupperkiller;
            this.Howmuchcal = howmuchcal;
        }
         public string GetName()
        {
            return this.Name;
        }
        public int GetAge()
        {
            return this.Age;
        }
        public bool GetIssupperkiller()
        {
            return this.Issupperkiller;
        }
        public double getHowmuchcal()
        {
            return this.Howmuchcal;
        }
        public void SetName(string name)
        {
            this.Name=name;
        }
        public void SetAge(int age)
        {
            this.Age=age;
        }
        public void SetIssupperkiller(bool killer)
        {
            this.Issupperkiller = killer;
        }
        public void SetHowmuchcal(double num)
        {
            this.Howmuchcal=num;
        }
        public override string ToString()
        {
            return Name + ',' + Age.ToString() + "," + Issupperkiller.ToString() + "," + Howmuchcal.ToString();
        }
        public double Eat()
        {
            return (Howmuchcal*3);
        }

        public abstract void Mate();
        public abstract void Growing();
        public abstract void Breathing();
    }
}
