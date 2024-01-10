using API_ZapBank.Enums;
using System.ComponentModel.DataAnnotations;

namespace API_ZapBank.Models
{
    public class EmployeeModel{
        [Key] // para identificar que o id é um cahve primaria
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DepartmentEnum Department { get; set; }
        public bool Activate { get; set; }
        public OfficeHourEnum OfficeHour { get; set; }
        public DateTime CreationData { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime ChangeData { get; set; } = DateTime.Now.ToLocalTime();
        
    }
}
