using DapperApi.Model.HumanResources;
using DapperApi.repo;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HumanResourcesController : ControllerBase
{
    private readonly IHumanResourcesRepository _humanResourcesRepository;
    // GET
    public HumanResourcesController(IHumanResourcesRepository humanResourcesRepository)
    {
        _humanResourcesRepository = humanResourcesRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Employee>> Get()
    {
        return await _humanResourcesRepository.GetEmployees();
    }
}