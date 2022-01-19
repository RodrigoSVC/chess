using System;
using System.Globalization;

namespace Primeiro
{
    class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
        
        public void Salario (double porcentagem)
        {
            Salary += Salary * porcentagem / 100.0;
        }


        public override string ToString()
        {
            return ID
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

             
    }

        
        
    }

