namespace RelacionesEF_DataAnotations.Models.OneToOne
{
    public class CarModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //Relacion de uno a uno
        public int CarCompanyId { get; set; } //Clave foranea
        public CarCompany? CarCompany { get; set; } //Propiedad de navegacion
    }
}
