using backend_Span_MatejGalic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_Span_MatejGalic.Repositories
{
    public interface IDatabaseRepo
    {
        bool SaveChanges();

        IEnumerable<Person> GetAllPeople();

        void CreatePerson(Person person);

    }
}
