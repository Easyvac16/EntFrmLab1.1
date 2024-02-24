using EntFrmLab1._1.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EntFrmLab1._1.DAL
{
    public class Context:DbContext
    {
        private string _connectString => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AbGame;Integrated Security=True;Connect Timeout=30;";
        public DbSet<GameInfo> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectString);
        }
    }
}