using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Classroom
    {
        private string name;
        List<Person> persons = new List<Person>();
       
        public Classroom(string name)
        {
            this.name = name;
        }

        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }


        public int showsumageClass()
        {
            int sumage = 0;
            foreach (Person p in this.persons)
            {
                sumage += p.getAge();
            }
            return sumage;
        }
        public double AvggradeinClass()
        {
            double avggrade = 0;
            int n = 0;
            foreach (Person p in this.persons)
            {
                avggrade += p.getGPA();
                n++;
            }
            return avggrade / n;
        }


    }
}
