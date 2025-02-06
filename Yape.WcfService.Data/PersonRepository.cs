using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yape.WcfService.Contracts;


namespace Yape.WcfService.Data
{
    public interface IPersonRepository
    {
        List<PersonDto> GetByPhone(string cellPhoneNumber);
    }

    public class PersonRepository : IPersonRepository
    {
        public List<PersonDto> GetByPhone(string cellPhoneNumber)
        {
            var persons = new List<PersonDto>();

            using (var db = new DatabaseContext())
            {
                string query = "SELECT Name, LastName, DocumentType, DocumentNumber, cellPhoneNumber FROM persons WHERE cellPhoneNumber = @cellPhoneNumber";
                using (var cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@cellPhoneNumber", cellPhoneNumber);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            persons.Add(new PersonDto
                            {
                                Name = reader.GetString("Name"),
                                LastName = reader.GetString("LastName"),
                                DocumentType = reader.GetString("DocumentType"),
                                DocumentNumber = reader.GetString("DocumentNumber"),
                                CellPhoneNumber = reader.GetString("cellPhoneNumber")
                            });
                        }
                    }
                }
            }

            return persons;
        }
    }
}
