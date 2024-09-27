using Microsoft.EntityFrameworkCore;
using testtask.Data;
using testtask.Interfaces.HomeInterface;
using testtask.Models.PersonModel;

namespace testtask.Repository
{
    public class HomeRepository : IHome
    {
        private readonly DataContext _dataContext;

        public HomeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void addPerson(Person person)
        {
            _dataContext.People.Add(person);
            _dataContext.SaveChanges();
        }
    }
}
