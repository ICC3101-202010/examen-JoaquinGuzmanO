using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    class Person
    {
        protected string name;
        protected int age;
        protected int salary;
        protected string nacionality;

        public Person(string name, int age, int salary, string nacionality)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.nacionality = nacionality; //Chile
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public int getSalary()
        {
            return salary;
        }
        public string getNacionality()
        {
            return nacionality;
        }
    }
}
