using System.Text.Json;

namespace Prototype
{
    public abstract class Person
    {
        public abstract string Name { get; set; }

        public abstract Person Clone(bool deepClone);
    }

    public class Manager : Person
    {
        public override string Name {get; set; }

        public Manager(string name)
        {
            this.Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            return (Person)MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        public override string Name { get; set; }
        public Manager Manager { get; set; }

        public Employee(string name, Manager manager)
        {
            this.Name = name;
            this.Manager = manager;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var personSerialized = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Employee>(personSerialized);
            }

            return (Person)MemberwiseClone();
        }
    }
}
