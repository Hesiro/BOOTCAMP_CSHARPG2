namespace Relation_FluentApi.Models.OneToMany
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Pattient>? Pattients { get; set; }
    }
}
