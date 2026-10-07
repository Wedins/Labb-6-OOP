namespace Labb_6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Jonna", "Female", 25.750m);
            Employee employee2 = new Employee(2, "Johan", "Male", 28.350m);
            Employee employee3 = new Employee(3, "Rickard", "Male", 32.430m);
            Employee employee4 = new Employee(4, "Jonna", "Female", 34.120m);
            Employee employee5 = new Employee(5, "Jonna", "Female", 22.453m);

            Stack<Employee> employees = new Stack<Employee>();

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            

            foreach (var Employee in employees)
            {
                Console.WriteLine(Employee);
                
                employees.ToString();
            }
        }
    }
}
