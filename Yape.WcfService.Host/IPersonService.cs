using System.Collections.Generic;
using System.ServiceModel;
using Yape.WcfService.Contracts; // Asegúrate de importar los DTOs

namespace Yape.WcfService.Host
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<PersonDto> GetPersonsByPhone(string cellPhoneNumber);
    }
}
