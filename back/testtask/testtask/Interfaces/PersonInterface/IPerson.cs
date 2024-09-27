using testtask.Models.PersonModel;

namespace testtask.Interfaces.PersonInterface
{
    public interface IPerson
    {
        public Task deletePerson(int id); 
    }
}
