using Dapper;
using DapperApi.Data;
using DapperApi.Model.HumanResources;

namespace DapperApi.repo;

public class HumanResourcesRepository : IHumanResourcesRepository
{

    private readonly DbContext _dbContext;


    public HumanResourcesRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        using (var con = _dbContext.GetConnection())
        {
            return await con.QueryAsync<Employee>(@"SELECT * FROM HumanResources.Employee");
        }
    }
    

    public async Task<Employee> GetEmployeeById(int id)
    {
        using (var con = _dbContext.GetConnection())
        {
            return await con.QueryFirstOrDefaultAsync<Employee>(
                @"SELECT * FROM HumanResources.Employee
                    WHERE BusinessEntityID = @Id",
            new {Id = id}
                );
        }
    }
    
}

    