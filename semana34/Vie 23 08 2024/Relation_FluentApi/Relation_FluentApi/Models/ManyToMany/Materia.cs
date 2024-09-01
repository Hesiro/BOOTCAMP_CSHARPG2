namespace Relation_FluentApi.Models.ManyToMany
{
    public class Materia
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<StudentMateria>? StudentsMaterias { get; set; }
    }
}
