using ApplicationLayer.DTOs;
using ApplicationLayer.Interfaces;
using DomainLayer.Entities;
using InfraestructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructureLayer.Implementations
{
    public class EmployeeRepository : IEmployee
    {
        readonly AppDbContext _dbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ServiceResponse> AddAsync(Employee employee)
        {
            var response = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Name.ToLower() == employee.Name.ToLower());
            if (response != null) {
                return new ServiceResponse(false, "El empleado ya existe");
            }
            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
            return new ServiceResponse(true, "Empleado guardado exitosamente");
        }

        public async Task<ServiceResponse> DeleteAsync(int id)
        {
            var response = await _dbContext.Employees.FindAsync(id);
            if (response == null) {
                return new ServiceResponse(false, "No se encontro el empleado a eliminar");
            }
            _dbContext.Employees.Remove(response);
            await _dbContext.SaveChangesAsync();
            return new ServiceResponse(true, "Empleado eliminado exitosamente");
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _dbContext.Employees.AsNoTracking().ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _dbContext.Employees.FindAsync(id);
        }

        public async Task<ServiceResponse> UpdateAsync(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync(true);
            return new ServiceResponse(true, "Actualizado exitosamente");
        }
    }
}
