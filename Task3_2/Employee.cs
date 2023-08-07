using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    internal class Employee
    {
        private String name;
        private int age;
        private double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public double getSalary()
        {
            return salary;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        
    public String toString()
        {
            return "Employee [name=" + name + ", salary=" + salary + ", age=" + age + "]";
        }
    }
}
