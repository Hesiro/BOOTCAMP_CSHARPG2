namespace RelacionesEF_DataAnotations.Models.ManyToMany
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Student>? Students { get; set; }
    }
}
