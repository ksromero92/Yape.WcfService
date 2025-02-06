using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Yape.WcfService.Business;
using Yape.WcfService.Data;
using Yape.WcfService.Contracts;
using System.ServiceModel.Activation;

namespace Yape.WcfService.Host
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PersonService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PersonService.svc o PersonService.svc.cs en el Explorador de soluciones e inicie la depuración.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PersonServiceHost : IPersonService
    {
        private readonly PersonService _personService = new PersonService(new PersonRepository());

        public List<PersonDto> GetPersonsByPhone(string cellPhoneNumber)
        {
            return _personService.GetPersonsByPhone(cellPhoneNumber);
        }
    }
}
