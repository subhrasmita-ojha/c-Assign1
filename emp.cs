using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment
{
    class emp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Employee Id");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name of the Employee ");
            string emp_name = Console.ReadLine();

            Console.WriteLine("Enter Department of the Employee ");
            string dept_name = Console.ReadLine();

            Employee E1 = new Employee(Id, emp_name, dept_name);
            int id = E1.GetId(E1);
            Console.WriteLine("Employee Id:" + id);

            string ename = E1.GetName(E1);
            Console.WriteLine("Employee Name:" + ename);

            string dname = E1.GetDepartmentName(E1);
            Console.WriteLine("Department of the employee:" + dname);

            string i = E1.GetName(E1);
            Console.WriteLine("Enter Id to Update the Employee Id");
            int update_id = Convert.ToInt32(Console.ReadLine());

            E1.set(update_id);
            Console.WriteLine("Enter name of employee to update the name");
            string update_ename = Console.ReadLine();
            E1.set(update_ename);
            Console.WriteLine("Enter department name of  the employee to update the department name");
            string update_dname = Console.ReadLine();
            E1.set(update_dname, 0);
            Console.ReadKey();


        }   
    }
}
