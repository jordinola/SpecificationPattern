using Specification.ClientAdministrator.DataSource;
using Specification.ClientAdministrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Specification.ClientAdministrator.Repository
{
    public class ClientRepository
    {
        private readonly List<Client> _data;

        public ClientRepository()
        {
            _data = new ClientDataSource().GetClientsData();
        }

        public List<Client> GetClientByName(string name)
        {
            return _data.Where(c => c.Name.Contains(name) || c.LastName.Contains(name)).ToList();
        }

        public List<Client> GetClientByMinAge(int? age = null)
        {
            return _data.Where(c => c.Age < (age.HasValue ? age.Value : 25)).ToList();
        }
    }
}
