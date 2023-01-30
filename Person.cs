using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Person
    {
        private string name;
        private double iGPA;
        private int iYear;
        private int age;
       

        public Person(string name,int iYear,int age,double iGPA)
        {
            this.name = name;
            this.iYear = iYear;
            this.age = 2566- iYear;
            this.iGPA = iGPA;

           
        }

        public double getGPA() {
            return this.iGPA;
        }
       public int getAge() 
        { 
         return this.age;
        }
         public int getbYear()
        {
            return this.iYear;
        }
        public string getName()
        {
            return this.name;
        }
       
    }
}
