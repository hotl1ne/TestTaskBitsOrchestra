using Microsoft.EntityFrameworkCore;
using testtask.Data;
using testtask.Interfaces.PersonInterface;
using testtask.Models.PersonModel;

namespace testtask.Repository
{
    public class PersonRepository : IPerson
    {
        private readonly DataContext _dataContext;

        public PersonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task deletePerson(int id)
        {
            var person = await _dataContext.People.FindAsync(id);

            if(person == null)
            {
                return;
            }

            _dataContext.People.Remove(person);
            await _dataContext.SaveChangesAsync();
        }
    }
}
