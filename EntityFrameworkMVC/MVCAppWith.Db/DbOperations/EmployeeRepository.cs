using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;
using MVCAppWith.Db.DbOperations;

namespace MVCAppWith.Db.DbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModels models)
        {
            using (var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = models.FirstName,
                    LastName = models.LastName,
                    Email = models.Email,
                    Code = models.Code

                };

                if (models.Address != null)
                {
                    emp.Address = new Address()
                    {
                        Details = models.Address.Details,
                        Country = models.Address.Country,
                        State = models.Address.State
                    };
                }
                context.Employee.Add(emp);

                context.SaveChanges();

                return emp.Id;
            }
        }
    }

    public List<EmployeeModels> GetsAllEmployees()
    {
        using (var context = new EmployeeDBEntities())
        {
            var result = context.Employee.
                Select(x=>new EmployeeModels()
            {
                Id = x.Id,
                AddressId = x.AddressId,
                Code= x.Code,
                Email=x.Email,
                FirstName =x.FirstName,
                LastName =x.LastName,
                Address = new AddressModels()
                {
                    Id = x.Address.Id,
                    Details=x.Address.Details,
                    Country = x.Address.Country,
                    State=x.Address.State
                }
            }).ToList();

            return result;
        }
    }
     
    public EmployeeModels GetsEmployee(int id)
    {
        using (var context = new EmployeeDBEntities())
        {
            var result = context.Employee
                .Where(x=>x.Id==id)
                .Select(x => new EmployeeModels()
                {
                    Id = x.Id,
                    AddressId = x.AddressId,
                    Code = x.Code,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = new AddressModels()
                    {
                        Id = x.Address.Id,
                        Details = x.Address.Details,
                        Country = x.Address.Country,
                        State = x.Address.State
                    }
                }).FirstOrDefault();

            return result;
        }
    }
}
