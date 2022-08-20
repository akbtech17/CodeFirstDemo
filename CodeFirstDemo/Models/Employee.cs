using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        
        [Range(18,60)]
        public int age { get; set; }
    }
}
