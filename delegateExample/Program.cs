namespace delegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[]
            {
                new Employee {Id = 1, Name ="sara1", Gender = "Female" , TotalSales = 60000},
                new Employee {Id = 2, Name ="sara2", Gender = "Female" , TotalSales = 50000},
                new Employee {Id = 3, Name ="sara3", Gender = "Female" , TotalSales = 40000},
                new Employee {Id = 4, Name ="sara4", Gender = "Female" , TotalSales = 20000}


            };


            
            // use delegate
            Report report = new Report();

            report.FilterEmployee(emps, "total sales more than 60 k", greaterThan60k);

            bool greaterThan60k(Employee emp) => emp.TotalSales >= 60000m;
            bool InBetween3060(Employee emp) => emp.TotalSales >= 30000m && emp.TotalSales<= 60000;
            bool lessThan30k(Employee emp) => emp.TotalSales >= 30000m;

























            //Report report = new Report();
            //Console.WriteLine("employee with total sales more than 60k");
            //report.FilterEnployee2(emps,Sales

            //Console.WriteLine("employee with total sales between 30k and 60k");
            //report.TotalSalesBetween30kand60k(emps);

            //Console.WriteLine("employee with total sales less than 30k");
            //report.TotalSalesLesThan30k(emps);
        }

    }
}