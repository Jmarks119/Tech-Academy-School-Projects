using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDrill19
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Plampeyn", Id = 1 },
                new Employee() {FirstName = "Pepe", LastName = "Posnett", Id = 2 },
                new Employee() {FirstName = "Bord", LastName = "Eidelman", Id = 3 },
                new Employee() {FirstName = "Carma", LastName = "Sheepy", Id = 4 },
                new Employee() {FirstName = "Harvey", LastName = "Jacobowits", Id = 5 },
                new Employee() {FirstName = "Adlai", LastName = "Walliker", Id = 6 },
                new Employee() {FirstName = "Jessa", LastName = "Ind", Id = 7 },
                new Employee() {FirstName = "Joe", LastName = "McDyer", Id = 8 },
                new Employee() {FirstName = "Linoel", LastName = "Pilgrim", Id = 9 },
                new Employee() {FirstName = "Tamarah", LastName = "Westcarr", Id = 10 }
            };

            List<Employee> foreachList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    foreachList.Add(employee);
                }
            }
            List<Employee> lambdaList = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> lambdaList2 = employees.Where(x => x.Id > 5).ToList();
        }
    }
}
