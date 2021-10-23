using backend_Span_MatejGalic.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            // pozivanje procedure sa SQL servera
            // TODO: maknuti eksplicitni ConnectionString
            using SqlConnection con = new("Data Source = localhost\\SQLEXPRESS; Initial Catalog = MatejTest; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            using SqlCommand cmd = new("InsertPerson", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = person.FirstName.Trim();
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = person.LastName.Trim();
            cmd.Parameters.Add("@PostalCode", SqlDbType.VarChar).Value = person.PostalCode.Trim();
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = person.City.Trim();
            cmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = person.PhoneNumber.Trim();

            con.Open();
            cmd.ExecuteNonQuery();
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
