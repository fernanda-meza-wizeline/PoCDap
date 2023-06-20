using System.Data;
using Npgsql;

namespace PoC_Postgres.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection CreateConnection() => new NpgsqlConnection(_configuration.GetConnectionString(("DefaultConnection")));

        public IDbConnection CreateMasterConnection() =>
            new NpgsqlConnection(_configuration.GetConnectionString("MasterConnection"));
    }
}