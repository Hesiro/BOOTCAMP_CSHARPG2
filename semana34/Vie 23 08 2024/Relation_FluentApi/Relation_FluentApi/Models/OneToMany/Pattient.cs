namespace Relation_FluentApi.Models.OneToMany
{
    public class Pattient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
