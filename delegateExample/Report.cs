using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExample
{
    internal class Report
    {
        public delegate bool SalesFilterCondtion(Employee emp);
        public void FilterEmployee(Employee[] emp, string Title, SalesFilterCondtion cond)
        {
            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Name}| {e.Id} | {e.Gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");




        }



        public delegate bool SalesFilterCondtion2(Employee emp);
        public void FilterEmployee2(Employee[] emp, string Title, SalesFilterCondtion cond)
        {

            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Name}| {e.Id} | {e.Gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");


        }



        public delegate bool SalesFilterCondtion3(Employee emp);
        public void FilterEmployee3(Employee[] emp, string Title, SalesFilterCondtion cond)
        {

            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Name}| {e.Id} | {e.Gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");


        }




        }

        // common factor 

        
        
    }

