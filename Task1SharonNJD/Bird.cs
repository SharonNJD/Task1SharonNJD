using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Bird:Animal, IBirdcs
    {
        private double FlightHeight;
        private double FlightWingsWidth;

        public Bird(string Name, int age, bool issupperkiller, double howmuchcal, double flightheight, double flightwingswitdh):base(Name,age,issupperkiller,howmuchcal) { 
        this.FlightHeight = flightheight;
        this.FlightWingsWidth = flightwingswitdh;
        }
        public double GetFlightHeight() {  return this.FlightHeight; }
        public double GetFlightWingsWidth() { return this.FlightWingsWidth; }

        public void SetFlightHeight(double num) {  this.FlightHeight = num; }
        public void SetFlightWingsWidth(double num) { this.FlightWingsWidth = num; }

        public new string ToString()
        {
            return base.ToString() + this.FlightHeight.ToString() + this.FlightWingsWidth.ToString();
        }
        public string Sing()
        {
            return "kakakaka";
        }
        public string dance()
        {
            return "she only wants to dance";
        }
        public void Takeoff()
        {
            Console.WriteLine("we are taking off boys");
        }
        public void Glide()
        {
            Console.WriteLine("we are glading boys");
        }
        public void Landing()
        {
            Console.WriteLine("we are landing boys");
        }
        public override  void Breathing()
        {
            Console.WriteLine("sniff");
        }
        public override  void Growing() { Console.WriteLine("bigger"); }
        public override void Mate() { Console.WriteLine("not famliy freindly"); }
    }
}
