namespace RelacionesEF_DataAnotations.Models.OneToMany
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //relacion uno amuchos
        public List<Patient>? Patients { get; set; }
    }
}
