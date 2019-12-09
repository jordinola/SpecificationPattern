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

        public List<Client> GetClientsByName(string name)
        {
            return _data.Where(c => c.Name.Contains(name) || c.LastName.Contains(name)).ToList();
        }

        public List<Client> GetClientsByMinAge(int? age = null)
        {
            return _data.Where(c => c.Age < (age.HasValue ? age.Value : 25)).ToList();
        }

        public List<Client> GetClientsForDiscount()
        {
            return _data.Where(c => c.JoinDate < DateTime.Now.AddDays(-30) && c.Age > 25).ToList();
        }
    }
}
