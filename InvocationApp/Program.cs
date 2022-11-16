using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;

namespace InvocationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy.CreateClassProxy<Employee>(new DefensiveProgrammingAspect());
            var aspect2 = proxy.CreateClassProxy<Employee>(new InterceptionAspect());
            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "Oğuz",
                LastName = "ER"
            };

            aspect.Add(emp1.Id,emp1.FirstName,emp1.LastName);
            aspect2.Add(emp1.Id,emp1.FirstName,emp1.LastName);

            Console.ReadKey();
        }
    }
}