using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikAbstraction
{
    public abstract class Employees
    {
        public virtual string EmployeeName { get; set; }
        public virtual string EmployeeSurName { get; set; }

        public virtual string Department { get; set; }

        public Employees(string employeeName, string employeeSurName, string department)
        {
            EmployeeName = employeeName;
            EmployeeSurName = employeeSurName;
            Department = department;
        }
        public abstract void Task();

    }

   class SoftwareDeveloper : Employees
    {
        public SoftwareDeveloper(string employeeName, string employeeSurName, string department) : base(employeeName, employeeSurName, department)
        { }

        public override void Task()
        {
            Console.WriteLine("I work as a software developer!");
        }
    }

    class SalesRepresentative : Employees
    {
        public SalesRepresentative(string employeeName, string employeeSurName, string department) : base(employeeName, employeeSurName, department)
        {
        }

        public override void Task()
        {
            Console.WriteLine("Im a Sales Representative!");
        }
    }
    class GraphicDesigner : Employees
    {
        public GraphicDesigner(string employeeName, string employeeSurName, string department) : base(employeeName, employeeSurName, department)
        {}

        public override void Task()
        {
            Console.WriteLine("Im a Graphic Designer!");
        }
    }
}
