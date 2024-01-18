using System.Text.Json;

namespace Prototype.Entities
{
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
