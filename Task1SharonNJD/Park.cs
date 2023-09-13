using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SharonNJD
{
    internal class Park
    {
        private Animal[] ListOfAnimals;

        private int NumOfAnimals;

        public Park() { ListOfAnimals = new Animal[1000];
            NumOfAnimals = 0;
        }
        public void add(Animal woof)
        {
            for (int i = 0; i < ListOfAnimals.Length; i++)
            {
                if (ListOfAnimals[i] == null)
                {
                    ListOfAnimals[i] = woof;
                    NumOfAnimals++;
                    i = 10000;
                }
            }
        }
        public  Animal[] GetOldKillers()
        {
            int num = 0;
            for (int i = 0; i < ListOfAnimals.Length; i++)
            {
                if (ListOfAnimals[i].GetIssupperkiller() == true && ListOfAnimals[i].GetAge() > 10)
                {
                    num++;
                }
            }
            Animal[] list = new Animal[num];
            num= 0;
            for (int i = 0; i < ListOfAnimals.Length; i++)
            {
                if (ListOfAnimals[i].GetIssupperkiller() == true && ListOfAnimals[i].GetAge() > 10)
                {
                    list[num] = ListOfAnimals[i];
                    num++;
                }
            }
            return list;

        }
        public int SuperKIller()
        {
            int num=0;
            for (int i = 0; i < ListOfAnimals.Length; i++)
            {
                if ((ListOfAnimals[i] is Reptile || ListOfAnimals[i] is Bird) && ListOfAnimals[i].GetIssupperkiller() == true)
                {
                    num++;
                }
            }
            return num;
        }
    }
}
