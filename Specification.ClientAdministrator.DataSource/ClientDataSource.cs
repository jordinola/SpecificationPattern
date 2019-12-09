using Specification.ClientAdministrator.Models;
using System;
using System.Collections.Generic;

namespace Specification.ClientAdministrator.DataSource
{
    public class ClientDataSource
    {
        public List<Client> GetClientsData()
        {
            return new List<Client>
            {
                new Client { ClientId = 1, Name = "Juan", LastName = "Tomas", Age = 20},
                new Client { ClientId = 2, Name = "Jose", LastName = "Roverson", Age = 25},
                new Client { ClientId = 3, Name = "Ann", LastName = "Neyra", Age = 22},
                new Client { ClientId = 4, Name = "Julie", LastName = "De La Rosa", Age = 30},
                new Client { ClientId = 5, Name = "Rodrigo", LastName = "Perez", Age = 40},
                new Client { ClientId = 6, Name = "Pepe", LastName = "Del Carpio", Age = 41}
            };
        }
    }
}
