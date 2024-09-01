namespace Relation_FluentApi.Models.ManyToMany
{
    public class Business
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PersonBusiness>? PersonsBusiness { get; set; }
    }
}
