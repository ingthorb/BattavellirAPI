using Microsoft.EntityFrameworkCore;  
using BattavellirAPI.Domain.Models;

namespace BattavellirAPI.Domain.Data {     

    public class FootballFieldContext : DbContext     
    {         
        public FootballFieldContext(DbContextOptions<FootballFieldContext> options): base(options)         
        {         
        }      

        public DbSet<FootballField> FootballFields {get;set;}
    } 
}