using System.ServiceModel;
using System.Collections.Generic;


namespace Yape.WcfService.Contracts
{
    [ServiceContract]  
    public interface IPersonService
    {
        [OperationContract]  
        List<PersonDto> GetPersonsByPhone(string cellPhoneNumber);
    }

    public class PersonDto
    {
        public string CellPhoneNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
    }
}

