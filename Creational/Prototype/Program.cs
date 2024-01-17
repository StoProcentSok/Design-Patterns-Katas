using Prototype;

Console.Title = "Prototype";

var manager = new Manager("Manager Karen");

var employee = new Employee("Employee Rob", manager);

Console.WriteLine($"employee created with manager: {employee.Manager.Name}");

var clonedEmployee = (Employee)employee.Clone(true);

Console.WriteLine($"employee Cloned with manager: {employee.Manager.Name}");

manager.Name = "Changed name";
Console.WriteLine("Original manager name changed");

Console.WriteLine($"employee Cloned with manager: {clonedEmployee.Manager.Name}");

Console.ReadLine();
