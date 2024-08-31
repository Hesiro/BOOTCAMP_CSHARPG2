namespace RelacionesEF_DataAnotations.Models.OneToOne
{
    public class CarCompany
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //relacion uno a uno
        public CarModel? CarModel { get; set; } //Propiedad de navegacion
    }
}
