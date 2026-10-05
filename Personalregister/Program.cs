namespace Personalregister
{
    public class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class Registry
    {
        public List<Employee> Employees { get; } = new List<Employee>();

        public void AddEmployee(string name, decimal salary)
        {
            Employee newEmployee = new Employee(name, salary);
            Employees.Add(newEmployee);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Registry registry = new Registry();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- PERSONALREGISTER ---");
                Console.WriteLine("1. Lägg till ny anställd");
                Console.WriteLine("2. Visa personalregister");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj (1-3): ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Ange namn: ");
                    string name = Console.ReadLine();

                    Console.Write("Ange lön: ");
                    decimal salary = decimal.Parse(Console.ReadLine());

                    registry.AddEmployee(name, salary);
                    Console.WriteLine("Anställd tillagd!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\nRegistrerade anställda:");
                    foreach (var emp in registry.Employees)
                    {
                        Console.WriteLine($"Namn: {emp.Name}, Lön: {emp.Salary} kr");
                    }
                }
                else if (choice == "3")
                {
                    running = false;
                    Console.WriteLine("Avslutar programmet...");
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, försök igen.");
                }
            }
        }
    }
}