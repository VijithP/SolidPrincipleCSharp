using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    public class SingleReposibility
    {

        Employee emp = new Employee() { Employee_Id = 101, Employee_Name = "Vijith" };
        public SingleReposibility()
        {
            emp.InsertIntoEmployeeTable(emp);
            Console.WriteLine("Employee Data inserted");

            emp.SelectFromFromEmployeeTable(emp);
            Console.WriteLine("Employee Data selected");
        }

    }

    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public DateTime DOJ { get; set; }

        /// <summary>
        /// This class using for all employee related logic.
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully select inserted deleted</returns>
        public bool InsertIntoEmployeeTable(Employee em)
        {
            // Insert into employee table.
            return true;
        }
        public bool DeleteFromFromEmployeeTable(Employee em)
        {
            // delete from employee table.
            return true;
        }

        public List<Employee> SelectFromFromEmployeeTable(Employee em)
        {
            // Seleted From employee table.
            List<Employee> employeeList = new List<Employee>();
            return employeeList;
        }



        //Remove code related Master table task
        //public bool InsertIntoTaskTable(Tasks em)
        //{
        //    // Insert into employee table.
        //    return true;
        //}


    }


}
