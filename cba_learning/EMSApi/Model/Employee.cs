using System.ComponentModel.DataAnnotations;

namespace EMSApi.Model
{
    public class Employee
    {
        [Key] // primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee()
        {

        }
        public Employee( string name, int age)
        {
           // Id = id;
            Name = name;
            Age = age;
        }
    }
}
