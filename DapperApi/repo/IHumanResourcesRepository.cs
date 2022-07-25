using DapperApi.Model.HumanResources;

namespace DapperApi.repo;

public interface IHumanResourcesRepository
{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployeeById(int id);
}