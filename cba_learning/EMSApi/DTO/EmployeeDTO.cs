using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace EMSApi.DTO
{
    public class EmployeeDTO
    {
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        [Min(18)]
        [Max(60)]
        public int Age { get; set; }
    }
}
