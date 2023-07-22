using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    
    internal class Manager : Employee
    {
        public string ?deptName;
        public int deptid;
        public double bonus;
        public double salary1;
        public Manager() { }    
        public Manager(int empid, string firstName, string lastName, double salary, int mobno,string deptName,int deptid,double bonus , double salary1):base( empid,  firstName,  lastName,  salary,  mobno)
        {
            this.deptName = deptName;
            this.deptid=deptid;
            this.bonus = bonus;
            this.salary1 = salary1;
        }
        public override void computesalry()
        {
            Console.WriteLine("In compute salary method");
            Console.WriteLine("salary = " + salary1 + bonus);
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(deptName + deptid + bonus + salary1) ;
        }
    }
}
