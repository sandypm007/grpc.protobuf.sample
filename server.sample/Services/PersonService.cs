using Grpc.Core;
using Server.Sample.Data;

namespace Server.Sample.Services
{
    public class PersonService : PersonGrpc.PersonGrpcBase
    {
        private readonly AppDbContext _dbContext;

        public PersonService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public override Task<PersonResponse> GetPerson(PersonRequest request, ServerCallContext context)
        {
            var person = _dbContext.Persons.FirstOrDefault(p => p.Id == request.Id);
            if (person != null)
            {
                return Task.FromResult(new PersonResponse { Person = person });
            }
            else
            {
                return Task.FromResult(new PersonResponse { Person = new Person() });
            }
        }
        public override Task<PersonListResponse> GetAllPersons(Empty request, ServerCallContext context)
        {
            var persons = _dbContext.Persons.ToList();
            var response = new PersonListResponse();
            response.Persons.AddRange(persons);
            return Task.FromResult(response);
        }
    }
}
