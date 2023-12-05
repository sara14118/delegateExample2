using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExample
{
    public class Employee
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public decimal TotalSales { get; set; }



        public Employee()
        {


        }


        public Employee(int Id, string name, string Gender, decimal TotalSales)
        {
            this.Id = Id;
            this.Name = name;
            this.Gender = Gender;
            this.TotalSales = TotalSales;

        }
    }
}
