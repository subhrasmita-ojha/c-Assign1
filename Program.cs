using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Assignment
{
    public class Employee
    {
        public delegate void EmpAction(string[] msg, int i);
        public event EmpAction Action;
        public string[] s1 = new string[3];
        public int i;

        public void DoAction()
        {
            Action(s1, i);
        }
        private int Id;
        private string emp_name;
        private string dept_name;

        public Employee(int Id, string emp_name, string dept_name)
        {
            this.Id = Id;
            this.emp_name = emp_name;
            this.dept_name = dept_name;

        }

        public int GetId(Employee E1)
        {
            i = 0;
            s1[0] = MethodBase .GetCurrentMethod().Name;
            E1.Action += new Employee.EmpAction(show_Action);
            E1.DoAction();
            return this.Id;

        }

        public string GetName(Employee E1)
        {
            i = 1;
            s1[1] = MethodBase.GetCurrentMethod().Name;
            E1.Action += new Employee.EmpAction(show_Action);
            E1.Action -= new Employee.EmpAction(show_Action);
            E1.DoAction();
            return this.emp_name;
        }

        public string GetDepartmentName(Employee E1)
        {
            i = 2;
            s1[2] = MethodBase.GetCurrentMethod().Name;
            E1.Action += new Employee.EmpAction(show_Action);
            E1.Action -= new Employee.EmpAction(show_Action);
            E1.DoAction();
            return this.dept_name;
        }

        public void show_Action(string[] msg, int i)
        {
            Console.WriteLine(msg[i] + "method is called");

        }

        public void set(int uid)
        {
            Id = uid;
            Console.WriteLine("Updated Id :" + Id);
        }

        public void set(string name)
        {
            emp_name = name;
            Console.WriteLine("Updated employee name:" + emp_name);

        }
        public void set(string name, int Id)
        {
            dept_name = name;
            Console.WriteLine("Updated Department Name:" + dept_name);
        }

    }
}
    
