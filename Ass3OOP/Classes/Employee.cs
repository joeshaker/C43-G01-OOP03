using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass3OOP.Enums;

namespace Ass3OOP.Classes
{
    internal class Employee
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityPrivileges SecurityLevel { get; set; }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { if (value < 0)
                    Console.WriteLine("Salary Should't be nagative");
            salary = value;
            }
        }

        public Gender Gender { get; set; }

        public HiringDate HiringDate { get; set; }

        public Employee() { }

        public Employee(int id, string name, SecurityPrivileges securityLevel, double salary, Gender gender, HiringDate dateTime)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            Gender = gender;
            HiringDate = dateTime;
        }

        public Employee(SecurityPrivileges securityLevel):this( 1,
            "Youssef",securityLevel,2000,Gender.Male,new HiringDate(20,7,2024))
        {
            SecurityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, SecurrityLevel: {SecurityLevel}, Salary: {salary:c}, Gender: {Gender}, HiringDate: {HiringDate}";
        }


    }
}
