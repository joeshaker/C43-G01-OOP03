using Ass3OOP.Classes;
using Ass3OOP.DerivedClasses;
using Ass3OOP.Enums;

namespace Ass3OOP
{
    internal class Program
    {
        #region Function Q4
        //static Employee[] Compare(Employee[] EmpArr)
        //{
        //    for (int i = 0; i < EmpArr.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < EmpArr.Length; j++)
        //        {
        //            if (EmpArr[i].HiringDate.Year > EmpArr[j].HiringDate.Year)
        //            {
        //                Employee emp = EmpArr[i];
        //                EmpArr[i] = EmpArr[j];
        //                EmpArr[j] = emp;
        //            }
        //            else if (EmpArr[i].HiringDate.Year == EmpArr[j].HiringDate.Year)
        //            {
        //                if (EmpArr[i].HiringDate.Month > EmpArr[j].HiringDate.Month)
        //                {
        //                    Employee emp = EmpArr[i];
        //                    EmpArr[i] = EmpArr[j];
        //                    EmpArr[j] = emp;
        //                }
        //                else if (EmpArr[i].HiringDate.Month == EmpArr[j].HiringDate.Month)
        //                {
        //                    if (EmpArr[i].HiringDate.Day > EmpArr[j].HiringDate.Day)
        //                    {
        //                        Employee emp = EmpArr[i];
        //                        EmpArr[i] = EmpArr[j];
        //                        EmpArr[j] = emp;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return EmpArr;
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Q2,2

            //Employee Emp1 = new Employee(id: 1, name: "Youssef Shaker", securityLevel: Enums.SecurityPrivileges.Developer, gender: Gender.Male, dateTime: new HiringDate(20, 7, 2024), salary: 505);
            //Console.WriteLine(Emp1.Salary);
            #endregion
            #region Q3
            //bool isParsed;
            //int id;
            //SecurityPrivileges privileges;
            //Gender gender;
            //Employee[] EmpArr = new Employee[3];

            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    EmpArr[i] = new Employee();

            //    Console.WriteLine($"Enter The data of Employee {i}");
            //    do
            //    {
            //        Console.WriteLine("Enter Your Id");
            //        isParsed = int.TryParse(Console.ReadLine(), out id);

            //    } while (!isParsed);
            //    {
            //        EmpArr[i].Id = id;
            //    }
            //    Console.WriteLine("Enter Your Name");
            //    EmpArr[i].Name = Console.ReadLine();
            //    Console.WriteLine("Enter Your Salary");
            //    EmpArr[i].Salary = double.Parse(Console.ReadLine());
            //    do
            //    {
            //        Console.WriteLine("Enter Your Privillage");
            //        isParsed = Enum.TryParse<SecurityPrivileges>(Console.ReadLine(), out privileges);


            //    } while (!isParsed);
            //    {
            //        EmpArr[i].SecurityLevel = privileges;
            //    }
            //    do
            //    {
            //        Console.WriteLine("Enter Your Gender");
            //        isParsed = Enum.TryParse<Gender>(Console.ReadLine(), out gender);


            //    } while (!isParsed);
            //    {
            //        EmpArr[i].Gender = gender;
            //    }
            //    Console.WriteLine("Enter Your HiringDate");
            //    EmpArr[i].HiringDate = new HiringDate();
            //    EmpArr[i].HiringDate.Day = int.Parse(Console.ReadLine());
            //    EmpArr[i].HiringDate.Month = int.Parse(Console.ReadLine());
            //    EmpArr[i].HiringDate.Year = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i].ToString());
            //}

            #endregion
            #region Q4

            //Employee Emp1 = new Employee(id: 1, name: "Youssef Shaker", securityLevel: Enums.SecurityPrivileges.DBA, gender: Gender.Male, dateTime: new HiringDate(20, 9, 2025), salary: 505);
            //Employee Emp2 = new Employee(id: 1, name: "ali Shaker", securityLevel: Enums.SecurityPrivileges.Guest, gender: Gender.Male, dateTime: new HiringDate(20, 8, 2028), salary: 505);
            //Employee Emp3 = new Employee(id: 1, name: "Rodina Elgayar", securityLevel: Enums.SecurityPrivileges.SecurityOffice, gender: Gender.female, dateTime: new HiringDate(20, 7, 2023), salary: 505);
            //Employee[] EmpArr = [Emp1,Emp2,Emp3];
            //Employee[]Result=Compare(EmpArr);
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(Result[i].ToString());
            //}

            #endregion
            #region Q5
            //Book b1 = new Book("Math", "Youssef", "55225");
            //EBook Eb1 = new EBook("Arabic", "Ali", "574845", 300);
            //PrintedBook Pb1 = new PrintedBook("Arabic", "Ali", "574845", 30);
            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(Eb1.ToString());
            //Console.WriteLine(Pb1.ToString()); 
            #endregion


        }
    }
}
