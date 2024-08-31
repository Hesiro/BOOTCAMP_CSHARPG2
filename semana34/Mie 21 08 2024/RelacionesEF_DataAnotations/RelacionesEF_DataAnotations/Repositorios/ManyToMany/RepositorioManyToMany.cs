using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Data;
using RelacionesEF_DataAnotations.Models.ManyToMany;

namespace RelacionesEF_DataAnotations.Repositorios.ManyToMany
{
    public class RepositorioManyToMany
    {
        private readonly AppDbContext _context;
        public RepositorioManyToMany(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        //student
        public async Task AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetStudents() =>
            await (_context.Students.ToListAsync());

        //subject
        public async Task AddSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Subject>> GetSubjects() =>
            await (_context.Subjects.ToListAsync());
    }
}
