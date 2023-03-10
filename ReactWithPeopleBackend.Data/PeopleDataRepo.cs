using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactWithPeopleBackend.Data
{
    public class PeopleDataRepo
    {
        private string _connectinoString;
       public PeopleDataRepo(string connectionString)
        {
            _connectinoString = connectionString;
        }

        public List<Person> GetAll()
        {
            using var context = new PeopleDataContext(_connectionString);
            return context.People.Tolist();
        }
        public void Add(Person person)
        {
            using var context = new PeopleDataContext(_connectionString);
            context.People.Add(person);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new PeopleDataContext(_connectinoString);
            context.Database.ExecuteSqlInterpolated($"Delete from People WHERE Id={id}");
            context.SaveChanges();
        }
        public void Edit(Person person)
        {

            using var context = new PeopleDataContext(_connectionString);
            context.Database.ExecuteSqlInterpolated($"Update People Set FirstName={person.FirstName}, LastName={person.LastName}, Age={person.Age} WHERE Id={person.Id}");
            context.SaveChanges();
        }

    } 
}
