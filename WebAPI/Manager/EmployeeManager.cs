using ModelLayer.EmployessEntities;
using ModelLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Abstract;

namespace WebAPI.Manager
{
    public class EmployeeManager
    {
        IEmployessAPI employessAPI;
        public EmployeeManager(IEmployessAPI employessAPI)
        {
            this.employessAPI = employessAPI;   
        }
        public async Task<List<Employess>> GetAllEmployee()
        {
            var model = await employessAPI.GetAll("api/employess");
            return model;
        }
        public async Task<Employess> GetByIdEmployee(int id)
        {
            var model = await employessAPI.GetById("api/employess", id);
            return model;
        }
        public async Task<string> DeleteEmployee(int id)
        {
            await employessAPI.Delete("api/employess", id);
            return null;
        }
        public async Task<string> AddEmployee(Employess employee)
        {
            await employessAPI.Add("api/employess", employee);
            return null;
        }
        public async Task<string> UpdateEmployee(Employess employee, int id)
        {
            await employessAPI.Update("api/employess", id, employee);
            return null;
        }
    }
}
