using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactWithPeopleBackend.Data
{
    class PeopleDataContext: DbContext
    {
        private string _connectionString;
        
        public PeopleDataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

        }

        public DbSet<Person> People { get; set; }
        public object Database { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
