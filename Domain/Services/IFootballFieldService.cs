using System.Collections.Generic;
using System.Threading.Tasks;
using BattavellirAPI.Domain.Models;

namespace BattavellirAPI.Domain.Services
{
    public interface IFootballFieldService
    {
         Task<IEnumerable<FootballField>> ListAsync();
    }
}