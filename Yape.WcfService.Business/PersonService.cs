using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yape.WcfService.Contracts;
using Yape.WcfService.Data;

namespace Yape.WcfService.Business
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<PersonDto> GetPersonsByPhone(string cellPhoneNumber)
        {
            return _personRepository.GetByPhone(cellPhoneNumber);
        }
    }
}
