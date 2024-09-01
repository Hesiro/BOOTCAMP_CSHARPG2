namespace Relation_FluentApi.Models.OneToMany
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Book? Book { get; set; }
    }
}
