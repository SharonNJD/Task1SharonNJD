using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "vladmir", "shasha", "michel", "gibur", "boris", "slava", "yvgani" };
             Random rnd = new Random();
            Mammal [] arrmammal = new Mammal[5];
            //Animal moshe = new Animal(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100));
            arrmammal[0] = new Mammal(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            Reptile[] arrReptile = new Reptile[5];
            arrReptile[0] = new Reptile(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100));
            Animal[] arrAnimal = new Animal[8];
            arrAnimal[0] = new Mammal(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            for (int i = 1; i < arrmammal.Length; i++)
            {
                if (i%2 == 0)
                {
                    arrReptile[i] = new Snake(names[rnd.Next(0, 6)], rnd.Next(0, 100), true, rnd.Next(0, 100), rnd.Next(0, 100), true);
                     arrmammal[i] = new Hipo(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                }
                else
                {
                    arrReptile[i] = new Croccodile(names[rnd.Next(0, 6)], rnd.Next(0, 100), true, rnd.Next(0, 100), rnd.Next(0, 100), true);
                    arrmammal[i] = new Cow(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                }
            }
            arrAnimal[1] = new Croccodile(names[rnd.Next(0, 6)], rnd.Next(0, 100), true, rnd.Next(0, 100), rnd.Next(0, 100), true);
            arrAnimal[2] = new Cow(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            arrAnimal[3] = new Hipo(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            arrAnimal[4] = new Cow(names[rnd.Next(0, 6)], rnd.Next(0, 100), false, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
            arrAnimal[5] = new Croccodile(names[rnd.Next(0, 6)], rnd.Next(0, 100), true, rnd.Next(0, 100), rnd.Next(0, 100), true);
            arrAnimal[6] = new Snake(names[rnd.Next(0, 6)], rnd.Next(0, 100), true, rnd.Next(0, 100), rnd.Next(0, 100), true);
            arrAnimal[7] = new Bulbul(names[rnd.Next(0, 6)], rnd.Next(0, 100), true, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100), true);
            foreach (Animal item in arrmammal)
            {
                Console.WriteLine(item);
            }
            foreach (Animal item in arrAnimal)
            {
                Console.WriteLine(item);
            }
            foreach (Animal item in arrReptile)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            
        }
        public static double Sum(Animal[] arr)
        {

            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum =+ arr[i].getHowmuchcal();
            }
            return sum;
        }
        public static int ismammal(Animal[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Mammal)
                {
                    sum++;
                }
            }
            return sum;
        }
        public static void Dancemonkeys(Animal[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Snake)
                {
                    ((Snake)arr[i]).dance();
                }
                if (arr[i] is Bird)
                {
                    ((Bird)arr[i]).dance();
                }
            }
        }
        public static string FatestHipo(Animal[] arr)
        {
            double temp;
            double fat=-5;
            string nameofa="";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Hipo)
                {
                    temp = ((Hipo)arr[i]).GetBodyFat();
                    if (temp> fat)
                    {
                        fat = temp;
                        nameofa = arr[i].GetName();
                    }
                }
            }
            return nameofa;
        }
    }
}
