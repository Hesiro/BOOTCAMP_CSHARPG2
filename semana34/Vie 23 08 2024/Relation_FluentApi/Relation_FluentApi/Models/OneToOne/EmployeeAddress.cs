namespace Relation_FluentApi.Models.OneToOne
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
