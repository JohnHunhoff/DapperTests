using System.Data;
using System.Data.SqlClient;
using Dapper;
using StackExchange.Profiling;
using StackExchange.Profiling.Data;

namespace DapperApi.Data;

public class DbContext
{
    private readonly IConfiguration _configuration;
    private readonly IWebHostEnvironment _environment;

    public DbContext(IConfiguration configuration, IWebHostEnvironment environment)
    {
        _configuration = configuration;
        _environment = environment;
    }
    
    public IDbConnection GetConnection()
    {
        var connection = new SqlConnection(
            _configuration.GetConnectionString("default"));
        
        if (_environment.IsDevelopment())
            return new ProfiledDbConnection(connection, MiniProfiler.Current);

        return connection;
    }

    public void HandlerExecute(string command, int timeout = 30)
    {
        using (var con = GetConnection())
        {
            con.Execute(command, null, null, timeout, null);
        }
    }
}