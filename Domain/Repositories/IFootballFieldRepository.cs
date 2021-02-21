using System.Collections.Generic;
using System.Threading.Tasks;
using BattavellirAPI.Domain.Models;

namespace BattavellirAPI.Domain.Repositories
{
    public interface IFootballFieldRepository
    {
         Task<IEnumerable<FootballField>> ListAsync();
    }
}