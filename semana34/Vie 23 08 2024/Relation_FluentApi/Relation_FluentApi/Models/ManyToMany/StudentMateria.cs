namespace Relation_FluentApi.Models.ManyToMany
{
    public class StudentMateria
    {
        public int StudentId { get; set; }
        public int MateriaId { get; set; }
        public Student? Student { get; set; }
        public Materia? Materia { get; set; }
    }
}
