using Behsa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behsa.Service
{
    public interface IPhoneBookService
    {
        public Contact Get(Guid id);
        public List<Contact> GetAll();
        public void Save(Contact contact);
        public void Delete(Guid id);
    }
}
