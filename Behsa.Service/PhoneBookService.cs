using Behsa.Models;
using Behsa.Repository;

namespace Behsa.Service
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly IPhoneBookRepository _phoneBookRepository;
        public PhoneBookService()
        {
            _phoneBookRepository = new PhoneBookRepository();
        }

        public Contact Get(Guid id)
        {
            return _phoneBookRepository.Get(id);
        }

        public List<Contact> GetAll()
        {
            return _phoneBookRepository.GetAll();
        }

        public void Save(Contact contact)
        {
            _phoneBookRepository.Save(contact);
        }

        public void Delete(Guid id)
        {
            _phoneBookRepository.Delete(id);
        }
    }
}
