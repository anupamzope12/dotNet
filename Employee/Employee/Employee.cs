using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Employee1
{
     public abstract class Employee 
    {
        public int empid { get; set; }
        public string? firstName { get; set; }
        public string ?lastName { get; set; }
        public double salary { get; set; }
        public int mobno { get; set; }
        public Employee() { }
        public Employee(int empid, string firstName, string lastName, double salary, int mobno)
        {
            this.empid = empid;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
            this.mobno = mobno;
        }

        public virtual void computesalry()
        {
            Console.WriteLine("In compute salary method");
            Console.WriteLine("salary = " + salary);
        }
        public override string ToString() { 
        return string.Format("EMpid:{0} firstName:{1}  lastName:{2}  salary:{3}  mobno:{4} ", empid, firstName, lastName, salary, mobno);
           // return empid + string.Format(firstName, lastName,salary,mobno);
        }
    }
}
