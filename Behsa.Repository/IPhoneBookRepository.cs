using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behsa.Models;

namespace Behsa.Repository
{
    public interface IPhoneBookRepository
    {
        public Contact Get(Guid id);
        public List<Contact> GetAll();
        public void Save(Contact contact);
        public void Delete(Guid id);
        
    }
}
