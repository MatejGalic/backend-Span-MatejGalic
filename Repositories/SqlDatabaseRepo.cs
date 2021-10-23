using backend_Span_MatejGalic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_Span_MatejGalic.Repositories
{
    public class SqlDatabaseRepo : IDatabaseRepo
    {
        private readonly DatabaseContext _context;
        public SqlDatabaseRepo(DatabaseContext context)
        {
            _context = context;
        }

        public void CreatePerson(Person person)
        {
            return;
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _context.People.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
