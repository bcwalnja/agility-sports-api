using AgilitySportsAPI.Dtos;
using AgilitySportsAPI.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace AgilitySportsAPI.Data;
public class NFLRepo : INFLRepo
{
    private readonly IConfiguration configuration;

    public NFLRepo(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    #region NFL

    public async Task<IEnumerable<NFLRoster>> GetAllNFLRoster()
    {
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            return await connection.GetAllAsync<NFLRoster>();
        }

    }

        public async Task<IEnumerable<NFLRosterDto>> GetNFLRoster()
    {
                var sql = @"
select 
  Team
, Name
, Position
, Number
, Height
, Weight
, AgeExact
, College
from NFL.Roster
order by 
  1, 3, 2";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            return await connection.QueryAsync<NFLRosterDto>(sql);
        }
    }

    #endregion
}