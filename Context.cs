using System;

namespace buffteks
{
    public class Context : Dbcontext
    {
        private const string ConnectionString = 
            @"Server = (local db)\nssql local dv;
            Database=buffteks;
            Trusted_Connection=True";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSQLServer(ConnectionString);
        }
        public DBset<project> Projects { get; set; }
    }
}
