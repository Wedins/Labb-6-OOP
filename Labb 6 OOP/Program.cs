
namespace Labb_6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>();
            List<Employee> employeesList = new List<Employee>();

            Employee employee1 = new Employee(1, "Jonna", "Female", 25.750m);
            Employee employee2 = new Employee(2, "Johan", "Male", 28.350m);
            Employee employee3 = new Employee(3, "Rickard", "Male", 32.430m);
            Employee employee4 = new Employee(4, "Jonna", "Female", 34.120m);
            Employee employee5 = new Employee(5, "Johanna", "Female", 22.453m);

            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);

            PushEmployees(employees, employeesList);

            foreach (var e in employees)
            {
                Console.WriteLine(e);
                Console.WriteLine($"\nDet finns {employees.Count} kvar.");
            }
            Console.WriteLine("---------------------------------------");
            while (employees.Count > 0)
            {
                Console.WriteLine(employees.Pop());
                Console.WriteLine($"\nDet finns {employees.Count} kvar.");
            }

            PushEmployees(employees, employeesList);

            Console.WriteLine("\nHär börjar peek loopen.");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(employees.Peek());
                Console.WriteLine($"\nDet finns {employees.Count} kvar.");
            }

            if (employees.Any(x => x.Id == 3))
            {
                Console.WriteLine("\nObjekt 3 finns i registret.");
            }

            else
            {
                Console.WriteLine("Objekt 3 finns inte i registret.");
            }

            Console.WriteLine("\nRegistret över alla anställda.");
            Console.WriteLine("--------------------------------");

            foreach (var e in employeesList)
            {
                Console.WriteLine(e);
            }

            if (employeesList.Contains(employee2))
            {
                Console.WriteLine($"\nEmployee2 object exists in the list.");

            }
            else
            {
                Console.WriteLine("\nEmployee2 object does not exist in the list.");
            }

            Employee foundMale = employeesList.Find(x => x.Gender == "Male");


            if (foundMale != null)
            {
                Console.WriteLine($"\nHittade {foundMale}");
            }

            else
            {
                Console.WriteLine("Hittade inga manliga anställda.");
            }

            List<Employee> employeeMales = employeesList.FindAll(x => x.Gender == "Male");
             
            Console.WriteLine("\nHär är alla manliga anställda.");
            foreach (var males in employeeMales)
            {
                Console.WriteLine(males);
            }
        }
        static void PushEmployees(Stack<Employee> employees, List<Employee> employeeList)
        {
            employees.Push(new Employee(1, "Jonna", "Female", 25.750m));
            employees.Push(new Employee(2, "Johan", "Male", 28.350m));
            employees.Push(new Employee(3, "Rickard", "Male", 32.430m));
            employees.Push(new Employee(4, "Jonna", "Female", 34.120m));
            employees.Push(new Employee(5, "Johanna", "Female", 22.453m));
        }
    }
}
